using Microsoft.EntityFrameworkCore;

namespace HotelApi
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels{get; set;}
    }
}