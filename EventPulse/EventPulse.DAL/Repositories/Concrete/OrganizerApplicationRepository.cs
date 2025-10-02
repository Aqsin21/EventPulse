using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.DAL.Repositories.Concrete
{
    public class OrganizerApplicationRepository : GenericRepository<OrganizerApplication>, IOrganizerApplicationRepository
    {
        public OrganizerApplicationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
