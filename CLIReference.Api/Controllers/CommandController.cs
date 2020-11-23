using CLIReference.Application.Interfaces;
using CLIReference.Application.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CLIReference.Api.Controllers
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
        [EnableCors("Open")]
        public CommandDTO GetCommands()
        {
            return _commandService.GetCommands();
        }
    }
}
