using Microsoft.AspNetCore.Mvc;

namespace Sales.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
