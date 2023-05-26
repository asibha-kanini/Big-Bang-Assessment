using System.ComponentModel.DataAnnotations;

namespace Big_Bang_Assessment.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public string? Room_Number { get; set; }
        public string? Room_Type { get; set; }
        public string? Availability { get; set; }
        public hotel? hotel { get; set; }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
