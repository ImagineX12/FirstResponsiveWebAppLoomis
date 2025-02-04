using FirstResponsiveWebAppLoomis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppLoomis.Controllers
{
    public class HomeController : Controller
    {
        //Handels Get Requests
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Output = "";
            return View();
        }

        //Handels Post Requests
        [HttpPost]
        public IActionResult Index(BirthdayModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Output = model.Output();
            }
            else
            {
                ViewBag.Output = 0;
            }
            return View(model);
        }
    }
}