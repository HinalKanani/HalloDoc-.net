using HalloDoc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HalloDoc.Controllers
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
        [Route("/Home/forgotpassword")]
        public IActionResult forgotpassword()
        {
            return View();
        }
        [Route("/Home/patientLogin")]
        public IActionResult patientLogin()
        {
            return View();
        }

        [Route("/Home/patientSide")]
        public IActionResult patientSide()
        {
            return View();
        }

        [Route("/Home/patientSubmitReq")]
        public IActionResult patientSubmitReq()
        {
            return View();
        }

        [Route("/Home/patientRequest")]
        public IActionResult patientRequest()
        {
            return View();
        }


        [Route("/Home/bisnessRequest")]
        public IActionResult bisnessRequest()
        {
            return View();
        }

        [Route("/Home/concirgeRequest")]
        public IActionResult concirgeRequest()
        {
            return View();
        }

        [Route("/Home/familyFridendRequest")]
        public IActionResult familyFridendRequest()
        {
            return View();
        }

        [Route("/Home/_headerPartialView")]
        public IActionResult _headerPartialView()
        {
            return PartialView();
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
