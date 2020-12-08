using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Models;
using static System.Net.WebRequestMethods;

namespace CommandAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase{
        private readonly CommandContext _context;
        public CommandsController(CommandContext context){
            _context = context;
        }

        #region Get -> getAllCommands
        
        [HttpGet] // get : api/commands
        public ActionResult<IEnumerable<Command>> getAllCommands(){
            return _context.command;
        }
        #endregion 
        #region Get -> getACommand (int id)
        [HttpGet("{id}")] // get api/commands/id
        public ActionResult getACommand(int id){
            Command commandItem = _context.command.Find(id);
            if (commandItem == null){
                return NotFound();
            }

            return Ok(commandItem);
        }
        #endregion
        #region Post -> createNewCommand (Command command)
        [HttpPost]
        public ActionResult createNewCommand(Command command){
            _context.command.Add(command);
            _context.SaveChanges();
            return Ok(command);
        }
        #endregion
        #region Put -> updateCommand (int id)
        [HttpPut("{id}")]
        public ActionResult updateCommand(int id, Command commandItem){
            if(id!=commandItem.id){
                return BadRequest();
            }
            _context.Entry(commandItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        #endregion
        #region Delete -> deleteCommand (int id)
        [HttpDelete("{id}")]
        public ActionResult<Command> deleteCommand (int id){
            var commandItem = _context.command.Find(id);
            if(commandItem == null){return NotFound();}
            _context.command.Remove(commandItem);
            _context.SaveChanges();
            return commandItem;
        }
        #endregion
    }

}