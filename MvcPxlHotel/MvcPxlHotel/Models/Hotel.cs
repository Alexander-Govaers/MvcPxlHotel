using MvcPxlHotel.ModelValidations;
using System.ComponentModel.DataAnnotations;

namespace MvcPxlHotel.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        [Required]
        public string HotelName { get; set; }

        [Required, CountryValidator]
        public string HotelCountry { get; set; }

        public ICollection<HotelRoom>? HotelRooms { get; set; }
    }
}
