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
            var m = PersonContractModelCollection.GetContractModelCollections();

            return View(m);
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

        public JsonResult GetPersonData()
        {
            var collection = PersonContractModelCollection.
            GetContractModelCollections();

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.DenyGet,
                Data = collection
            };
        }

        public List<DropDownItem> GetGenders()
        {
            return new List<DropDownItem>()
                {
                    new DropDownItem(1,"Mężczyzna"),
                    new DropDownItem(2,"Kobieta")
                };

        }

        public List<DropDownItem> GetNames(int genderID)
        {
            if (genderID.Equals(1))
            {
                return new List<DropDownItem>
                    {
                        new DropDownItem(1,"Luffy"),
                        new DropDownItem(2,"Zorro"),
                        new DropDownItem(3,"Sanji"),
                        new DropDownItem(4,"Brook"),
                        new DropDownItem(5,"Usopp"),
                        new DropDownItem(6,"Franky"),
                        new DropDownItem(7,"Tony Tony Chopper")
                    };
            }
            if (genderID.Equals(2))
            {
                return new List<DropDownItem>
                   {
                       new DropDownItem(8,"Nami"),
                       new DropDownItem(2,"Robin")
                   };
            }
            throw new ApplicationException("Nie właściwe ID płci");
        }
    }
}