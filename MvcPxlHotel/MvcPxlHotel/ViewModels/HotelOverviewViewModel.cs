using MvcPxlHotel.Models;

namespace MvcPxlHotel.ViewModels
{
    public class HotelOverviewViewModel
    {
        public string HotelName { get; set; }
        public string HotelCountry { get; set; }

        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
