using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public class BillRepository : Repository<Bill>, IBillRepository
    {
        public AgreementContext BillContext => Context as AgreementContext;

        public BillRepository(DbContext context) : base(context)
        {
        }
    }
}
