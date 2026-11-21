using Microsoft.EntityFrameworkCore;
using Code_First_B.Models;
namespace Code_First_B.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> student { get; set; }
    }
}