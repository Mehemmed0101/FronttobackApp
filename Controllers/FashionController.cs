using Microsoft.AspNetCore.Mvc;

namespace FronttobackApp.Controllers
{
    public class FashionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
