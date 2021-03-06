using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistance
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
                             : base(options)
        {
            
        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}