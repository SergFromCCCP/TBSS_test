using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public class AgreementRepository : Repository<Agreement>,IAgreementRepository
    {
        public AgreementContext AgreementContext => Context as AgreementContext;

        public AgreementRepository(DbContext context) : base(context)
        {
        }
        
        public IEnumerable<Agreement> GetAgreementsByCompanyName(string companyName)
        {
            return AgreementContext.Agreements.Where(a => a.Company.ShortName == companyName);
        }
    }
}
