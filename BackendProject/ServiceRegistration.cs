using BackendProject.DAL;
using BackendProject.Models;
using BackendProject.Services.Email;
using BackendProject.Services.Interface;
using BackendProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BackendProject
{


    public static class ServiceRegistration
    {


        public static void BackendProjectServiceRegistration(this IServiceCollection services)
        {
            services.AddControllersWithViews();
           services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
           services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 0;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;

                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;

                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

            })
         .AddEntityFrameworkStores<AppDbContext>()
         .AddDefaultTokenProviders();

            services.AddScoped<IEmailService, EmailService>();


            services.AddSingleton<IFileService, FileService>();

        }

    }
}
