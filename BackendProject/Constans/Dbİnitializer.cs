using BackendProject.Models;
using Microsoft.AspNetCore.Identity;

namespace BackendProject.Constans
{
    public class Dbİnitializer
    {
        public async static Task SeedAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration _configuration)
        {

            foreach (var role in Enum.GetValues(typeof(UserRoles)))
            {
                if (!await roleManager.RoleExistsAsync(role.ToString()))
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = role.ToString(),
                    });

                }

            }

            if ((await userManager.FindByNameAsync("admin")) == null)
            {

                var user = new AppUser
                {

                    UserName = "admin",
                    Email = "admin@app.com",
                    FullName= "admin",

                };
                user.EmailConfirmed = true;
                var result = await userManager.CreateAsync(user, "admin");
                if (!result.Succeeded)
                {

                    foreach (var error in result.Errors)
                    {
                        throw new Exception(error.Description);
                    }
                }

                await userManager.AddToRoleAsync(user, UserRoles.Admin.ToString());
            }

        }
    }
}
