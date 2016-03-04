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


        public ActionResult Delete(CarType i_carType)
        {
            using (Context context = new Context())
            {
                CarType carTypeToDelete = context.CarTypes.Where(ct => ct.Id == i_carType.Id).FirstOrDefault();
                if (carTypeToDelete != null)
                {
                    context.CarTypes.Attach(carTypeToDelete);
                    context.CarTypes.Remove(carTypeToDelete);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("index");
        }

        public ActionResult AddCarType()
        {
            CarType type = new CarType();
            return View(type);
        }

        [HttpPost]
        public ActionResult AddCarType(CarType i_carType)
        {
            using (Context con = new Context())
            {
                con.CarTypes.Add(i_carType);
                con.SaveChanges();
            }
            return RedirectToAction("index");
        }

        public ActionResult Details(CarType i_carType)
        {
            CarType carT = new CarType();
            carT = GetCarTypeById(i_carType.Id);
            if (carT !=null)
            {
                return View(carT);
            }
            return RedirectToAction("index");
        }

        public ActionResult Edit(CarType i_carType)
        {
            if (Request.HttpMethod == "POST")
            {
                using (Context con = new Context())
                {
                    CarType carTypeToChange = con.CarTypes.Where(c => c.Id == i_carType.Id).FirstOrDefault();
                    if (carTypeToChange != null)
                    {
                        carTypeToChange.DailyCost = i_carType.DailyCost;
                        carTypeToChange.DelayDailyCost = i_carType.DelayDailyCost;
                        carTypeToChange.GearBox = i_carType.GearBox;
                        carTypeToChange.Manufacturer = i_carType.Manufacturer;
                        carTypeToChange.Model = i_carType.Model;
                    }
                    con.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            CarType carT = GetCarTypeById(i_carType.Id);
            return View(carT);
        }

        private CarType GetCarTypeById(int i_carTypeId)
        {
            using (Context con = new Context())
            {
                CarType ret_carT = new CarType();
                ret_carT= con.CarTypes.Where(carT => carT.Id == i_carTypeId).FirstOrDefault();
                return ret_carT;
            }
        }
    }
}