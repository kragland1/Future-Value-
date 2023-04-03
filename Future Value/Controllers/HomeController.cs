using Microsoft.AspNetCore.Mvc;
using Future_Value.Models;

namespace Future_Value.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }


    }
}
