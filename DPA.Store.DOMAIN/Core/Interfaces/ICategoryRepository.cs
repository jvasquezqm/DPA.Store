using DPA.Store.DOMAIN.Core.Entities;

namespace DPA.Store.DOMAIN.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<bool> Delete(int id);

        Task<Category>>GetById(int id);
        Task<Category>>Insert(int id);
    }
}