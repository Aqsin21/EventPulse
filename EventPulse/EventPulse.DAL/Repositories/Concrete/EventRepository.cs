using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.DAL.Repositories.Concrete
{
    public class EventRepository:GenericRepository<Event> ,IEventRepository
    {
        public EventRepository(AppDbContext context) : base(context) { }
    }
}
