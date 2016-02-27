using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRent.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
       
        public ActionResult DisplayAllLocation()
        {
            Context con = new Context();
            return View(con.Locations);
        }

        public ActionResult AddLocation()
        {
            Location location = new Location();
            return View(location);
        }

        [HttpPost]
        public ActionResult AddLocation(Location i_location)
        {
            if (ModelState.IsValid)
            {
                using (Context con = new Context())
                {
                    con.Locations.Add(i_location);
                    con.SaveChanges();
                }
                return RedirectToAction("DisplayAllLocation");
            }
            return View(i_location);
        }

        public ActionResult Delete(Location i_locationId )
        {
            using (Context con = new Context())
            {
                Location loactionToRemove= GetLocationById(i_locationId.Id);
                if (loactionToRemove != null)
                {
                    con.Locations.Attach(loactionToRemove);
                    con.Locations.Remove(loactionToRemove);
                    con.SaveChanges();
                }
            }
            return RedirectToAction("DisplayAllLocation");
        }

        public ActionResult Details(Location i_locationId)
        {
            Location location = GetLocationById(i_locationId.Id);
            return View(location);
        }

        public ActionResult Edit(Location i_location)
        {
            if (Request.HttpMethod== "POST")
            {
                using (Context con = new Context())
                {
                    Location loc = con.Locations.Where(l => l.Id == i_location.Id).FirstOrDefault();
                    if (loc !=null )
                    {
                        loc.Addreass = i_location.Addreass;
                        loc.Latitude = i_location.Latitude;
                        loc.Longitude = i_location.Longitude;
                    }
                    con.SaveChanges();
                    return RedirectToAction("DisplayAllLocation");
                }
            }
            Location location = GetLocationById(i_location.Id);
            return View(location);
        }

        private Location GetLocationById(int i_locationId)
        {
            using (Context con = new Context())
            {
                Location location = con.Locations.Where(l => l.Id == i_locationId).FirstOrDefault();
                if (location!=null)
                {
                    return location;
                }
                return null;
            }
        }
    }
}