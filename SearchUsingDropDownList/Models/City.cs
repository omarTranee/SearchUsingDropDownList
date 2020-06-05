using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchUsingDropDownList.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityNameAR { get; set; }
        public string CityNameEn { get; set; }
        public int  GovernId { get; set; }
    }
}