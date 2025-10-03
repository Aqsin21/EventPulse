using EventPulse.BLL.Services.Abstract;
using EventPulse.BLL.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventPulse.BLL.Extension
{
    public static class BLLServiceCollection
    {
        public static IServiceCollection AddBll(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddScoped<ICategoryService ,CategoryService>();
            services.AddScoped<IEventService ,EventService>();
            services.AddScoped<IEventTicketTypeService ,EventTicketTypeService>();
            services.AddScoped<IOrganizerApplicationService ,OrganizerApplicationService>();
            services.AddScoped<IOrganizerService ,OrganizerService>();
            services.AddScoped<ITicketService  ,TicketService>();
            services.AddScoped<IVenueService ,VenueService>();
            return services;
        }
    }
}
