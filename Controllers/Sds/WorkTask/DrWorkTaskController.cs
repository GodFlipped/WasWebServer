using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Kengic.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WasWebServerCore.DataBaseContexts;
using WasWebServerCore.DataQueryObjects.Sds;
using WasWebServerCore.DataTransferObjects.SdsDto;
using WasWebServerCore.Filters;
using WasWebServerCore.Infrastructure.Authorization.PermissonParts;
using WasWebServerCore.Infrastructure.Authorization.RolesToPermission;
using WasWebServerNew.Services;
using WasWebServerNew.Context;
using Newtonsoft.Json;
using System.IO;
using NPOI.HSSF.UserModel;
using WasWebServerNew.JdWDbModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WasWebServerCore.Controllers.Sds
{



    /// <summary>
    /// SorterPlanController.
    /// </summary>
    [Route("api/v1/[controller]")]
    [CamelCaseJsonConverter]
    [Authorize]
    public class DrWorkTaskController : Controller
    {

        private readonly SorterDrSubWorkTaskServices _sorterSubWorkTaskService;
        public DrWorkTaskController(SorterDrSubWorkTaskServices sorterSubWorkTask)
        {
            _sorterSubWorkTaskService = sorterSubWorkTask;
        }


        /// <summary>
        /// 获得分页数据
        /// </summary>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>Page.</returns>
        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(typeof(ResponseResult<Page<DrWorkTaskDto>>), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.SorterSubWorkTask_GetSorterSubWorkTasks)]
        public async Task<IActionResult> GetValues(int pageSize, int pageIndex, [FromQuery] DrWorkTaskQuery queryCondition)
        {
            var datas = new List<DrWorkTaskDto>();
            int totalData = 0;

            bool states = true;
            var returnMes = "";

            var executor = queryCondition.Comments;
            try
            {
                if (!string.IsNullOrEmpty(queryCondition.ObjectToHandle) || !string.IsNullOrEmpty(queryCondition.TrackingId))
                {
                    var indexDatas1 = _sorterSubWorkTaskService.GetSorterSubWorkTasks(executor).AsNoTracking();
                    //var indexDatas2 = _sorterSubWorkTaskService.GetSorterSubWorkTasks("RdsClient10").AsNoTracking();
                    if (!string.IsNullOrEmpty(queryCondition.ObjectToHandle))
                    {
                        //indexDatas1 = indexDatas1.Where(data => data.ObjectToHandle.Contains (queryCondition.ObjectToHandle));
                        indexDatas1 = indexDatas1.Where(data => (data.CreateTime > queryCondition.CreateTimeStart) && (data.CreateTime < queryCondition.CreateTimeEnd) && (data.ObjectToHandle.Contains(queryCondition.ObjectToHandle)));
                       // indexDatas2 = indexDatas2.Where(data => (data.CreateTime > queryCondition.CreateTimeStart) && (data.CreateTime < queryCondition.CreateTimeEnd) && (data.ObjectToHandle.Contains(queryCondition.ObjectToHandle)));
                    }
                    else
                    {
                        indexDatas1 = indexDatas1.Where(data => data.TrackingId == queryCondition.TrackingId);
                        //indexDatas2 = indexDatas2.Where(data => data.TrackingId == queryCondition.TrackingId);
                    }
                    var data1 = indexDatas1.ToList();
                    data1.AsParallel().ForAll(data =>
                    {
                        data.Executor = ChangeName(data.Executor);
                        data.Results = ChangeResults(data.Results);
                    });
                    datas.AddRange(Mapper.Map<List<DrWorkTaskDto>>(data1));
                    //var data2 = indexDatas2.ToList();
                    //data2.AsParallel().ForAll(data =>
                    //{
                    //    data.Executor = ChangeName(data.Executor);
                    //    data.Results = ChangeResults(data.Results);
                    //});
                    //datas.AddRange(Mapper.Map<List<DrWorkTaskDto>>(data2));

                    totalData = datas.Count;
                    datas = datas.OrderByDescending(data => data.CreateTime).Skip(pageIndex - 1).Take(pageSize).ToList();
                }
                else
                {
                    var indexDatas = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.Comments).AsNoTracking().Where(dr => dr.CreateTime >= queryCondition.CreateTimeStart && dr.CreateTime <= queryCondition.CreateTimeEnd);
                    if (!string.IsNullOrEmpty(queryCondition.Comments) && queryCondition.Comments != "all")
                    {
                        //pageIndex = 1;
                        //indexDatas = basicDataContext.SorterDrSubWorkTasks.Where(data =>EF.Functions.Like(data.ObjectToHandle,"%"+queryCondition.ObjectToHandle.Trim()+"%"));
                        //indexDatas = basicDataContext.SorterDrSubWorkTasks.AsNoTracking().Where(data => data.ObjectToHandle == queryCondition.ObjectToHandle || data.TrackingId == queryCondition.ObjectToHandle);
                        indexDatas = indexDatas.AsNoTracking().Where(data => data.Executor == queryCondition.Comments);
                    }


                    if (queryCondition.Status != null && queryCondition.Status.HasValue)
                    {
                        indexDatas = indexDatas.Where(query => query.Status == (int)queryCondition.Status);
                    }
                    totalData = indexDatas.Select(query => query.Id).Count();
                    if (totalData > 0)
                    {
                        var tasks = indexDatas.OrderByDescending(t => t.CreateTime).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                        tasks.AsParallel().ForAll(data =>
                        {
                            data.Executor = ChangeName(data.Executor);
                            data.Results = ChangeResults(data.Results);
                        });


                        datas.AddRange(Mapper.Map<List<DrWorkTaskDto>>(tasks));

                    }
                    else
                    {
                        returnMes = "没有符合要求的信息！";
                    }
                }


            }
            catch (Exception ex)
            {
                states = false;
                returnMes = ex.ToString();
            }
            return Ok(new ResponseResult<Page<DrWorkTaskDto>>
            {
                Data = new Page<DrWorkTaskDto>
                {
                    Total = totalData,
                    Items = datas,
                },
                State = states,
                Message = returnMes,
            });

        }



        /// <summary>
        /// 导出功能
        /// </summary>
        /// <param name="queryCondition"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(typeof(File), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.DrSubWorkTask_ExportToExcel)]
        public IActionResult ExportExcle([FromQuery] DrWorkTaskQuery queryCondition)
        {

            var book = new HSSFWorkbook();
            var sheet1 = book.CreateSheet("全部数据");
            var row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("条码");
            row1.CreateCell(1).SetCellValue("长");
            row1.CreateCell(2).SetCellValue("宽");
            row1.CreateCell(3).SetCellValue("高");
            row1.CreateCell(4).SetCellValue("重量");
            row1.CreateCell(5).SetCellValue("唯一ID");
            row1.CreateCell(6).SetCellValue("小车号");
            row1.CreateCell(7).SetCellValue("站点代码");
            row1.CreateCell(8).SetCellValue("请求格口1");
            row1.CreateCell(9).SetCellValue("线体号");
            row1.CreateCell(10).SetCellValue("时间");
            row1.CreateCell(11).SetCellValue("结果");
            row1.CreateCell(12).SetCellValue("状态");
            //将数据逐步写入sheet1各个行
            var datas = GetOutPutDataAll(queryCondition);
            var dedatas = JsonConvert.DeserializeObject<List<DrWorkTaskDto>>(datas);


            int i = 0;
            if (dedatas.Any())
            {
                foreach (var dr in dedatas)
                {
                    NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                    rowtemp.CreateCell(0).SetCellValue(dr.ObjectToHandle);
                    rowtemp.CreateCell(1).SetCellValue(dr.AtricleLength);
                    rowtemp.CreateCell(2).SetCellValue(dr.AtricleWidth);
                    rowtemp.CreateCell(3).SetCellValue(dr.AtricleHeight);
                    rowtemp.CreateCell(4).SetCellValue(dr.AtricleWeight);
                    rowtemp.CreateCell(5).SetCellValue(dr.TrackingId);
                    rowtemp.CreateCell(6).SetCellValue(dr.CarrierId);
                    rowtemp.CreateCell(7).SetCellValue(dr.RequestShuteCode);
                    rowtemp.CreateCell(8).SetCellValue(dr.RequestShuteAddr);
                    rowtemp.CreateCell(9).SetCellValue(ChangeName(dr.Executor));
                    rowtemp.CreateCell(10).SetCellValue(dr.CreateTime.HasValue ? dr.CreateTime.ToString() : "");
                    rowtemp.CreateCell(11).SetCellValue(ChangeResults(dr.Results));
                    rowtemp.CreateCell(12).SetCellValue((int)dr.Status > 40 ? "错误" : "成功");
                    i++;
                }
            }

            MemoryStream file = new MemoryStream();
            book.Write(file);
            file.Seek(0, SeekOrigin.Begin);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }


        private string GetOutPutDataAll(DrWorkTaskQuery queryCondition)
        {
            var datas = new List<DrWorkTaskDto>();
            try
            {
                var index = _sorterSubWorkTaskService.GetSorterSubWorkTasksOutPut(queryCondition.Comments).AsNoTracking().Where(dr => dr.CreateTime >= queryCondition.CreateTimeStart && dr.CreateTime <= queryCondition.CreateTimeEnd).ToList();
                datas.AddRange(Mapper.Map<List<DrWorkTaskDto>>(index));
                datas = datas.OrderByDescending(r => r.CreateTime).ToList();

            }
            catch (Exception ex)
            {
                var drDto = new DrWorkTaskDto
                {
                    Code = ex.Message
                };
                datas.Add(drDto);
            }
            return JsonConvert.SerializeObject(datas);
        }

        private string ChangeName(string Exector)
        {

            try
            {
                switch (Exector)
                {
                    case "RdsClient01":
                        Exector = "UA";
                        break;
                    case "RdsClient02":
                        Exector = "UB";
                        break;
                    case "RdsClient03":
                        Exector = "UD";
                        break;
                    case "RdsClient04":
                        Exector = "UE";
                        break;
                    case "RdsClient05":
                        Exector = "TA";
                        break;
                    case "RdsClient06":
                        Exector = "LA";
                        break;
                    case "RdsClient07":
                        Exector = "LB";
                        break;
                    case "RdsClient08":
                        Exector = "LC";
                        break;
                    case "RdsClient09":
                        Exector = "LD";
                        break;
                    case "RdsClient10":
                        Exector = "LE";
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                return string.Empty;
            }

            return Exector;

        }

        private string ChangeResults(string errorCode)
        {
            string result = errorCode;
            switch (errorCode)
            {
                case "ND":
                    result = "正常请求";
                    break;
                case "NR":
                    result = "无读";
                    break;
                case "MB":
                    result = "多条码";
                    break;
                case "ID":
                    result = "无分拣计划";
                    break;
                case "OT":
                    result = "未收到落格";
                    break;
                case "HF":
                    result = "格口请求失败";
                    break;
                case "DE":
                    result = "运单异常或拦截";
                    break;
                case "PL":
                    result = "物体丢失";
                    break;
                case "IL":
                    result = "无效滑槽";
                    break;
                case "GC":
                    result = "间距过小";
                    break;
                case "DD":
                    result = "滑槽满";
                    break;
                case "DJ":
                    result = "滑槽堵塞";
                    break;
                case "NC":
                    result = "未收到主机命令";
                    break;
                case "UP":
                    result = "未知包裹";
                    break;
                case "PF":
                    result = "摆轮超时";
                    break;
                case "OW":
                    result = "跟踪窗口重叠";
                    break;
                case "MT":
                    result = "超时";
                    break;
                case "SF":
                    result = "分拣失败";
                    break;
                case "CL":
                    result = "超长";
                    break;
                case "LF":
                    result = "长度检测失败";
                    break;
                case "CO":
                    result = "指令被覆盖";
                    break;
                case "CU":
                    result = "货物id不明";
                    break;
                case "NA":
                    result = "窄带未动作";
                    break;
                case "JD":
                    result = "未识别到有效的京东条码";
                    break;

            }
            return result;
        }

    }

}

