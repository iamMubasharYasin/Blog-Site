using Blog_Site.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog_Site.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Post> tbl_Post { get; set; }
        public DbSet<Profile> tbl_Profile { get; set; }
    }
}
