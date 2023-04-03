using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<EduHome> EduHomes { get; set; }
        public Student Student { get; set; }
        public List<Course> Courses { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public Category Category { get; set; }
    }
}



