using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models{
    class CommandContext : DbContext{
        public CommandContext(DbContextOptions<CommandContext> options)
            : base(options)
        {
        }
        public DbSet<Command> command {get;set;} // criar tabela Command
        
    }
}