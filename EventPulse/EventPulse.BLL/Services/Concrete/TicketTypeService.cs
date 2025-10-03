using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
    public class TicketTypeService:GenericService<TicketType> ,ITicketTypeService
    {
        public TicketTypeService(IGenericRepository<TicketType> repository , AppDbContext context) : base(repository, context) { }
    }
}
