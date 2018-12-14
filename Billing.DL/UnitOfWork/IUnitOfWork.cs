using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public interface IUnitOfWork : IDisposable
    {
        IAgreementRepository Agreements { get; }
        ICompanyRepository Companies { get; }
        IBillRepository Bills { get; }
        int Complete();
    }
}
