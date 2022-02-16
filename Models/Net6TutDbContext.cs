using Microsoft.EntityFrameworkCore;

namespace Net6Tut.Models
{
    public class Net6TutDbContext : DbContext
    {
        public Net6TutDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

    }
}