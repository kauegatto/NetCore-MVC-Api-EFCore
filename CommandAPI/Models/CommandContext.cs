using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models{
    class CommandContext : DbContext{
        public DbSet<Command> command {get;set;} // criar tabela Command
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=commandsapi;user=root;password=root");
        }
    }
}