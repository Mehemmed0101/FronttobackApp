using Microsoft.AspNetCore.Mvc;

namespace FronttobackApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
