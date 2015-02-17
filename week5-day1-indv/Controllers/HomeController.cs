using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week5_day1_indv.Models;

namespace week5_day1_indv.Controllers
{
    public class HomeController : Controller
    {

        public DB db = DB.Instance;
        public ActionResult Index()
        {
            return View(db.Animals);
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

        public ActionResult Dogs()
        {
            List<Dog> model = new List<Dog>();
            foreach (Animal animal in db.Animals)
            {
                if (animal.AnimalType == AnimalType.Dog)
                {
                    model.Add((Dog)animal);
                }
            }
            return View(model);
        }

        public ActionResult Cats()
        {
            List<Cat> model = new List<Cat>();
            foreach (Animal animal in db.Animals)
            {
                if (animal.AnimalType == AnimalType.Cat)
                {
                    model.Add((Cat)animal);
                }
            }
            return View(model);
        }

        public ActionResult Birds()
        {
            List<Bird> model = new List<Bird>();
            foreach (Animal animal in db.Animals)
            {
                if (animal.AnimalType == AnimalType.Bird)
                {
                    model.Add((Bird)animal);
                }
            }
            return View(model);
        }

        public ActionResult Others()
        {
            List<Other> model = new List<Other>();
            foreach (Animal animal in db.Animals)
            {
                if (animal.AnimalType == AnimalType.Other)
                {
                    model.Add((Other)animal);
                }
            }
            return View(model);
        }
    }
}