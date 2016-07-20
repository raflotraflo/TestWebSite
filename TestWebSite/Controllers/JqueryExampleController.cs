using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebSite.Models;

namespace TestWebSite.Controllers
{
    public class JqueryExampleController : Controller
    {
        // GET: JqueryExample
        public ActionResult Index()
        {
            return View();
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
    }
}