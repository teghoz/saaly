using Saaly.Models.EntityModels;

namespace Saaly.Data.Specifications
{
    public class EntitySpecification : PagingSpecification<Entity>
    {
        public EntitySpecification(int? skip, int? page) : base(skip, page)
        {
        }
    }
}
