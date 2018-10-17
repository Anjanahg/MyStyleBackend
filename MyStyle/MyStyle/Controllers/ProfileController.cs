using MyStyle.BusinessServices;
using MyStyle.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MyStyle.Controllers
{
    public class ProfileController : ApiController
    {
        private ProfileSearvices _profileServices;
       

        public ProfileController()
        {
            _profileServices = new ProfileSearvices();
            

        }
        [HttpPost]
        public FreelancerData GetDetails(SearchInputData searchInputData)
        {
               int UserId = searchInputData.UserId;
            return _profileServices.GetProfileDetails(UserId);
        }
    }
}
