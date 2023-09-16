
using BobsBricks.Models;
using Microsoft.EntityFrameworkCore;

namespace BobsBricks.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<GroupBuild> GroupBuilds { get; set; }

    }
}
