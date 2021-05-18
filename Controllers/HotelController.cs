using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {
        //private List<Hotel> hotels = HotelListUtil.hotels;

        private readonly HotelContext _context;

        private readonly ILogger<WeatherForecastController> _logger;

        public HotelController(HotelContext context)
        {
            this._context = context;
        }

        /*
        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return hotels;
        }

        [HttpGet]
        public Hotel getOne(string s)
        {
            return hotels.Where(x => x.Name.Contains(s)).FirstOrDefault();
        }

        [HttpPost] 
        public List<Hotel> PostHotel(Hotel h)
        {
            hotels.Add(h);
            return hotels;
        }*/

        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return _context.Hotels.ToList();
        }
    }
}
