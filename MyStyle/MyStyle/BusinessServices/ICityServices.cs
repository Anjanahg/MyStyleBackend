using MyStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStyle.BusinessServices
{
    public interface ICityServices
    {
        List<City> GetCity();
    }
}