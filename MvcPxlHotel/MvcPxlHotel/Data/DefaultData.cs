using MvcPxlHotel.Models;

namespace MvcPxlHotel.Data
{
    public static class DefaultData
    {
        public static List<Hotel> Hotels => GetHotels();
        public static List<HotelRoom> HotelRooms => GetHotelRooms();

    
        private static List<Hotel> GetHotels()
        {

            List<Hotel> hotels = new List<Hotel>();
            Hotel hotel1 = new()
            {
                
                HotelName = "Mirage",
                HotelCountry = "BE"
            };

            Hotel hotel2 = new()
            {
              
                HotelName = "Piramide",
                HotelCountry = "NL"
            };

            hotels.Add(hotel1);
            hotels.Add(hotel2);

           return hotels;

        }

        private static List<HotelRoom> GetHotelRooms()
        {
            List<HotelRoom> rooms = new();

            HotelRoom room1 = new()
            {
                HotelId = 1,
                HotelRoomNumber = 13,
                HotelRoomName = "Dracula"
            };

            HotelRoom room2 = new()
            {
                HotelId = 1,
                HotelRoomNumber = 14,
                HotelRoomName = "Scream"
            };

            HotelRoom room3 = new()
            {
                HotelId = 2,
                HotelRoomNumber = 13,
                HotelRoomName = "Dracula"
            };

            HotelRoom room4 = new()
            {
                HotelId = 2,
                HotelRoomNumber = 14,
                HotelRoomName = "London Bridge"
            };



            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);

            return rooms;
        }
    }
}
