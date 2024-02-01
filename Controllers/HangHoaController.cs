using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class HangHoaController : Controller
    {
        [Route("/products")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
