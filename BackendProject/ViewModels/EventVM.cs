using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class EventVM:BaseEntity
    {

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public DateTime EventDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Venue { get; set; }

    }
}
