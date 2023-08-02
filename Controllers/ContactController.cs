using Microsoft.AspNetCore.Mvc;

namespace FronttobackApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
