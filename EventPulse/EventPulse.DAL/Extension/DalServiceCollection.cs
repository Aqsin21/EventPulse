using EventPulse.DAL.Repositories.Abstract;
using EventPulse.DAL.Repositories.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace EventPulse.DAL.Extension
{
    public static class DalServiceCollection
    {
        public static IServiceCollection AddDal(this  IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IEventTicketTypeRepository, EventTicketTypeRepository>();
            services.AddScoped<IOrganizerApplicationRepository, OrganizerApplicationRepository>();
            services.AddScoped<IOrganizerRepository, OrganizerRepository>();
            services.AddScoped<IEventTicketTypeRepository, EventTicketTypeRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
            return services;

        }
    }
}
