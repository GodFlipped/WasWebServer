// -----------------------------------------------------------------------
// <copyright file="InboundInformationController.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Kengic.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WasWebServerCore.Filters;
using WasWebServerCore.Infrastructure.Authorization.PermissonParts;
using WasWebServerCore.Infrastructure.Authorization.RolesToPermission;
using System;
using System.Linq;
using WasWebServerCore.DataQueryObjects.Sds;
using WasWebServerCore.Controllers.Sds.ReportModel;
using System.IO;
using NPOI.HSSF.UserModel;
using System.Text.RegularExpressions;
using NPOI.SS.UserModel;
using Microsoft.EntityFrameworkCore;
using WasWebServerNew.Context;
using WasWebServerNew.Services;

namespace WasWebServerCore.Controllers.Sds.ChartReport
{
    /// <summary>
    /// ReportController.
    /// 图形报表
    /// </summary>
    /// <seealso cref="Controller" />
    [Route("api/v1/[controller]")]
    [CamelCaseJsonConverter]
    [Authorize]
    public class GetReadRateController : ControllerBase
    {






        private readonly SorterSubWorkTaskService _sorterSubWorkTaskService;
        private readonly SorterOvSubWorkTaskServices _sorterOvSubWorkTaskServices;
        /// <summary>
        /// Ctor
        /// </summary>
        public GetReadRateController(SorterSubWorkTaskService sorterSubWorkTaskServices)
        {
            _sorterSubWorkTaskService = sorterSubWorkTaskServices;
        }
        /// <summary>
        /// 获得分拣报表数据00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
        /// </summary>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>Page.</returns>
        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(typeof(ResponseResult<List<SortingByShuteChart>>), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.ReadRateByDay_GetReadRateByDays)]
        public async Task<IActionResult> GetValues([FromQuery] ReadRateQuery queryCondition)
        {

            var queryable = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.CreateTimeStart,queryCondition.CreateTimeEnd,queryCondition.Exector);
            if (!string.IsNullOrEmpty(queryCondition.Exector) && queryCondition.Exector != "all")
            {
                queryable = queryable
                    .Where(query => query.Executor == queryCondition.Exector);
            }
            var inventoriesCharts = new List<SortingByShuteChart>();
            //queryable = queryable.Where(q => !q.ObjectToHandle == "NORED"&&q.Status>=40&&!(q.ReleaseTime == null&&q.Description!="ID"));
            
           

            //var nrQuery = queryable.Where(q => q.Results == "NR" && (q.SortResultSorter == string.Empty || q.SortResultSorter == null));

           // var nrQuery = queryable.Where(q => (q.Results == "NR"&&q.CarrierId!="00"||q.ScannerBarcode== "NoReceive" ||q.ScannerBarcode =="Timeout"));
           // 20230908
            var nrQuery = queryable.Where(q => (q.ObjectToHandle.StartsWith("EEE")));
            var otherQuery = queryable.Where(q => q.ObjectToHandle!= "EEEEEEEEEEEE");
            inventoriesCharts.Add(new SortingByShuteChart
            {
                Quantity = nrQuery.Count(),
                Shute = "无读"
            });
            inventoriesCharts.Add(new SortingByShuteChart
            {
                Quantity = otherQuery.Count(),
                Shute = "读取正常"
            });
            if (inventoriesCharts.Count < 1)
            {
                inventoriesCharts = new List<SortingByShuteChart>
                        {
                            new SortingByShuteChart
                            {
                                Shute="NoData",
                                Quantity=1
                            }
                        };
            }
            var states = true;
            var returnMes = "";

            return Ok(
                new ResponseResult<List<SortingByShuteChart>>
                {
                    State = states,
                    Message = returnMes,
                    Data = inventoriesCharts
                });

        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>string.</returns>
        [Route("[action]")]
        [HttpPost]
        [ProducesResponseType(typeof(File), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.ReadRateByDay_GetReadRateByDays)]
        public IActionResult ExportToExcel([FromBody] ReportQuery queryCondition)
        {
            var book = new HSSFWorkbook();
            var sheet1 = book.CreateSheet("Sheet1");
            var row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("类型");
            row1.CreateCell(1).SetCellValue("数量");
            //将数据逐步写入sheet1各个行
            int i = 0;
            var datas = GetOutPutData(queryCondition);
            if (datas.Any())
            {
                foreach (var sortingByShuteChart in datas)
                {
                    IRow rowtemp = sheet1.CreateRow(i + 1);
                    rowtemp.CreateCell(0).SetCellValue(sortingByShuteChart.Shute);
                    rowtemp.CreateCell(1).SetCellValue(sortingByShuteChart.Quantity.ToString());
                    i++;
                }

            }
            var base64 = queryCondition.PicBase64Info;
            var resultString = Regex.Split(base64, "base64,", RegexOptions.IgnoreCase);
            var buffer = Convert.FromBase64String(resultString[1]);
            var pictureIdx = book.AddPicture(buffer, PictureType.PNG);
            var patriarch = sheet1.CreateDrawingPatriarch();
            var anchor = new HSSFClientAnchor(0, 0, 1023, 0, 9, 0, 13, 5);
            var pict = patriarch.CreatePicture(anchor, pictureIdx);
            pict.Resize();

            MemoryStream file = new MemoryStream();
            book.Write(file);
            file.Seek(0, SeekOrigin.Begin);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="valueModel">查询不分页数据.</param>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>string.</returns>
        [Route("[action]")]
        [HttpGet]
        [HasPermission(Permissions.ReadRateByDay_ExportToExcel)]
        public List<SortingByShuteChart> GetOutPutData(ReportQuery queryCondition)
        {
            var datas = new List<SortingByShuteChart>();
            var queryable = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.CreateTimeStart, queryCondition.CreateTimeEnd,queryCondition.Exector);
            if (!string.IsNullOrEmpty(queryCondition.Exector) && queryCondition.Exector != "all")
            {
                queryable = queryable
                    .Where(query => query.Executor == queryCondition.Exector);
            }

            // 20230908
            //var nrQuery = queryable.Where(q => q.Results == "NR"&&q.CarrierId!="00"||q.ScannerBarcode == "NoReceive" ||q.ScannerBarcode =="Timeout");
            var nrQuery = queryable.Where(q => (q.ObjectToHandle.StartsWith("EEE")));
            var otherQuery = queryable.Where(q => q.ObjectToHandle != "EEEEEEEEEEEE");
            datas.Add(new SortingByShuteChart
            {
                Quantity = nrQuery.Count(),
                Shute = "无读"
            });
            datas.Add(new SortingByShuteChart
            {
                Quantity = otherQuery.Count(),
                Shute = "读取正常"
            });
            return datas;
            
        }
    }
}