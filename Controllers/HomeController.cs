using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceMVC.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}