using Microsoft.AspNetCore.Identity;

namespace BackendProject.Models
{
    
        public class AppUser : IdentityUser
        {
            public string FullName { get; set; }
          
        }
    
}
