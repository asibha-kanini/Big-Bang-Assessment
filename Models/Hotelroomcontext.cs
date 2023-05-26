using Microsoft.EntityFrameworkCore;

namespace Big_Bang_Assessment.Models
{
  
    public class Hotelroomcontext : DbContext

    {
        

        public DbSet<hotel> hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }


        public Hotelroomcontext(DbContextOptions<Hotelroomcontext>options) : base(options)
        {

        }
    }
}
