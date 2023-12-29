using Ardalis.Specification;

namespace Saaly.Data.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> GetById(int id, CancellationToken cancellationToken = default);
        Task<List<T>?> GetAll(ISpecification<T> spec, CancellationToken cancellationToken = default);
        Task Insert(T entity, CancellationToken cancellationToken = default);
        Task<T> Update(T entity, CancellationToken cancellationToken = default);
        Task Delete(T entity, CancellationToken cancellationToken = default);
    }
}
