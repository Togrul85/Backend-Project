namespace BackendProject.Models
{
    public class Teacher:BaseEntity
    {

        public string ImageUrl { get; set; }

        public string Fullname { get; set; }

        public string Professor { get; set; }

        public string Desc { get; set; }

        public string Title { get; set; }

        public string Degree { get; set; }

        public string Experience { get; set; }

        public string Hobbies { get; set; }

        public string Faculty { get; set; }

        public List<Skills> Skills { get; set; }

        public Contact Contact { get; set; }







    }
}
