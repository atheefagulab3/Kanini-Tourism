using HotelProj.Context;
using HotelProj.Interface;
using HotelProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace HotelProj.Repository
{
    public class HotelRepo : IHotel 
    {

        private readonly HotelContext _hotelContext;
        

        public HotelRepo(HotelContext con)
        {
            _hotelContext = con;
           
        }
        public IEnumerable<Hotel> GetHotels()
        {
            return _hotelContext.Hotels.ToList();
        }
        public Hotel GetHotelsId(int Hid)
        {
            try
            {
                return _hotelContext.Hotels.FirstOrDefault(x => x.hotel_id == Hid);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<Hotel> PostHotels(Hotel hotel)
        {
            try
            {
                if (hotel.file != null)
                {
                    string path = Path.Combine(@"C:\Users\HP\Kanini\tour\public\Img", hotel.hotel_image);
                    using (Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await hotel.file.CopyToAsync(stream);
                    }
                }

                _hotelContext.Hotels.Add(hotel);
                await _hotelContext.SaveChangesAsync();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error creating itinerary.", ex);
            }
        }


        public Hotel PutHotels(int Hid, Hotel hotel)
        {
            Hotel hot = _hotelContext.Hotels.FirstOrDefault(x => x.hotel_id == Hid);


            _hotelContext.Entry(hotel).State = EntityState.Modified;
            _hotelContext.SaveChanges();
            return hotel;


        }


        public Hotel? DeleteHotels(int Hid)
        {
            try
            {
                Hotel hot = _hotelContext.Hotels.FirstOrDefault(x => x.hotel_id == Hid);


                _hotelContext.Hotels.Remove(hot);
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
