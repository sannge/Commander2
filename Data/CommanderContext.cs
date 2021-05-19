using Commander2.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander2.Data {
    public class CommanderContext : DbContext {
        
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}