using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Echo.Service.Controllers
{
    [Route("v0/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        /// <summary>
        /// Repeats the payload to the client
        /// </summary>
        /// <param name="payload">any url encoded value</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get(string payload)
        {
            return payload;
        }

        /// <summary>
        /// Repeats the payload to the client
        /// </summary>
        /// <param name="payload">any value</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<string> Post([FromBody] string payload)
        {
            return payload;
        }
    }
}
