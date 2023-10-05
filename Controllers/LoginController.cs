using Microsoft.AspNetCore.Mvc;

namespace OnlineSchool.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
