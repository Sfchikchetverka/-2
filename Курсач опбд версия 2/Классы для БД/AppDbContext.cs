using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_опбд_версия_2
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SkatesRentalDB;Integrated Security=True;";
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<WriteoffSkates> WriteOffs { get; set; }
        public DbSet<Skates> Skates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WriteoffSkates>()
               .HasOne(u => u.Skates)
               .WithOne(b => b.WriteoffSkates)
               .HasForeignKey<WriteoffSkates>(b => b.SkatesId);
            modelBuilder.Entity<Order>()
                .HasOne(u => u.User)
                .WithOne(b => b.Order)
                .HasForeignKey<Order>(b => b.UserId);
            modelBuilder.Entity<Order>()
                .HasOne(u => u.Skates)
                .WithOne(b => b.Order)
                .HasForeignKey<Order>(b => b.SkatesId);
        }
    }
}
