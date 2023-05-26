using Big_Bang_Assessment.Models;

namespace Big_Bang_Assessment.Repository
{
    public interface Ihotelrepository
    {
        public IEnumerable<hotel> GetHotels();
        public hotel Gethotelbyid( int HotelId);
        public hotel posthotel(hotel hot);
        public hotel PutHotel(int HotelId, hotel hotel);
        public void deletehotel( int id );

       


    }
}
