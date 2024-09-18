using BLL.InterFace;
using DAL.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetData getadt;

        public HomeController(ILogger<HomeController> logger,IGetData _getadt)
        {
            _logger = logger;
            getadt = _getadt;
        }

        public IActionResult Index()
        {
            ViewBag.data=getadt.Getallgovernorate();
            return View();
        }
        //add  details_Task
        [HttpPost]
        public IActionResult Index(Surveydetails_vm ENtity, string[] response)
       {
            if (response==null)
            {
                ViewBag.massage = "الاستبيان فراغ";
            }
           
                bool Add = getadt.Add(ENtity, response);
            if (Add)
            {
                ViewBag.data = getadt.Getallgovernorate();
                ViewBag.done = "تم الاضافه بنجاح ";

                return View(ENtity);
            }
            else
            {
                ViewBag.data = getadt.Getallgovernorate();
                ViewBag.massage = "  برجاء التاكد من البيانات ";

                return View(ENtity);

            }
            
        }
        [HttpGet]
        public IActionResult Getcity(int Id) {
            var data=getadt.Getallcity(Id);
            return Json(data);
        }[HttpGet]
        public IActionResult Getarea(int Id) {
            var data=getadt.Getallarea(Id);
            return Json(data);
        }[HttpGet]
        public IActionResult Getpark(int Id) {
            var data=getadt.Getallpark(Id);
            return Json(data);
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
