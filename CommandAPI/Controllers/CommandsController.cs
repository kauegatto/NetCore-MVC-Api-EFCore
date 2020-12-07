using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase{
        [HttpGet]
        public ActionResult<IEnumerable<string>> getString()
        {
            return new string[] {"this", "is", "a","sample","string","array"};
        }


    }

}