namespace BackendProject.Models
{
    public class BlogDetail:BaseEntity
    {
        public string ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } 
    }
}
