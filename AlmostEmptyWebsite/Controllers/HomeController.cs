using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlmostEmptyWebsite.Controllers
{
    public class HomeController : Controller
    {
        /*An ASP.NET Action is a public method
         * in a controller class
         */
        public IActionResult Index()
        {
            return View();
        }
    }
}
