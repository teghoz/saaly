using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Infrastructure.Mailers
{
    public class MailgunMailer : IMailer
    {
        public Task Send(MailBag mailBag)
        {
            throw new NotImplementedException();
        }
    }
}
