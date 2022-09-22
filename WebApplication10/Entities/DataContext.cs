using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebApplication10.Entities;

namespace WebApplication10.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPassword> UsersPasswords { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(pc => new { pc.Id, pc.Name });


            modelBuilder.Entity<User>()
                .HasOne(u => u.UserPassword)
                .WithOne(up => up.User)
                .HasForeignKey<UserPassword>(a => a.UserId); //foreign klucz obcy

        }
    }
}
