using MyStyle.Data;
using MyStyle.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStyle.BusinessServices
{
    public class HomePageServices : IHomePageServices
    {
        public HomePageData GetHomePageData()
        {
            return new HomePageRepository().GetHomePageData();
        }


        public List<FreelancerData> TopRatedFreelancers()
        {
            return new TopRatedFreelancersRepository().TopRatedFreelancers();
        }
    }
}