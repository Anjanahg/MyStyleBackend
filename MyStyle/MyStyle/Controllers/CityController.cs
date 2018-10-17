using MyStyle.BusinessServices;
using MyStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyStyle.Controllers
{
    public class CityController : ApiController
    {

        private CityServices _cityServices;
        
        public CityController()
        {
            _cityServices = new CityServices();
          

        }
        [HttpPost]
        public List<City> GetCity()
        {
            return _cityServices.GetCity();
        }
    }
}
