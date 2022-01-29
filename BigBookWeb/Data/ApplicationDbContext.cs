using Microsoft.EntityFrameworkCore;
using BigBookWeb.Models;

namespace BigBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
