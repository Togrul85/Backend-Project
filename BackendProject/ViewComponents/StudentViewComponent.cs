using BackendProject.DAL;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class StudentViewComponent:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public StudentViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Student student = _appDbContext.Students.FirstOrDefault();
            return View(await Task.FromResult(student));
        }
    }
}
