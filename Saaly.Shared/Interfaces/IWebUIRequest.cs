using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Shared.Interfaces
{
    public interface IWebUIRequest : IRequest
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
        int Id { get; set; }
        bool IsActive { get; set; }
    }
}
