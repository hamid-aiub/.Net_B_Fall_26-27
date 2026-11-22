using Microsoft.EntityFrameworkCore;
using IntroToWebApi_B.Model;

namespace IntroToWebApi_B.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
