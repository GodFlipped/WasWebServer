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
using WasWebServerCore.DataBaseContexts;
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
    public class GetSortingByChuteController : ControllerBase
    {

      private readonly SorterSubWorkTaskService _sorterSubWorkTaskService;
        

        public GetSortingByChuteController(SorterSubWorkTaskService sorterSubWorkTaskService)
        {
            _sorterSubWorkTaskService = sorterSubWorkTaskService;
        }

        /// <summary>
        /// 获得分拣报表数据
        /// </summary>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>Page.</returns>
        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(typeof(ResponseResult<List<SortingByShuteChart>>), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.SortingByChute_GetSortingByChutes)]
        public async Task<IActionResult> GetValues([FromQuery] ReportQuery queryCondition)
        {

            var states = true;
            var returnMes = "";
            var inventoriesCharts = new List<SortingByShuteChart>();
            var queryable = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.CreateTimeStart, queryCondition.CreateTimeEnd,queryCondition.Exector).Where(q=>q.Status==40);
                
            if (queryCondition.Exector != "all")
            {
                //queryCondition.Exector = ChangeName(queryCondition.Exector);
                queryable  = queryable.Where(q=>q.Executor == queryCondition.Exector);
            }
            //var data = queryable.ToList();
            inventoriesCharts = await (from s in queryable
                                 group s by new
                                 {
                                     s.FinalShuteAddr
                                 } into g
                                 select new SortingByShuteChart
                                 {
                                     Shute = g.Key.FinalShuteAddr,
                                     Quantity = g.Count(),
                                 }).OrderBy(s => s.Shute).ToListAsync();
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
            return Ok(
                  new ResponseResult<List<SortingByShuteChart>>
                  {
                      State = states,
                      Message = returnMes,
                      Data = inventoriesCharts
                  });
           
            
        }

        public class ChuteReportDto
        {
            /// <summary>
            /// Gets or sets the identifier.
            /// </summary>
            /// <value>
            /// The identifier.
            /// </value>
            public string ChuteId { get; set; }
            public string DeviceName { get; set; }
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
                        Exector = "UC";
                        break;
                    case "RdsClient04":
                        Exector = "UD";
                        break;
                    case "RdsClient05":
                        Exector = "UE";
                        break;
                    case "RdsClient06":
                        Exector = "UF";
                        break;
                    case "RdsClient07":
                        Exector = "UH";
                        break;
                    case "RdsClient08":
                        Exector = "UI";
                        break;
                    case "RdsClient09":
                        Exector = "TA";
                        break;
                    case "RdsClient10":
                        Exector = "TB";
                        break;
                    case "RdsClient11":
                        Exector = "LD";
                        break;
                    case "RdsClient12":
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
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>string.</returns>
        [Route("[action]")]
        [HttpPost]
        [ProducesResponseType(typeof(File), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.SortingByChute_GetSortingByChutes)]
        public IActionResult ExportToExcel([FromBody] ReportQuery queryCondition)
        {
            var book = new HSSFWorkbook();
            var sheet1 = book.CreateSheet("Sheet1");
            var row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("Chutes");
            row1.CreateCell(1).SetCellValue("Quantity");
            row1.CreateCell(2).SetCellValue("Percent");
            row1.CreateCell(3).SetCellValue("StartTime");
            row1.CreateCell(4).SetCellValue("EndTime");

            //将数据逐步写入sheet1各个行
            int i = 0;
            var datas = GetOutPutData(queryCondition);
            var totalCount = datas.Sum(x => x.Quantity);

            if (datas.Any())
            {
                foreach (var sortingByShuteChart in datas)
                {
                    var percent = Convert.ToDouble(sortingByShuteChart.Quantity) / Convert.ToDouble(totalCount);
                    var result = $"{percent:0.00%}";//得到5.88
                    IRow rowtemp = sheet1.CreateRow(i + 1);
                    rowtemp.CreateCell(0).SetCellValue(sortingByShuteChart.Shute);
                    rowtemp.CreateCell(1).SetCellValue(sortingByShuteChart.Quantity.ToString());
                    rowtemp.CreateCell(2).SetCellValue(result);
                    rowtemp.CreateCell(3).SetCellValue(queryCondition.CreateTimeStart.ToString("yyyy-MM-dd HH:mm:ss"));
                    rowtemp.CreateCell(4).SetCellValue(queryCondition.CreateTimeEnd.ToString("yyyy-MM-dd HH:mm:ss"));
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

            MemoryStream file = new();
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
        [HasPermission(Permissions.SortingByChute_ExportToExcel)]
        public List<SortingByShuteChart> GetOutPutData(ReportQuery queryCondition)
        {

            var datas = new List<SortingByShuteChart>();

            var queryable = _sorterSubWorkTaskService.GetSorterSubWorkTasks(queryCondition.CreateTimeStart, queryCondition.CreateTimeEnd, queryCondition.Exector).Where(q => q.Status == 40);

            if (queryCondition.Exector != "all")
            {
                queryable = queryable.Where(q => q.Executor == queryCondition.Exector);
            }

            datas = (from s in queryable
                                      group s by new
                                      {
                                          s.FinalShuteAddr
                                      } into g
                                      select new SortingByShuteChart
                                      {
                                          Shute = g.Key.FinalShuteAddr,
                                          Quantity = g.Count(),
                                      }).OrderBy(s => s.Shute).ToList();
            if (datas.Count < 1)
            {
                datas = new List<SortingByShuteChart>
                        {
                            new SortingByShuteChart
                            {
                                Shute="NoData",
                                Quantity=1
                            }
                        };
            }
            return datas;
        }
    }
}