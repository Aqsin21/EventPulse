using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
    public class OrganizerService:GenericService<Organizer> ,IOrganizerService
    {
        public OrganizerService(IGenericRepository<Organizer > repository, AppDbContext context)
            :base(repository, context) { }
    }
}
