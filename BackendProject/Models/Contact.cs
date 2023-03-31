namespace BackendProject.Models
{
    public class Contact:BaseEntity
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Facebook { get; set; }

        public string Pinterest { get; set; }

        public string Vimeo { get; set; }

        public string Twitter { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }





    }
}
