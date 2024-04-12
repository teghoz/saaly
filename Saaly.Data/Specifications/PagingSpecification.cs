using Ardalis.Specification;

namespace Saaly.Data.Specifications
{
    public abstract class PagingSpecification<T> : Specification<T>
    {
        public PagingSpecification(int? skip, int? take)
        {
            if (skip.HasValue && take.HasValue)
            {
                Query
                    .Skip(skip.Value * take.Value)
                    .Take(take.Value);
            }
        }
    }
}
