using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStyle.Data
{
    public class SearchInputData
    {
        public string CityId { get; set; }
        public string Session { get; set; }
        public string UnavailableDates { get; set; }
        public int SkillId { get; set; }
        public int UserId { get; set; }
    }
}