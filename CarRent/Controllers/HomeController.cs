﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.Models;
namespace CarRent.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Context con = new Context();
            return View();
        }

        [HttpPost]
        public ActionResult AddCarType(CarType i_carType)
        {
            Context con = new Context();
            con.CarTypes.Add(i_carType);
            con.SaveChanges();
            return View("index");
        }

        public ActionResult DisplayAllBranchs()
        {
            Context con = new Context();
            return View(con.Branchs);
        }



    }
}