using BMS.Models;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=C3ITDB7;database=C3IT0790;user=Mkhairnar;password=Abcd1234%;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> BMSUsers { get; set; }

        public DbSet<Posts> BMSPosts { get; set; }
    }
}
