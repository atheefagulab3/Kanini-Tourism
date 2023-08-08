
using HotelProj.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelProj.Interface
{
    public interface IHotel
    {
        public IEnumerable<Hotel> GetHotels();
        public Hotel GetHotelsId(int Hid);

        public  Task<Hotel> PostHotels(Hotel hotel);

        public Hotel PutHotels(int hid, Hotel hotel);

        public Hotel DeleteHotels(int Hid);

    }
}
