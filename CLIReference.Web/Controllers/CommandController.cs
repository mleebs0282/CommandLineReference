using CLIReference.Application.Interfaces;
using CLIReference.Application.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLIReference.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private ICommandService _commandService;
        public CommandController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        [HttpGet]
        [EnableCors("AllowAllHeaders")]
        public CommandViewModel GetCommands()
        {
            return _commandService.GetCommands();
        }
    }
}
