using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<EduHome> EduHomes { get; set; }
    }
}
