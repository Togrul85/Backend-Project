using BackendProject.DAL;

namespace BackendProject
{
    

    public static class ServiceRegistration
    {


        public static void BackendProjectServiceRegistration(this IServiceCollection services)
        {
            services.AddControllersWithViews();
                    }
    }
}
