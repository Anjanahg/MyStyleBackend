using MyStyle.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStyle.BusinessServices
{
    public interface IProfileServices
    {
        FreelancerData GetProfileDetails(int UserId);
    }
}