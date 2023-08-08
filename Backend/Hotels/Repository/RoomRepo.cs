using HotelProj.Context;
using HotelProj.Interface;
using HotelProj.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelProj.Repository
{
    public class RoomRepo :IRoom
    {
        private readonly HotelContext _hotelContext;


        public RoomRepo(HotelContext con)
        {
            _hotelContext = con;

        }
        public IEnumerable<Room> GetRoom()
        {
            return _hotelContext.Rooms.ToList();
        }
        public Room GetRoomId(int Rid)
        {
            try
            {
                return _hotelContext.Rooms.FirstOrDefault(x => x.room_id == Rid);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<Room> PostRoom(Room Room)
        {
            try
            {
                if (Room  .file != null)
                {
                    string path = Path.Combine(@"C:\Users\HP\Kanini\tour\public\Img", Room.room_image);
                    using (Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await Room.file.CopyToAsync(stream);
                    }
                }

                _hotelContext.Rooms.Add(Room);
                await _hotelContext.SaveChangesAsync();
                return Room;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error creating itinerary.", ex);
            }
        }


        public Room PutRoom(int Rid, Room Room)
        {
            Room hot = _hotelContext.Rooms.FirstOrDefault(x => x.room_id == Rid);

            _hotelContext.Entry(Room).State = EntityState.Modified;
            _hotelContext.SaveChanges();
            return Room;


        }


        public Room? DeleteRoom(int Rid)
        {
            try
            {
                Room hot = _hotelContext.Rooms.FirstOrDefault(x => x.room_id == Rid);


                _hotelContext.Rooms.Remove(hot);
                _hotelContext.SaveChanges();

                return hot;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}

