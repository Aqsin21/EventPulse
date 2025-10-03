using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
namespace EventPulse.BLL.Services.Concrete
{
    public class CategoryService:GenericService<Category> ,ICategoryService
    {
        public CategoryService(IGenericRepository<Category> repository, AppDbContext context)
            :base(repository ,context) { }
    }
}
