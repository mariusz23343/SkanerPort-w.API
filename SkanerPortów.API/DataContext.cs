using Microsoft.EntityFrameworkCore;
using SkanerPortów.API.Entities;

namespace SkanerPortów.API
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

        public DbSet<ScanEntity> ScanEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ScanEntity>()
                .HasKey(x => x.Id);
        }
    }
}
