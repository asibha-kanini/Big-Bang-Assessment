using Big_Bang_Assessment.Models;

namespace Big_Bang_Assessment.Repository
{
    public interface IRoomrepository
    {
        public IEnumerable<Room> GetRoom();
        public Room GetRoomById(int RoomId);
        public Room PostRoom(Room room);
        public Room PutRoom(int RoomId, Room room);
        public Room DeleteRoom(int RoomId);
        public Room countbyid(int RoomId);

    }
}
