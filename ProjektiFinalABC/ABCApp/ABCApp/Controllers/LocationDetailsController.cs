using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBModel;
using Microsoft.AspNetCore.Mvc;

namespace ABCApp.Controllers
{
    public class LocationDetailsController : Controller
    {
        public AbctestassContext _con = new AbctestassContext();

        public IActionResult Index(int id)
        {
            var locationFromDB = _con.Locations.Where(x => x.LocationId == id).SingleOrDefault();


            ViewBag.LocationId = locationFromDB.LocationId;
            ViewBag.LocationName = locationFromDB.Name;
            ViewBag.Address = locationFromDB.Address;
            ViewBag.City = GetCityNameByCityId(locationFromDB.CityId);
            ViewBag.CityId = locationFromDB.CityId;
            ViewBag.Latitude = locationFromDB.Latitude;
            ViewBag.Longitude = locationFromDB.Longitude;

            return View();
        }

        public IActionResult Test(int id)
        {
            
            return View();
        }

        public string GetCityNameByCityId(int cityId)
        {
            return _con.Cities.Where(x => x.CityId == cityId).Select(x => x.Name).SingleOrDefault();



        }
    }
}