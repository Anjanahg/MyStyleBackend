using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStyle.Repositories;
using MyStyle.Data;

namespace MyStyle.BusinessServices
{
    public class SearchServices :ISearchServices
    {
        public List<FreelancerData> GetFreelancerData(string CityId, string Unavailabledates, int SkillId, String Session)
        {
            return new SearchRepository().GetFreelancerData(CityId,Unavailabledates,  SkillId,Session);
        }
    }
}