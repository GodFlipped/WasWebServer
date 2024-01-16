using Kengic.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WasWebServerCore.Controllers.Sds.ReportModel;
using WasWebServerCore.DataBaseContexts;
using WasWebServerCore.DataQueryObjects.Sds;
using WasWebServerCore.Filters;
using WasWebServerCore.Infrastructure.Authorization.PermissonParts;
using WasWebServerCore.Infrastructure.Authorization.RolesToPermission;
using WasWebServerNew.Context;

namespace WasWebServerCore.Controllers.Sds.Report
{

    /// <summary>
    /// GetSortResultController
    /// 分拣结果报表
    /// </summary>
    /// <seealso cref="Controller" />
    [Route("api/v1/[controller]")]
    [CamelCaseJsonConverter]
    [Authorize]
    public class GetSortResultController : ControllerBase
    {

        private readonly JDWWheelContext _wasContext;


        public GetSortResultController(JDWWheelContext wASContext)
        {
            _wasContext = wASContext;
        }
        /// <summary>
        /// 获得分拣结果数据
        /// </summary>
        /// <param name="queryCondition">The query condition.</param>
        /// <returns>Page.</returns>
        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(typeof(ResponseResult<SortResult>), (int)HttpStatusCode.OK)]
        [HasPermission(Permissions.SortByShuteReportGetValue)]
        public async Task<IActionResult> GetValues([FromQuery] ReportQuery queryCondition)
        {
            //var response = new SortResult()
            //}
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking();
            //ueryable = queryable.Where(q=>q.CreateTime>=queryCondition.CreateTimeStart&&q.CreateTime<=queryCondition.CreateTimeEnd&&q.ScannerBarcode!="NORED");
            // 20230908
            //queryable = queryable.Where(q => q.CreateTime >= queryCondition.CreateTimeStart && q.CreateTime <= queryCondition.CreateTimeEnd);
            //MODIFY BY TANG
            queryable = queryable.Where(q => q.CreateTime >= queryCondition.CreateTimeStart && q.CreateTime <= queryCondition.CreateTimeEnd && q.ObjectToHandle != "NOREAD");
            if (queryCondition.Exector != "all")
            {

                queryable = queryable.Where(q => q.Executor == queryCondition.Exector);
            }
            var count = await queryable.
                        GroupBy(r => new
                        {
                            r.Status
                        }).Select(g => new {
                            status = g.Key.Status,
                            count = g.Count()
                        }).ToListAsync();
            var normal = count.Where(s => s.status == 40).FirstOrDefault();
            var result = new SortResult
            {
                Normal = count.Where(s => s.status == 40).Select(c => c.count).FirstOrDefault(),
                NC = count.Where(s => s.status == 55).Select(c => c.count).FirstOrDefault(),
                BackFlow = count.Where(s => s.status == 55).Select(c => c.count).FirstOrDefault()
            };
            return Ok(new ResponseResult<SortResult>
            {
                State = true,
                Message = "",
                Data = result
            });
        }

        
    }
}
