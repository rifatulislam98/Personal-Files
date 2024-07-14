using MatrimonyApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace MatrimonyApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Dumy> Dumy { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Dumy>(entity =>
            {
                entity.HasKey(k => k.Id);
            });
        }
    }
}
