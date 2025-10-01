using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EventPulse.API.Extensions
{
    public static class DataBaseServiceExtensions
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services , IConfiguration configuration)
        {
            // DbContext
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //Identiy
            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.SignIn.RequireConfirmedEmail = false;
            })
       .AddEntityFrameworkStores<AppDbContext>()
       .AddDefaultTokenProviders();

            return services;
        }
    }
}
