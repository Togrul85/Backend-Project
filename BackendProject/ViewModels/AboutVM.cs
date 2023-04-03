using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class AboutVM
    {
        public WelcomEdu WelcomeEdus { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Skills> Skills { get; set; }
        public Contact Contacts { get; set; }    
        public Category Category { get; set; }




    }
}


