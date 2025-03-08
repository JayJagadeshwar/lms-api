using Microsoft.AspNetCore.Mvc;

namespace lms_api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
