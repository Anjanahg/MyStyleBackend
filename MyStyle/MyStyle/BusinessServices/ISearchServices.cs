using MyStyle.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStyle.BusinessServices
{
    public interface ISearchServices
    {
        List<FreelancerData> GetFreelancerData(string CityId, string Unavailabledates, int SkillId, String Session);
    }
}