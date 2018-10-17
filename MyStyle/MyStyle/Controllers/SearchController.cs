using MyStyle.Data;
using MyStyle.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyStyle.Controllers
{
    
    public class SearchController : ApiController
    {
        private SearchServices _searchServices;
        
        public SearchController()
        {
            _searchServices = new SearchServices();
           


        }
        [HttpPost]
      
        public List<FreelancerData> SearchData(SearchInputData searchInputData)
        {

            string CityId = searchInputData.CityId;
            string UnavailableDates = searchInputData.UnavailableDates;
            string Session = searchInputData.Session;
            int SkillId = searchInputData.SkillId;


          

            return _searchServices.GetFreelancerData( CityId,  UnavailableDates,  SkillId,  Session);
        }



       
    }
}
