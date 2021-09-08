using Microsoft.AspNetCore.Mvc;

namespace netCore_TaskManagement.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
