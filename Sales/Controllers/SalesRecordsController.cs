using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch()
        {
            return View();
        }

        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
