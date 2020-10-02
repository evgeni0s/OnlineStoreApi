using Microsoft.AspNetCore.Mvc;
using OnlineSiteApi.Models;
using OnlineStoreApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreApi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo commanderRepo;
        public CommandsController(ICommanderRepo commanderRepo)
        {
            this.commanderRepo = commanderRepo;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = commanderRepo.GetAppCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItems = commanderRepo.GetCommandById(id);
            return Ok(commandItems);
        }
    }
}
