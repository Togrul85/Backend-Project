using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Controllers
{
    public class AboutController : Controller
    {

        private readonly AppDbContext _appDbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM();
            aboutVM.WelcomeEdus = await _appDbContext.WelcomEdus.FirstOrDefaultAsync();

            return View(aboutVM);
        }
    }
}
