using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCApp.ViewModels;
using DBModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ABCApp.Controllers
{
    
    [Authorize]
    public class LocationController : Controller
    {
        public AbctestassContext _con = new AbctestassContext();

        [Authorize]
        public IActionResult Index()
        {

            return View();
        }


        public JsonResult GetAllLocations()
        {
            List<LocationVM> listOfLocationVm = new List<LocationVM>();

            var locationFromDbs = _con.Locations.ToList();
            foreach (var item in locationFromDbs)
            {
                LocationVM l = new LocationVM();
                l.LocationId = item.LocationId;
                l.Name = item.Name;
                l.Address = item.Address;
                l.CityId = item.CityId;
                l.Latitude = item.Latitude;
                l.Longitude = item.Longitude;
                l.CityName = GetCityNameByCityId(item.CityId);

                listOfLocationVm.Add(l);
            }


            return Json(new { data = listOfLocationVm });

        }

        public JsonResult SaveLocationDetails(Locations l)
        {
            if (l.LocationId == 0)
            {
                _con.Locations.Add(l);
                _con.SaveChanges();

            }
            else
            {
                var locationFromDB = _con.Locations.Where(x => x.LocationId == l.LocationId).SingleOrDefault();
                locationFromDB.Name = l.Name;
                locationFromDB.Address = l.Address;
                locationFromDB.CityId = l.CityId;
                locationFromDB.Latitude = l.Latitude;
                locationFromDB.Longitude = l.Longitude;
                _con.SaveChanges();


            }
            return Json(new { data = true });


        }

        public JsonResult GetAllCities()
        {
            var citiesFromDB = _con.Cities.ToList();
            return Json(new { data = citiesFromDB });

        }

        public string GetCityNameByCityId(int cityId)
        {
            return _con.Cities.Where(x => x.CityId == cityId).Select(x => x.Name).SingleOrDefault();



        }

        public JsonResult DeleteLocation(int locationId)
        {
            var locationFromDB = _con.Locations.Where(x => x.LocationId == locationId).SingleOrDefault();
            _con.Locations.Remove(locationFromDB);
            _con.SaveChanges();

            return Json(new { data = true });

        }



    }
}