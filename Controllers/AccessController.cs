using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using MVCcore_App.Models;

namespace MVCcore_App.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Allow()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Allow(LoginTable table)
        {
            if (table.UserName == "JohnCena" && table.Password == "password")
            {
                ViewData["show"] = "Success";
                return RedirectToAction("studentForm", "Practice");
            }
            else ViewData["show"] = "Not Found";
            return View();
        }
    }
}
