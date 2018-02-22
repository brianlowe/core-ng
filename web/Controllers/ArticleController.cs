using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        [Route("blog/{filter?}")]
        public IActionResult Index(string filter)
        {
            ViewBag.filter = filter;

            return View();
        }        
        
        [HttpGet]
        [Route("{category}/{filter?}")]
        public IActionResult Detail(string category, string filter)
        {
            ViewBag.category = category;
            ViewBag.filter = filter;

            return View();
        }
    }
}