using appdev.Models.Stores;
using appdev.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace appdev.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext>option) : base (option) 
        {
            // ...............
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
        { 
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            modelBuilder.Entity<OrdersDetail>(entity => {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Cart>().HasKey(cart => new{cart.Uid, cart.Isbn}); 

            // modelBuilder.Entity<Cart>().HasKey(cart => cart.Uid);
            modelBuilder.Entity<Cart>().HasOne<AppUser>(cart => cart.appUser)
                                        .WithMany(app => app.Carts)
                                        .HasForeignKey(cart => cart.Uid);
                                       
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Store> Stores { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Cart> Cart { get; set; } 
        public DbSet<OrdersDetail> OrdersDetails  { get; set; }
    }
}