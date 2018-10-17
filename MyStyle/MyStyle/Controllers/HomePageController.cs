
using System.Web.Http;
using MyStyle.Repositories;
using MyStyle.Models;
using MyStyle.BusinessServices;
using MyStyle.Data;
using System.Collections.Generic;

namespace MyStyle.Controllers
{
    public class HomePageController : ApiController
    {

        private HomePageServices _homePageServices;
        private HomePageData _homePageData;
        private FreelancerData _freeLancerData;

        public HomePageController()
        {
            _homePageServices = new HomePageServices();
            _homePageData = new HomePageData();
            _freeLancerData = new FreelancerData();

        }
        [HttpPost]
        public HomePageData GetHomePageData()
        {
           return _homePageServices.GetHomePageData();
        }

        [HttpPost]
        public List<FreelancerData> TopRatedFreelancers()
        {
            return _homePageServices.TopRatedFreelancers();
        }



    }
}
