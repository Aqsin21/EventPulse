using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.DAL.Repositories.Concrete
{
    public class OrganizerRepository:GenericRepository<Organizer> ,IOrganizerRepository
    {
        public OrganizerRepository(AppDbContext context) : base(context) { }
    }
}
