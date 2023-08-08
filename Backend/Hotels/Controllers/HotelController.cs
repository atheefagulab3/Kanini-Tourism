using HotelProj.Interface;
using HotelProj.Models;
using HotelProj.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotel hot;
        public HotelController(IHotel hot)
        {

            this.hot = hot;
        }

        [HttpGet]
        public IEnumerable<Hotel>? Get()
        {

            return hot.GetHotels();


        }

        [HttpPost]
        public Task<Hotel> Post([FromForm] Hotel hotel)

        {
            return hot.PostHotels(hotel);
        }

        [HttpPut("{hid}")]
        public Hotel Put(int hid, Hotel hotel)
        {
            return hot.PutHotels(hid, hotel);
        }


        [HttpDelete("{Hid}")]
        public Hotel? DeleteHotels(int Hid)
        {

            return hot.DeleteHotels(Hid);


        }
    }
}
