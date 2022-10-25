using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.OgrAd = "Huseyin";
            ogr.OgrSoyad = "Eski";
            ogr.OgrNo = "987";

            ViewBag.mesaj1 = "ViewBag mesajimiz";
            ViewData["mesaj2"] = "ViewData mesajimiz";
            TempData["mesaj3"] = "TempData mesajimiz";

            ViewData["mesaj4"] = ogr;
            ViewBag.mesaj5 = ogr;
            //return View(ogr);
            return RedirectToAction("Deneme2");
        }

        public IActionResult Deneme2()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}