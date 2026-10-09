
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class ModuleController : Controller
    {
        public ActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] =
                    "Feedback submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}