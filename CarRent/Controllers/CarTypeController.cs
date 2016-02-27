using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRent.Controllers
{
    public class CarTypeController : Controller
    {
        // GET: CarType
        public ActionResult Index()
        {
            Context con = new Context();
            return View(con.CarTypes);
        }

    }
}