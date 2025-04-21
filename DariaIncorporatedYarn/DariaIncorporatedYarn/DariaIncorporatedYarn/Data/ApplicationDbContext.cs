using DariaIncorporatedYarn.Components.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DariaIncorporatedYarn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }
    }

    public class MyBlogDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source = CustomOrders.db");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
