using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public BlogController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var BlogList = _appDbContext.Blogs.ToList();
            BlogVM blogVM = new();
            blogVM.Blogs = BlogList;

            return View(blogVM);
        }

        public async Task<IActionResult> Deatil(int id)
        {
            var blogDetail = _appDbContext.Blogs.Where(x => x.Id == id).FirstOrDefault();
            BlogVM blogVM = new();

            return View(blogDetail);
        }
    }
}
