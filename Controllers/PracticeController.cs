using Microsoft.AspNetCore.Mvc;

namespace MVCore_App.Controllers
{
    public class PracticeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult studentForm() 
        {
            ViewData["Registration"] = "Fill the details below";
            return View();
        }
        public IActionResult AboutUs() 
        {
            return View();
        }
    }
}
