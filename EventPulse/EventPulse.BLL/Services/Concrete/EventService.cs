using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
    public class EventService:GenericService<Event> ,IEventService
    {
        public EventService(IGenericRepository<Event> repository ,AppDbContext context)
            :base(repository, context) { }
    }
}
