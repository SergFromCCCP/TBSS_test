using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public AgreementContext CompanyContext => Context as AgreementContext;
        public CompanyRepository(DbContext context) : base(context)
        {
        }
    }
}
