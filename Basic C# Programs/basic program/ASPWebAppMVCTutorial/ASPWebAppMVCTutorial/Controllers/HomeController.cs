using ASPWebAppMVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPWebAppMVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // logging getting to index in a file

            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\adamk\logs\mvc.txt", text);


            // logic applied 

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}


            // printing the string to the view. added work in index cshtml

            //List<string> names = new List<string>
            //{
            //    "Adam",
            //    "Casey",
            //    "Mike"
            //};
            User user = new User();
            user.Id = 1;
            user.FirstName = "Adam";
            user.LastName = "Kosmos";
            user.Age = 22;
            return View(user);
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
    }
}