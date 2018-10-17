using MyStyle.Data;
using MyStyle.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStyle.BusinessServices
{
    public class ProfileSearvices : IProfileServices
    {
        public FreelancerData GetProfileDetails(int UserId)
        {
            return new ProfileRepository().GetDetails(UserId);
        }
    }
}