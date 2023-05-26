using System.ComponentModel.DataAnnotations;

namespace Big_Bang_Assessment.Models
{
    public class hotel

    {
        [Key]
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public  string? Hoteltype { get; set; }
        public string? HotelLocation { get; set; }
        public ICollection<Room>? Rooms { get; set; }

    }
}
