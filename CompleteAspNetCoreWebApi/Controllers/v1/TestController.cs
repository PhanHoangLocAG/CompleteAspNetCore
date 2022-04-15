using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompleteAspNetCoreWebApi.Controllers.v1
{

    [ApiVersion("1.0")]
    [ApiVersion("1.5")]
    [ApiVersion("1.9")]
    [Route("api/[controller]")]
    //[Route("api/{v:apiVersion}/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get-test-data"), MapToApiVersion("1.0")]
        public IActionResult Get1()
        {
            return Ok("This is test controller version 1.0");
        }

        [HttpGet("get-test-data"), MapToApiVersion("1.5")]
        public IActionResult Get15()
        {
            return Ok("This is test controller version 1.5");
        }

        [HttpGet("get-test-data"), MapToApiVersion("1.9")]
        public IActionResult Get19()
        {
            return Ok("This is test controller version 1.9");
        }
    }
}
