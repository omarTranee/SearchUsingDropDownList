using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchUsingDropDownList.Models
{
    public class Governorate
    {
        public int Id { get; set; }
        
        public string GovNameEN { get; set; }

        
        public IEnumerable<City> Cities { get; set; }
    }
}