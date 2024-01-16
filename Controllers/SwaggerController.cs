using Microsoft.AspNetCore.Mvc;
using WasWebServerCore.Infrastructure.Authorization.PermissonParts;

namespace WasWebServerCore.Controllers
{
    /// <summary>
    /// SwaggerController
    /// </summary>
    [Route("api/v1/[controller]")]
    public class SwaggerController : Controller
    {
        /// <summary>
        /// SwaggerJson
        /// </summary>
        /// <param name="Permissions">Permissions</param>
        /// <param name="PermissionsNames4Swagger">PermissionsNames4Swagger</param>
        [Route("[action]")]
        [HttpGet]
        public void SwaggerJson(
            Permissions Permissions,
            PermissionsNames4Swagger PermissionsNames4Swagger
        )
        {
        }
    }
}