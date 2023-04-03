namespace BackendProject.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public float DurationMonth { get; set; }

        public float ClassDurationMonth { get; set; }

        public string SkillLevel { get; set; }

        public string Language { get; set; }

        public int StudentsCount { get; set; }

        public string Assesment { get; set; }

        public float Fee { get; set; }

        public int CategoryId { get; set; }

        public int CourseDetailId { get; set; }


    }
}


