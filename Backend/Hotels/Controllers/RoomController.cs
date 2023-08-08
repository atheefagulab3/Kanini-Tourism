using HotelProj.Interface;
using HotelProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoom hot;
        public RoomController(IRoom hot)
        {

            this.hot = hot;
        }

        [HttpGet]
        public IEnumerable<Room>? Get()
        {

            return hot.GetRoom();


        }

        [HttpPost]
        public Task<Room> Post([FromForm] Room Room)

        {
            return hot.PostRoom(Room);
        }

        [HttpPut("{Rid}")]
        public Room Put(int Rid, Room Room)
        {
            return hot.PutRoom(Rid, Room);
        }


        [HttpDelete("{Hid}")]
        public Room? DeleteRoom(int Rid)
        {

            return hot.DeleteRoom(Rid);


        }
    }
}

