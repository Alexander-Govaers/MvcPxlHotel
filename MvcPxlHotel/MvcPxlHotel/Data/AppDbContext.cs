using Microsoft.EntityFrameworkCore;
using MvcPxlHotel.Models;

namespace MvcPxlHotel.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

       public DbSet<Hotel> Hotels { get; set; }
       public DbSet<HotelRoom> HotelRooms { get; set; }
     
    }
}
