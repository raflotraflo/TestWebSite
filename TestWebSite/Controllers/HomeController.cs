using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebSite.Models;

namespace TestWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public JsonResult GetJsonData()
        {
            var persons = new List<Person>
            {
                new Person {Id=1, FirstName = "Rafał", LastName = "Chodzidło",
                            Addresses = new List<Address>
                                {
                                    new Address {City="Gliwice" },
                                    new Address {City = "Studzionka" }
                                }
                            },
                new Person{Id = 1, FirstName = "Cezary",
                                LastName = "Walenciuk",
                                Addresses = new List<Address>
                                                {
                                                    new Address{City = "Londyn"},
                                                    new Address{City = "Warszawa"}
                                                }}
            };

            return Json(persons, JsonRequestBehavior.AllowGet);
        }
    }
}