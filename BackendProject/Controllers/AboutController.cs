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
          aboutVM.Teachers = await _appDbContext.Teachers.ToListAsync();

           

            return View(aboutVM);
        }

        public async Task<IActionResult> Detail(int id)
        {
            AboutVM aboutVM = new AboutVM();
            aboutVM.Teachers = await _appDbContext.Teachers.ToListAsync();
            aboutVM.Skills = await _appDbContext.Skills.ToListAsync();
            aboutVM.Contacts = await _appDbContext.Contacts.FirstOrDefaultAsync();
         return View(aboutVM);
        }
    }
}
