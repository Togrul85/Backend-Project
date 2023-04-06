using BackendProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.DAL
{

    public class AppDbContext : IdentityDbContext<AppUser>
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
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
      public DbSet<WeOffer> WeOffers { get; set; }
        public DbSet<FromBlog> FromBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }

    }
}
