using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchUsingDropDownList.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Speciality Speciality { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

    }
}