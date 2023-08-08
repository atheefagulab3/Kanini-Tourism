using HotelProj.Models;

namespace HotelProj.Interface
{
    public interface IRoom
    {
        public IEnumerable<Room> GetRoom();
        public Room GetRoomId(int Rid);

        public Task<Room> PostRoom(Room Room);

        public Room PutRoom(int Rid, Room Room);

        public Room DeleteRoom(int Rid);
    }
}
