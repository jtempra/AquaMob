using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AquaMob.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallesOTController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCallesOT()
        {
            return Ok(null);
        }

    }
}
