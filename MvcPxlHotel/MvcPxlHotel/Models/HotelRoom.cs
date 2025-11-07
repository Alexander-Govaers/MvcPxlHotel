using MvcPxlHotel.ModelValidations;
using System.ComponentModel.DataAnnotations;

namespace MvcPxlHotel.Models
{
    public class HotelRoom
    {

        public int HotelRoomId { get; set; }

        public int HotelId { get; set; }

        [Required, HotelRoomNameValidator]
        public string? HotelRoomName { get; set; }

        [Required, HotelRoomNumberValidator]
        public int HotelRoomNumber { get; set; }
    }
}
