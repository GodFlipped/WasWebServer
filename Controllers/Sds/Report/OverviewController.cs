using Kengic.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WasWebServerCore.Controllers.Sds.ReportModel;
using WasWebServerCore.Filters;
using WasWebServerCore.SecondaryDataContext;
using WasWebServerNew.Services;

namespace WasWebServerNew.Controllers.Sds.Report
{
    /// <summary>
    /// OverviewController
    /// 分拣结果报表
    /// </summary>
    /// <seealso cref="Controller" />
    [Route("api/v1/[controller]")]
    [CamelCaseJsonConverter]
    // [Authorize]
    public class OverviewController : ControllerBase
    {
        
        private readonly SorterSubWorkTaskService _sorterSubWorkTaskService;
        private readonly SorterOvSubWorkTaskServices _sorterOvSubWorkTaskServices;
        public OverviewController(SorterSubWorkTaskService sorterSubWorkTaskService)
        {
            _sorterSubWorkTaskService = sorterSubWorkTaskService;
        }
        /// <summary>
        /// 获得分拣结果数据
        /// </summary>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>Page.</returns>
        [Route("[action]")]
        [HttpGet]
        //[ProducesResponseType(typeof(ResponseResult<List<SorterResultDto>>), (int)HttpStatusCode.OK)]
        public ActionResult<ResponseResult<List<SorterResultDto>>> GetSortingResult([FromQuery] OverviewQueryCondition queryCondition)
        {
            var result = new List<SorterResultDto>();

            var queryable = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.CreateTimeStart, queryCondition.CreateTimeEnd,queryCondition.Exector).Where(s => s.Status >= 40);
            if (!string.IsNullOrEmpty(queryCondition.Exector) && queryCondition.Exector != "all")
            {
                queryable = queryable.Where(q => q.Executor == queryCondition.Exector);
               
            }

            var normalQuery = queryable.Where(s=> s.Status==40);
           
            var normal = normalQuery.Count();
            
            if (normal > 0)
            {
                result.Add(new SorterResultDto
                {
                    Type = "正常",
                    Count = normal,
                    Status = 40
                });
            }

            // 20230908
            //var other = queryable.Where(q => q.Status > 40 && q.CarrierId != "00"||q.ScannerBarcode == "NoReceive"||q.ScannerBarcode == "Timeout");
            //var other = queryable.Where(q => q.Status > 40 && q.CarrierId != "00" );
            var other = queryable.Where(q=>q.Status>40);

            var data = (from o in other
                        group o by new
                        {
                            o.SortResultCode
                        } into g
                        select new SorterResultDto
                        {
                            Type = g.Key.SortResultCode,
                            Count = g.Count(),
                            Status = 55
                        }).ToList();
            data.ForEach(d => d.Type = CastResultCode(TranseSortCode(d.Type)));
            result.AddRange(data);
            return Ok(new ResponseResult<List<SorterResultDto>>
            {
                State = true,
                Message = "",
                Data = result
            });


        }

        [Route("[action]")]
        [HttpGet]

        public FileStreamResult ExportExcle([FromQuery] OverviewQueryCondition queryCondition)
        {
            var result = new List<SorterResultDto>();

            var queryable = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.CreateTimeStart, queryCondition.CreateTimeEnd,queryCondition.Exector);

            if (!string.IsNullOrEmpty(queryCondition.Exector) && queryCondition.Exector != "all")
            {
                queryable = queryable.Where(q => q.Executor == queryCondition.Exector);
                
            }
            var normalQuery = queryable.Where(q => q.Status == 40);
           
            var normal = normalQuery.Count();
            if (normal > 0)
            {
                result.Add(new SorterResultDto
                {
                    Type = "正常",
                    Count = normal,
                    Status = 40
                });
            }


            //var other = queryable.Where(q => q.Status > 40 && q.CarrierId != "00"||q.ScannerBarcode == "Timeout"||q.ScannerBarcode == "NoReceive");
            // 20230908
            var other = queryable.Where(q => q.Status > 40);
            var data = (from o in other
                        group o by new
                        {
                            o.SortResultCode
                        } into g
                        select new SorterResultDto
                        {
                            Type = g.Key.SortResultCode,
                            Count = g.Count(),
                            Status = 55
                        }).ToList();
            data.ForEach(d => d.Type = CastResultCode(TranseSortCode(d.Type)));
            result.AddRange(data);
            var book = new HSSFWorkbook();
            var sheet1 = book.CreateSheet("Sheet1");
            var row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("类型");
            row1.CreateCell(1).SetCellValue("数量");
            int i = 0;

            if (result.Any())
            {
                foreach (var r in result)
                {
                    IRow rowtemp = sheet1.CreateRow(i + 1);
                    rowtemp.CreateCell(0).SetCellValue(r.Type);
                    rowtemp.CreateCell(1).SetCellValue(r.Count.ToString());
                    i++;
                }

            }
            MemoryStream file = new MemoryStream();
            book.Write(file);
            file.Seek(0, SeekOrigin.Begin);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");


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
        private string CastResultCode(string errorCode)
        {
            string result = errorCode;
            switch (errorCode)
            {
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
                    result = "接收主机命令超时";
                    break;
                case "SF":
                    result = "分拣失败";
                    break;
                case "CL":
                case "VJ":
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
              

                case "JD":
                    result = "未识别到有效的京东条码";
                    break;
            }
            return result;
        }

    }


    public class OverviewQueryCondition
    {
        public string Exector { get; set; }

        public DateTime CreateTimeStart { get; set; }

        public DateTime CreateTimeEnd { get; set; }
    }

    public class SorterResultDto
    {
        public string Type { get; set; }

        public int Count { get; set; }

        public int Status { get; set; }
        public string SortResultCode { get; set; }

    }
}