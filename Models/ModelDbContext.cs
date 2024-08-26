using Microsoft.EntityFrameworkCore;

namespace Db_connection.Models
{
    public class ModelDbContext :DbContext
    {
        public DbSet<Fruits> Fruits { get; set; }

        public ModelDbContext( DbContextOptions<ModelDbContext> options) :base(options)
        {
            
        }
    }
}
