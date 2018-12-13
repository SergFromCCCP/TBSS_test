using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public interface IAgreementRepository : IRepository<Agreement>
    {
        IEnumerable<Agreement> GetAgreementsByCompanyName(string companyName);
    }
}
