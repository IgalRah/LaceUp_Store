using LaceUp.Models;
using Microsoft.EntityFrameworkCore;

namespace LaceUp.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ShoppingBag> ShoppingBag { get; set; }
        public virtual DbSet<ShoesInfo> ShoeInffo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
