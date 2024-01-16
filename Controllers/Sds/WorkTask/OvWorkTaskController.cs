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
using NPOI.POIFS.Crypt.Dsig;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WasWebServerCore.Controllers.Sds
{



    /// <summary>
    /// OvWorkTaskController.
    /// </summary>
    [Route("api/v1/[controller]")]
    [CamelCaseJsonConverter]
    //[Authorize]
    [AllowAnonymous]
    public class OvWorkTaskController : Controller
    {

        private readonly SorterSubWorkTaskService _sorterSubWorkTaskService;
        public OvWorkTaskController(SorterSubWorkTaskService sorterSubWorkTask)
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

        


        public async Task<ActionResult<ResponseResult<Page<SorterSubWorkTaskDto>>>> GetValues(int pageSize, int pageIndex, [FromQuery] DrWorkTaskQuery queryCondition)
        {
            var datas = new List<SorterSubWorkTaskDto>();
            int totalData = 0;
            //var executor = queryCondition.Comments;
            bool states = true;
            var returnMes = "";
            //if (string.IsNullOrEmpty(queryCondition.TrackingId))
            //{
            //}

            try
            {
                #region
                //if (!string.IsNullOrEmpty(queryCondition.ObjectToHandle) || !string.IsNullOrEmpty(queryCondition.TrackingId))
                //{
                //    var indexDatas1 = _sorterSubWorkTaskService.GetSorterSubWorkTasks("RdsClient01").AsNoTracking();
                //    var indexDatas2 = _sorterSubWorkTaskService.GetSorterSubWorkTasks("RdsClient11").AsNoTracking();
                //    if (!string.IsNullOrEmpty(queryCondition.ObjectToHandle))
                //    {
                //        indexDatas1 = indexDatas1.Where(data => data.ObjectToHandle == queryCondition.ObjectToHandle);
                //        indexDatas2 = indexDatas2.Where(data => data.ObjectToHandle == queryCondition.ObjectToHandle);
                //    }
                //    else
                //    {
                //        indexDatas1= indexDatas1.Where(data => data.TrackingId == queryCondition.TrackingId);
                //        indexDatas2=indexDatas2.Where(data => data.TrackingId == queryCondition.TrackingId);
                //    }
                //    var data1 = indexDatas1.ToList();
                //    datas.AddRange(Mapper.Map<List<OvWorkTaskDto>>(data1));
                //    var data2 = indexDatas2.ToList();
                //    datas.AddRange(Mapper.Map<List<OvWorkTaskDto>>(data2));
                //    totalData = datas.Count;
                //    datas = datas.OrderByDescending(data => data.CreateTime).Skip(pageIndex - 1).Take(pageSize).ToList();
                #endregion
                if (!string.IsNullOrEmpty(queryCondition.ObjectToHandle) || !string.IsNullOrEmpty(queryCondition.TrackingId) || !string.IsNullOrEmpty(queryCondition.Results) && queryCondition.Results != "xx")
                {
                    var indexDatas1 = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.Comments).AsNoTracking();
                  //  var indexDatas2 = _sorterSubWorkTaskService.GetSorterSubWorkTasks("RdsClient10").AsNoTracking();

                    if (!string.IsNullOrEmpty(queryCondition.ObjectToHandle))
                    {
                        //indexDatas1 = indexDatas1.Where(data => data.ObjectToHandle == queryCondition.ObjectToHandle);
                        indexDatas1 = indexDatas1.Where(data => data.ObjectToHandle.Contains(queryCondition.ObjectToHandle) && (data.CreateTime > queryCondition.CreateTimeStart) && (data.CreateTime < queryCondition.CreateTimeEnd));

                        //indexDatas2 = indexDatas2.Where(data => data.ObjectToHandle == queryCondition.ObjectToHandle);

                    }
                    else if (!string.IsNullOrEmpty(queryCondition.TrackingId))
                    {
                        indexDatas1 = indexDatas1.Where(data => data.TrackingId == queryCondition.TrackingId);
                       // indexDatas2 = indexDatas2.Where(data => data.TrackingId == queryCondition.TrackingId);

                    }
                    else if (!string.IsNullOrEmpty(queryCondition.Results))
                    {
                        indexDatas1 = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.Comments).AsNoTracking().Where(ov => ov.CreateTime >= queryCondition.CreateTimeStart && ov.CreateTime <= queryCondition.CreateTimeEnd && ov.Executor == queryCondition.Comments && ov.Results == queryCondition.Results);
                      //  indexDatas2 = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.Comments).AsNoTracking().Where(ov => ov.CreateTime >= queryCondition.CreateTimeStart && ov.CreateTime <= queryCondition.CreateTimeEnd && ov.Executor == queryCondition.Comments && ov.Results == queryCondition.Results);

                    }
                    var data1 = indexDatas1.ToList();
                    data1.AsParallel().ForAll(data =>
                    {
                        data.Executor = ChangeName(data.Executor);
                        data.Results = ChangeResults(data.Results);
                    });
                    datas.AddRange(Mapper.Map<List<SorterSubWorkTaskDto>>(data1));


                    //var data2 = indexDatas2.ToList();
                    //data1.AsParallel().ForAll(data =>
                    //{
                    //    data.Executor = ChangeName(data.Executor);
                    //    data.Results = ChangeResults(data.Results);
                    //});
                    //datas.AddRange(Mapper.Map<List<OvWorkTaskDto>>(data2));

                    totalData = datas.Count;
                    datas = datas.OrderByDescending(data => data.CreateTime).Skip(pageIndex - 1).Take(pageSize).ToList();


                }
                else
                {
                    var indexDatas = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.Comments).AsNoTracking().Where(dr => dr.CreateTime >= queryCondition.CreateTimeStart && dr.CreateTime <= queryCondition.CreateTimeEnd && dr.Executor == queryCondition.Comments);


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
                            data.Results = ChangeResults(TranseSortCode(data.SortResultCode));
                        });


                        datas.AddRange(Mapper.Map<List<SorterSubWorkTaskDto>>(tasks));

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
            return Ok(new ResponseResult<Page<SorterSubWorkTaskDto>>
            {
                Data = new Page<SorterSubWorkTaskDto>
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
        [HasPermission(Permissions.OvSubWorkTask_ExportToExcel)]
        public IActionResult ExportExcle([FromQuery] OvWorkTaskQuery queryCondition)
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
            row1.CreateCell(6).SetCellValue("请求格口");
            row1.CreateCell(7).SetCellValue("最终落格");
            row1.CreateCell(8).SetCellValue("线体号");
            row1.CreateCell(9).SetCellValue("时间");
            row1.CreateCell(10).SetCellValue("结果");
            row1.CreateCell(11).SetCellValue("状态");

            //将数据逐步写入sheet1各个行

            var datas = GetOutPutDataAll(queryCondition);
            var dedatas = JsonConvert.DeserializeObject<List<SorterSubWorkTaskDto>>(datas);


            int i = 0;
            if (dedatas.Any())
            {
                foreach (var ov in dedatas)
                {
                    NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                    rowtemp.CreateCell(0).SetCellValue(ov.ObjectToHandle);
                    rowtemp.CreateCell(1).SetCellValue(ov.AtricleLength);
                    rowtemp.CreateCell(2).SetCellValue(ov.AtricleWidth);
                    rowtemp.CreateCell(3).SetCellValue(ov.AtricleHeight);
                    rowtemp.CreateCell(4).SetCellValue(ov.AtricleWeight);
                    rowtemp.CreateCell(5).SetCellValue(ov.TrackingId);                                      
                    rowtemp.CreateCell(6).SetCellValue(ov.RequestShuteAddr);                   
                    rowtemp.CreateCell(7).SetCellValue(ov.FinalShuteAddr);
                    rowtemp.CreateCell(8).SetCellValue(ChangeName(ov.Executor));
                    rowtemp.CreateCell(9).SetCellValue(ov.CreateTime.HasValue ? ov.CreateTime.ToString() : "");
                    rowtemp.CreateCell(10).SetCellValue(ChangeResults(ov.Results));
                    rowtemp.CreateCell(11).SetCellValue((int)ov.Status > 40 ? "错误" : "成功");
                    i++;
                }
            }

            MemoryStream file = new MemoryStream();
            book.Write(file);
            file.Seek(0, SeekOrigin.Begin);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

      


        private string GetOutPutDataAll(OvWorkTaskQuery queryCondition)
        {
            var datas = new List<SorterSubWorkTaskDto>();
            try
            {
                var index = _sorterSubWorkTaskService.GetSorterSubWorkTasksOutPut(queryCondition.Comments).AsNoTracking().Where(dr => dr.CreateTime >= queryCondition.CreateTimeStart && dr.CreateTime <= queryCondition.CreateTimeEnd).ToList();
                datas.AddRange(Mapper.Map<List<SorterSubWorkTaskDto>>(index));
                datas = datas.OrderByDescending(r => r.CreateTime).ToList();
            }
            catch (Exception ex)
            {
                var ovDto = new SorterSubWorkTaskDto
                {
                    Code = ex.Message
                };
                datas.Add(ovDto);
            }
            return JsonConvert.SerializeObject(datas);
        }
        public static string TranseSortCode(string sortResultSorterString)
        {
            var sortResultSorter = Convert.ToInt32(sortResultSorterString);
            if ((sortResultSorter & (1 << 10)) != 0) //1024
                return "SF";
            if ((sortResultSorter & (1 << 8)) != 0) //256
                return "GC";
            if ((sortResultSorter & (1 << 6)) != 0) //64
                return "OW";
            if ((sortResultSorter & (1 << 5)) != 0) //32
                return "DD";
            if ((sortResultSorter & (1 << 2)) != 0) //4
                return "IL";
            if ((sortResultSorter & (1 << 3)) != 0) //8
                return "DJ";
            if ((sortResultSorter & (1 << 11)) != 0) //2048
                return "CL";
            if ((sortResultSorter & (1)) != 0) //1
                return "NC";
            if ((sortResultSorter & (1 << 7)) != 0) //128
                return "MT";
            if ((sortResultSorter & (1 << 4)) != 0) //16
                return "PF";
            if ((sortResultSorter & (1 << 9)) != 0) //512
                return "PL";
            if ((sortResultSorter & (1 << 1)) != 0) //2
                return "UP";
            if ((sortResultSorter & (1 << 12)) != 0) //4096
                return "LF";
            if ((sortResultSorter & (1 << 13)) != 0) //8192
                return "CO";
            if ((sortResultSorter & (1 << 14)) != 0) //16384
                return "CU";
            if ((sortResultSorter & (1 << 15)) != 0) //32768
                return "ID";
            if ((sortResultSorter & (1 << 16)) != 0) //65536
                return "NA";
            return "ND";
        }
        private string ChangeResults(string errorCode)
        {
            string result = errorCode;
            switch (errorCode)
            {
                case "ND":
                    result = "正常分拣";
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



    }
}
