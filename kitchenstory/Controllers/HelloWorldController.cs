using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace kitchenstory.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name = "User")
        {
            string current_date = DateTime.Today.ToShortDateString();
            ViewData["Message"] = "Welcome, " + name;
            ViewData["Date_message"] = "Today's date is ..." + current_date;
            return View();
        }
    }
}