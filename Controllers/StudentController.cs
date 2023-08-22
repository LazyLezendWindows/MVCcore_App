using Microsoft.AspNetCore.Mvc;
using MVCore_App.DataExport;
using MVCore_App.Models;

namespace MVCcore_App.Controllers
{
    public class StudentController : Controller
    {
        public StudentController(Exportation exportation)
        {
            Exportation = exportation;
        }

        public Exportation Exportation { get; }

        public IActionResult Index()
        {
            IEnumerable<SRegistrationModel> exportations = new List<SRegistrationModel>();

            exportations =  Exportation.sRegistrationModels.ToList();
            return View(exportations);
        }
        public IActionResult AddStudent()
        {
        //    try
        //    {
        //        int abc = 100 / 0;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex.Message.ToString();
        //    }
            return View();
        }
        [HttpPost]
        public IActionResult RegisterStudent(SRegistrationModel sRegistration) 
        {
            Exportation.sRegistrationModels.Add(sRegistration); //Context . dbset . model to be saved
            Exportation.SaveChanges();
            ViewData["Msg"] = "Success";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(int RollNo)
        {
           
         return RedirectToAction("Index");
        }
        //public ActionResult Delete()
        //{

        //}

    }
}
