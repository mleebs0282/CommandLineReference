using CLIReference.Domain.Models;
using System.Collections.Generic;

namespace CLIReference.Application.ViewModels
{
    public class CommandDTO
    {
        public IEnumerable<Command> Commands { get; set; }
    }
}
