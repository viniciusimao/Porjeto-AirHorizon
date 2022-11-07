
using airhorizon.Model;
using Microsoft.EntityFrameworkCore;

namespace airhorizon.db
{
    public class VoosDBConext : DbContext
    {
        public VoosDBConext(DbContextOptions<VoosDBConext> options) 
            : base(options)
        {
        }

        public DbSet<Voos> Voo {get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}