using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class LocalPurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_Add");
        }
    }
}
