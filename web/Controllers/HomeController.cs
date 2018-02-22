using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("", Name = "Home_Index")]
        public IActionResult Index()
        {
            return View();
        }        
        
        [HttpGet]
        [Route("about", Name = "Home_About")]
        public IActionResult About()
        {
            return View();
        }        
        
        [HttpGet]
        [Route("contact", Name = "Home_Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        [Route("privacy", Name = "Home_Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [Route("terms", Name = "Home_Terms")]
        public IActionResult Terms()
        {
            return View();
        }

        [HttpGet]
        [Route("legal", Name = "Home_Legal")]
        public IActionResult Legal()
        {
            return View();
        }
    }
}