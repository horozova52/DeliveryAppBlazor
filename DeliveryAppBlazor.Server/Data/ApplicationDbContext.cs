using DeliveryAppBlazor.Server.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeliveryAppBlazor.Server.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<Courier> Couriers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Relație 1:1 între ApplicationUser și Client
            builder.Entity<ApplicationUser>()
                .HasOne(a => a.Client)
                .WithOne(c => c.User)
                .HasForeignKey<ClientEntity>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relație 1:1 între ApplicationUser și Courier
            builder.Entity<ApplicationUser>()
                .HasOne(a => a.Courier)
                .WithOne(c => c.User)
                .HasForeignKey<Courier>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
                    
            // Relație 1:M pentru Client
            builder.Entity<Order>()
                .HasOne(o => o.Client)
                .WithMany()
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relație 1:M pentru Courier
            builder.Entity<Order>()
                .HasOne(o => o.Courier)
                .WithMany()
                .HasForeignKey(o => o.CourierId)
                .OnDelete(DeleteBehavior.Restrict);

            // Adaugă indici unici
            builder.Entity<ClientEntity>()
                .HasIndex(c => c.UserId)
                .IsUnique();

            builder.Entity<Courier>()
                .HasIndex(c => c.UserId)
                .IsUnique();

            //configuram enum-ul ca  o valoare unica 

            builder.Entity<ApplicationUser>()
            .Property(u => u.Role)
            .HasConversion<string>();
        }

    }
}