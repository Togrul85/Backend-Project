using BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.DAL
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) //miras aldigimiz classin constructorun cagirir
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<EduHome> EduHomes { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<WelcomEdu> WelcomEdus { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
