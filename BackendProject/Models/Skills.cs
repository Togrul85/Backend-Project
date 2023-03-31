namespace BackendProject.Models
{
    public class Skills:BaseEntity
    {
        public string Name { get; set; }

        public string Level { get; set; }

        public Teacher Teacher { get; set; }

        public int TeacherId { get; set; }
    }
}
