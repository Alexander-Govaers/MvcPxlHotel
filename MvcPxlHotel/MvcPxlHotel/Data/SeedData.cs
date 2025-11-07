using System.Runtime.CompilerServices;

namespace MvcPxlHotel.Data
{
    public class SeedData
    {
        public static void EnsureCreated(WebApplication app)
        {
            try
            {
                using (var scope = app.Services.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    if (!context.Hotels.Any())
                    {
                        foreach (var item in DefaultData.Hotels)
                        {
                            context.Hotels.Add(item);
                        }
                        context.SaveChanges();

                        foreach (var item in DefaultData.HotelRooms)
                        {
                            context.HotelRooms.Add(item);
                        }
                        context.SaveChanges();
                    }

                }

            }
            catch
            {
                throw new Exception("Fout in bij het inladen van de data");
            }
            
        }

    }
}
