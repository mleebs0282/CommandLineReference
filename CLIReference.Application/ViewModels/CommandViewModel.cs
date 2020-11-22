using CLIReference.Domain.Models;
using System.Collections.Generic;

namespace CLIReference.Application.ViewModels
{
    public class CommandViewModel
    {
        public IEnumerable<Command> Commands { get; set; }
    }
}
