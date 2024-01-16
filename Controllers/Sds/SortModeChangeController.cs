using Kengic.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WasWebServerCore.Filters;
using WasWebServerNew.Context;
using WasWebServerNew.JdWDbModels;

namespace WasWebServerNew.Controllers.Sds
{
    [Route("api/v1/[controller]")]
    [CamelCaseJsonConverter]
    [Authorize]
    public class SortModeChangeController : ControllerBase
    {
        public SortModeChangeController(JDWWheelContext context)
        {
            _context = context;
        }

        private readonly JDWWheelContext _context;

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<ResponseResult<List<GetSorterDto>>>> GetSorters()
        {
            var response = new ResponseResult<List<GetSorterDto>>
            {
                State = true,
                Data = await _context.SystemParameters.Where(p => p.Template == "SortMode").Select(r =>
                      new GetSorterDto
                      {
                          Value = r.Value,
                          Name = r.Name,
                      }).ToListAsync()
            };
            return Ok(response);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ResponseResult<string>>> sortModeChangeAsync([FromBody] SortModeDto mode)
        {
            var message = JsonSerializer.Serialize(mode);
            var opreateTrance = new OperationTracing
            {
                Id = Guid.NewGuid().ToString(),
                Name = "SortModeChange",
                ObjectValue = message
            };
            var sorterService = new SorterServiceClient();
            var result = await sorterService.ChangeSortModeAsync(message);
            opreateTrance.Comments = result.Item2;
            opreateTrance.CreateTime = DateTime.Now;
            _context.OperationTracings.Add(opreateTrance);
            await _context.SaveChangesAsync();
            var response = new ResponseResult<string>()
            {
                State = result.Item1,
                Message = result.Item2
            };
            return Ok(response);
        }

        public class SortModeDto
        {
            public string Executor { get; set; }

            public string Value { get; set; }
        }

        public class GetSorterDto
        {
            public string Name { get; set; }

            public string Value { get; set; }
        }
    }
}
