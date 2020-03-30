using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : Controller
    {
        [HttpGet(Name =nameof(GetRoot))]
        public IActionResult GetRoot(){

            var response = new
            {
                href = Url.Link(nameof(GetRoot), null)
            };

            return Ok(response);
         }
    }
}
