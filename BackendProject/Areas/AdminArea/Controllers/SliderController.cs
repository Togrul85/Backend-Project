using BackendProject.DAL;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public SliderController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Sliders.ToList());
        }

        public IActionResult Detail(int id) 
        {
            if (id == null) return NotFound();
            Slider slider = _appDbContext.Sliders.SingleOrDefault(s => s.Id == id);
            if (id == null) return NotFound();
            return View(slider);
        }

        public IActionResult Edit(int id)
        {
            if (id == null) return NotFound();
            Slider slider = _appDbContext.Sliders.SingleOrDefault(s => s.Id == id);
            if (id == null) return NotFound();
            return View(new SliderUpdateVM { ImageUrl=slider.ImageUrl,Desc=slider.Desc});
        }

        public IActionResult Delete(int id)
        {
            if (id == null) return NotFound();
            Slider slider = _appDbContext.Sliders.SingleOrDefault(s => s.Id == id);
            if (id == null) return NotFound();
            return View(slider);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Create(SliderCreateVM slider)
        {
            if (!ModelState.IsValid)
            {
                return View(); 
            }
            bool isExist = _appDbContext.Sliders.Any(s=>s.ImageUrl.ToLower()==slider.ImageUrl.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("ImageUrl", "Bu adlı slider artiq movcuddur");
                return View();
            }
            Slider newSlider = new()
            {
                ImageUrl = slider.ImageUrl,
                Desc = slider.Desc,

            };
            _appDbContext.Sliders.Add(newSlider);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

       
    }
}




