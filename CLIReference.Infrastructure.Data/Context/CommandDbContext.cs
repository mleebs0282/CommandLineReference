using CLIReference.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CLIReference.Infrastructure.Data.Context
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Command> Commands { get; set; }
    }
}
