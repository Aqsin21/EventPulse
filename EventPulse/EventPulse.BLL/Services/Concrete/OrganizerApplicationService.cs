using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
    public class OrganizerApplicationService:GenericService<OrganizerApplication>,IOrganizerApplicationService
    {
        public OrganizerApplicationService(IGenericRepository<OrganizerApplication> repository , AppDbContext context)
            : base(repository, context) { }
    }
}
