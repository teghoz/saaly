using Ardalis.Specification;
using Saaly.Models;

namespace Saaly.Data.Specifications
{
    public class AdminByNameSpecification : PagingSpecification<Admin>
    {
        public AdminByNameSpecification(string? name, int? skip, int? page) : base(skip, page)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Query
                .Include(a => a.Contact)
                .Where(admin => (admin.Contact.FirstName + " " + admin.Contact.LastName).Contains(name));
            }
            else
            {
                Query
                .Include(a => a.Contact);
            }
        }
    }
}
