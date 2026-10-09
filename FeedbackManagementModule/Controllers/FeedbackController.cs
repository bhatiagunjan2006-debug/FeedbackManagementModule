
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
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
                    "Thank you! Your feedback has been submitted.";

                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}