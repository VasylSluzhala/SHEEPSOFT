using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyPage.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }
        public IActionResult CallManagementSolution()
        {
            return View();
        }
        
        public IActionResult CallCenter()
        {
            return View();
        }
        public IActionResult RecordingService()
        {
            return View();
        }
    }
}
