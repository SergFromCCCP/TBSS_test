using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public class UnitOfWork : IUnitOfWork
    {
        private AgreementContext context;
        public UnitOfWork(AgreementContext context)
        {
            this.context = context;
            Agreements = new AgreementRepository(context);
            Companies = new CompanyRepository(context);
        }

        public IAgreementRepository Agreements { get; private set; }

        public ICompanyRepository Companies { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
