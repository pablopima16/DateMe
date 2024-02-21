using System.Diagnostics;
using DateMe.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {

        private DatingApplicationContext _context; // For more visibility in the code
        public HomeController(DatingApplicationContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DatingApplication(Application response)
        {
            _context.Applications.Add(response); //Add record to database
            _context.SaveChanges(); //Actually commit changes


            return View("Confirmation", response);
        }

    }
}
