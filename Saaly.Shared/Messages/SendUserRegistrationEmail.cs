using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Shared.Messages
{
    public record SendUserRegistrationEmail(string Username, string Email, string VerificationLink);
}
