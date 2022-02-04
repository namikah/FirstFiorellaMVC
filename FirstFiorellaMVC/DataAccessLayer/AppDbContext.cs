using FirstFiorellaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstFiorellaMVC.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<AboutImage> aboutImages { get; set; }

        public DbSet<AboutContext> aboutContexts { get; set; }

        public DbSet<AboutUnstyledList> aboutUnstyledLists { get; set; }

        public DbSet<Expert> experts { get; set; }

        public DbSet<ExpertContext> expertContexts { get; set; }

        public DbSet<Position> positions { get; set; }

        public DbSet<Subcribe> subcribes { get; set; }
    }
}
