using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Saaly.Data.Interfaces;

namespace Saaly.Data.Repositories
{
    public abstract class AbstractEFRepository<T> : IRepository<T> where T : class
    {
        private readonly SaalyContext _context;
        protected DbSet<T> _dbSet;

        public AbstractEFRepository(SaalyContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task Delete(T entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<T>?> GetAll(ISpecification<T> spec, CancellationToken cancellationToken = default)
        {
            var efSpec = SpecificationEvaluator.Default.GetQuery(_dbSet.AsQueryable(), spec);
            return await efSpec.ToListAsync(cancellationToken);
        }

        public async Task<T?> GetById(int id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(id, cancellationToken);
        }

        public async Task Insert(T entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<T> Update(T entity, CancellationToken cancellationToken = default)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
