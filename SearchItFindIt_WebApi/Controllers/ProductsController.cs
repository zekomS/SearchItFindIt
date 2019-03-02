using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SearchItFindIt_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Test of the Web Api -> launchUrl has been set to this ulr
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[]
            {
                "Search It Find It","Ashley","Jonas"
            };
        }
    }
}