using Core.Entities;

namespace Core.Interfaces {
    public interface IGenericRepository<T> where T : BaseEntity {

        Task<T> GetByIdAsync(int Id);
        Task<IReadOnlyList<T>> ListAllAsync();

    }
}
