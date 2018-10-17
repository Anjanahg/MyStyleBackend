using System;

namespace MyStyle.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime RegDate { get; set; }
        public int? CityId { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public double? SessionPrice { get; set; }
        public int? Type { get; set; }
        public string SalonName { get; set; }
        public string Tagline { get; set; }
        public double? LocationLon { get; set; }
        public double? LocationLat { get; set; }
    }
}