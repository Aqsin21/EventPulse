using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
    public class EventTicketTypeService:GenericService<EventTicketType> ,IEventTicketTypeService
    {
        public EventTicketTypeService(IGenericRepository<EventTicketType> repository, AppDbContext context)
            : base(repository, context) { }
    }
}
