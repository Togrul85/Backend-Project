using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BackendProject.Controllers
{
    public class EventController : Controller
    {

        private readonly AppDbContext _appDbContext;

        public EventController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            List<EventVM> eventVMs = new();

            var EventList = _appDbContext.Events.ToList();
            foreach (var item in EventList)
            {
                EventVM eventVM = new();
                eventVM.Id = item.Id;
                eventVM.Venue = item.Venue;
                eventVM.Title = item.Title;
                eventVM.ImageUrl = item.ImageUrl;
                eventVM.EventDate = item.EventDate;
                eventVM.StartTime = item.StartTime;
                eventVM.EndTime = item.EndTime;

                eventVMs.Add(eventVM);
            }

            return View(eventVMs);
     
        }
        public async Task<IActionResult> Detail(int id)
        {
            var eventDetail = _appDbContext.Events.Where(x => x.Id == id).FirstOrDefault();
            EventVM eventVM =new();
            eventVM.Id = eventDetail.Id;
            eventVM.ImageUrl= eventDetail.ImageUrl;

     
            




            return View(eventVM);
        }
    }
}
