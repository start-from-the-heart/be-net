using ECommerceFarming.Entity.Entity.Login;
using ECommerceFarming.Helper.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerceFarming.Infrastructure.Context
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext()
        {
        }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserPrivate> UserPrivates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = GetConfigInJsonFile.Load();

            var connectionString = config.GetConnectionString("DefaultConnection");

            if (!optionsBuilder.IsConfigured)
            {
                // connection string của bạn
                optionsBuilder.UseNpgsql(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.UserId);

                entity.Property(e => e.UserId).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserPrivate>(entity =>
            {
                entity.HasKey(x => x.UserID);

                entity.Property(e => e.UserID).IsRequired().ValueGeneratedOnAdd();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}