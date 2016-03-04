using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRent.Controllers
{
    public class BranchsController : Controller
    {
        // GET: Branchs
        public ActionResult Index()
        {
            Context con = new Context();
            Branch bb = con.Branchs.Where(b => b.Id == 1).First();

            return View(con.Branchs);
        }
    }
}