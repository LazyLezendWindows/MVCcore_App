using Microsoft.AspNetCore.Mvc;

namespace MVCore_App.Controllers
{
    public class ExplanationController : Controller
    {
      
        public IActionResult Explain()
        {
            ViewData["Pavan"] = "training";
            return View();
        }
    }
}
