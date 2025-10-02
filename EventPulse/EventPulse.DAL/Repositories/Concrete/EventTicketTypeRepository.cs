using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.DAL.Repositories.Concrete
{
    public class EventTicketTypeRepository:GenericRepository<EventTicketType> ,IEventTicketTypeRepository
    {
        public  EventTicketTypeRepository (AppDbContext context):base(context) { }
    }
}
