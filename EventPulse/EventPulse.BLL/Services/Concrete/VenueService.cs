using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
     public class VenueService:GenericService<Venue> ,IVenueService
    {
        public VenueService(IGenericRepository<Venue> repository ,AppDbContext context)
            : base(repository, context) { }
    }
}
