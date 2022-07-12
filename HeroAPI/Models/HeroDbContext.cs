using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Models
{
    public class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Hero> Heroes { get; set; }
    }
}
