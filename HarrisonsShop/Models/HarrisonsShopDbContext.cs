using Microsoft.EntityFrameworkCore;

namespace HarrisonsShop.Models
{
    public class HarrisonsShopDbContext : DbContext
    {
        public HarrisonsShopDbContext(DbContextOptions<HarrisonsShopDbContext> options) : base(options) //contructor for db context options for thing to work correctly
        {

        }

        public DbSet<Category> Categories { get; set; } //set to EF core entities to match
        public DbSet<Pie> Pies { get; set; } //set to EF core entities to match
    }
}
