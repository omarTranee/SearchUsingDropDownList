using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchUsingDropDownList.Models;

namespace SearchUsingDropDownList.Controllers
{
    public class HomeController : Controller
    {
        SearchContext db =new SearchContext();
        public ActionResult Index()
        {
            ViewBag.GovernorateName = db.Governorates.ToList();
            ViewBag.SpecialityName = db.Specialities.ToList();
            return View();
        }

        public JsonResult GetCityByID(int ID)
        {
            return Json(db.Cities.Where(c => c.GovernorateID == ID), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult GetClinic(int stateId = -1, int cityId = -1, int categoryid = -1)
        {

            //return $" - City  : {cityId} co- State : {stateId}  -Categoery : {categoryid}";
            return Json( db.Clinics.Where(c => c.Speciality.Id == categoryid && c.City.Id == cityId).ToList());
            //return Json(0);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}