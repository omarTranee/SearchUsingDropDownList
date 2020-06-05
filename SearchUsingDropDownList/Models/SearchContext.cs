using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SearchUsingDropDownList.Models
{
    public class SearchContext :DbContext
    {
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Speciality> Specialities { get; set; }

    }
}