using Big_Bang_Assessment.Models;

namespace Big_Bang_Assessment.Repository
{
    public class hotelrepository : Ihotelrepository
    {
        private readonly Hotelroomcontext con;
        public hotelrepository(Hotelroomcontext con)
        {
            this.con = con;
        }
        public IEnumerable<hotel> GetHotels()
        {
            return con.hotels.ToList();
        }
        public  hotel Gethotelbyid(int HotelId)
        {
            return con.hotels.FirstOrDefault(x =>x.HotelId== HotelId);
        }
        public hotel posthotel(hotel hot)
        {
            con.hotels.Add(hot);
            con.SaveChanges();
            return hot;
        }
        
        public void deletehotel(int id)
        {
            hotel ht= con.hotels.FirstOrDefault(x=>x.HotelId==id);
            con.hotels.Remove(ht);
            con.SaveChanges();
        }

        public hotel PutHotel(int HotelId, hotel hotel)
        {
            con.hotels.Add(hotel);
            con.SaveChanges();
            return hotel;
        }
    }
}
