using CLIReference.Domain.Interfaces;
using CLIReference.Domain.Models;
using CLIReference.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace CLIReference.Infrastructure.Data.Repositories
{
    public class CommandRepository : ICommandRepository
    {
        public CommandDbContext _context;
        public CommandRepository(CommandDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands;
        }
    }
}
