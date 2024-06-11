using dotenetCore1.Model;
using Microsoft.EntityFrameworkCore;

namespace dotenetCore1.Context
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarContext(DbContextOptions <CarContext> options) : base(options)
        {
        
        }
    }
}
