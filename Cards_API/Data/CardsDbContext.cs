using Cards_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cards_API.Data
{
    public class CardsDbContext : DbContext
    {
        public CardsDbContext(DbContextOptions options) : base(options)
        {

        }

        //DBset
        public DbSet<Card> Cards { get; set; }
    }
}
