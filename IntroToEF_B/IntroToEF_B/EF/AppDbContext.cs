using Microsoft.EntityFrameworkCore;
using IntroToEF_B.Models;
namespace IntroToEF_B.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> product { get; set; }
    }
}
