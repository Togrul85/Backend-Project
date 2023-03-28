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

    }
}
