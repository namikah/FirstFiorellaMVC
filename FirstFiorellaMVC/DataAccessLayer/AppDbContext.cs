using FirstFiorellaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstFiorellaMVC.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<AboutImage> AboutImages { get; set; }

        public DbSet<AboutContext> AboutContexts { get; set; }

        public DbSet<AboutUnstyledList> AboutUnstyledLists { get; set; }

        public DbSet<Expert> Experts { get; set; }

        public DbSet<ExpertContext> ExpertContexts { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Subcribe> Subcribes { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogContext> BlogContexts { get; set; }
    }
}
