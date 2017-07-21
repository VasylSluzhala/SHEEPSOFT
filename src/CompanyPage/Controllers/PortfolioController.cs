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
        public IActionResult Atmos()
        {
            return View();
        }

        public IActionResult AtmosNew()
        {
            return View();
        }
    }
}
