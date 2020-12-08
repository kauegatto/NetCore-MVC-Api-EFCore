using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Models;

namespace CommandAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase{
        private readonly CommandContext _context;
        public CommandsController(CommandContext context){
            _context = context;
        }
        
        [HttpGet] // get : api/Comamnd
        public ActionResult<IEnumerable<Command>> getAllCommands(){
            return _context.command;
        }
        /* public ActionResult<IEnumerable<string>> getString()
        {
            return new string[] {"this", "is", "a","sample","string","array"};
        } */
    }

}