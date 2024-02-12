using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller  //after domain name, it goes like /controller/action/id?
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply() //to show the apply page
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model) //after we add the student //it says that info will come from form.
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "you can enroll once.");
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
        }
    }
}