using Ardalis.Specification;

namespace Saaly.Data.Specifications
{
    public abstract class PagingSpecification<T> : Specification<T>
    {
        public PagingSpecification(int? skip, int? take)
        {
            Query
                .Skip(skip.Value * take.Value)
                .Take(take.Value);
        }
    }
}
