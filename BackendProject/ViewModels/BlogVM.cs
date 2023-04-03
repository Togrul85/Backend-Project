using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class BlogVM:BaseEntity
    {
        public List<Blog> Blogs { get; set; }
    }
}
