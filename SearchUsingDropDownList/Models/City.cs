﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SearchUsingDropDownList.Models
{
    public class City
    {
        public int Id { get; set; }

        public string CityNameEn { get; set; }
        public int GovernorateID { get; set; }
        public Governorate Governorate { get; set; }

        public IEnumerable<Clinic> Clinics { get; set; }

    }
}