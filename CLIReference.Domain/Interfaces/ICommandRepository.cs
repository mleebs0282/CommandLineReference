using CLIReference.Domain.Models;
using System.Collections.Generic;

namespace CLIReference.Domain.Interfaces
{
    public interface ICommandRepository
    {
        IEnumerable<Command> GetCommands();
    }
}
