using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CourseApp.Models.Request model = new Models.Request();

            model.Name = "Sadık Turan";
            model.Email = "sadikturan@gmail.com";
            model.Phone = "05326564120";
            model.Message = "Kursa katılmak istiyorum.";

            return View(model);
        }
    }
}