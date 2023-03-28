
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackendProject.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

      
    }
}