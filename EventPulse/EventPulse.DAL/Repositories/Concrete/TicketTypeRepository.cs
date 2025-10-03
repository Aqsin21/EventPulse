using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;

namespace EventPulse.DAL.Repositories.Concrete
{
    public class TicketTypeRepository:GenericRepository<TicketType> ,ITicketTypeRepository
    {
        public TicketTypeRepository(AppDbContext context) : base(context) { }
    }
}
