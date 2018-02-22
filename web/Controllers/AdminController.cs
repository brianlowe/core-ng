using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        [Route("", Name = "Admin_Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}