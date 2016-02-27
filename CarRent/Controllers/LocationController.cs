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
            using (Context con = new Context())
            {
                con.Locations.Add(i_location);
                con.SaveChanges();
            }
            return RedirectToAction("DisplayAllLocation");
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