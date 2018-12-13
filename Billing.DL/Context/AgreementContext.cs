namespace Billing.DL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AgreementContext : DbContext
    {
        public AgreementContext()
            : base("name=AgreementModel")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Agreement> Agreements { get; set; }
    }

}