using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;

namespace EventPulse.DAL.Repositories.Concrete
{
    public class VenueRepository:GenericRepository<Venue> ,IVenueRepository
    {
        public VenueRepository(AppDbContext context):base(context) { }
    }
}
