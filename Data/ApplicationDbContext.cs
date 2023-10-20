
using Microsoft.EntityFrameworkCore;
using razor_pizza.Models;

namespace razor_pizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<pizzaorder> pizzaorders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
    }
}
