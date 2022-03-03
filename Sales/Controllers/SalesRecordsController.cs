using Microsoft.AspNetCore.Mvc;
using Sales.Services;
using System;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);

            return View(result);
        }

        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
