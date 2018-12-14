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

        static AgreementContext()
        {
            Database.SetInitializer<AgreementContext>(new AgreementContextInitialiser());
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Agreement> Agreements { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
    }

    internal class AgreementContextInitialiser : DropCreateDatabaseIfModelChanges<AgreementContext>
    {
        protected override void Seed(AgreementContext context)
        {
            context.Companies.Add(new Company { CompanyID = 12764, ShortName = "УЧРЕЖДЕНИЕ ОХРАНЫ ЯГУАР", INN = "4909083932" });
            context.Companies.Add(new Company { CompanyID = 12763, ShortName = "ГЕНЕРАЛ-СТРОЙ", INN = "1435300636" });
            context.Companies.Add(new Company { CompanyID = 12762, ShortName = "ЕС ЛАЙН-ЛГ ЭЛЕКТРОНИКС РУС", INN = "7726744845" });
            context.Companies.Add(new Company { CompanyID = 12756, ShortName = "ПЕТРАКОМ", INN = "6163091301" });
            context.Companies.Add(new Company { CompanyID = 12749, ShortName = "ИЗМА", INN = "7731348283" });
            context.Companies.Add(new Company { CompanyID = 12744, ShortName = "ЭЛ-ЮНИОН", INN = "7725294907" });
            context.Companies.Add(new Company { CompanyID = 12743, ShortName = "МАНГОДЖЕРРИ", INN = "5403195217" });
            context.Companies.Add(new Company { CompanyID = 12741, ShortName = "ТЕХНОЛЮКС", INN = "7703438961" });
            context.Companies.Add(new Company { CompanyID = 12740, ShortName = "ОА РОСБЕЗОПАСНОСТЬ", INN = "2801102382" });
            context.Companies.Add(new Company { CompanyID = 12736, ShortName = "ИНТЕРРЕСУРС", INN = "7839504717" });
            context.SaveChanges();

            context.Bills.Add(new Bill {CompanyId = 12764, Date = new DateTime(2018, 12, 11), Number = "1", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12764, Date = new DateTime(2018, 12, 12), Number = "2", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12762, Date = new DateTime(2018, 12, 13), Number = "3", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12744, Date = new DateTime(2018, 12, 14), Number = "4", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12743, Date = new DateTime(2018, 12, 15), Number = "5", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12743, Date = new DateTime(2018, 12, 16), Number = "6", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12740, Date = new DateTime(2018, 12, 17), Number = "7", Amount = 100000 });
            context.Bills.Add(new Bill {CompanyId = 12736, Date = new DateTime(2018, 12, 18), Number = "8", Amount = 100000 });
            context.SaveChanges();

            context.Agreements.Add(new Agreement { Number = "1", CompanyId = 12764, Date = new DateTime(2018, 01, 01), Billing = "BF" });
            context.Agreements.Add(new Agreement { Number = "2", CompanyId = 12762, Date = new DateTime(2018, 06, 01), Billing = "AF 10 true" });
            context.Agreements.Add(new Agreement { Number = "3", CompanyId = 12744, Date = new DateTime(2018, 01, 01), Billing = "AI 25 5 20 25 6 24 5 10" });
            context.Agreements.Add(new Agreement { Number = "4", CompanyId = 12743, Date = new DateTime(2018, 01, 01), Billing = "AF 5 false" });
            context.Agreements.Add(new Agreement { Number = "5", CompanyId = 12740, Date = new DateTime(2018, 01, 01), Billing = "BF" });
            context.Agreements.Add(new Agreement { Number = "5", CompanyId = 12736, Date = new DateTime(2018, 01, 01), Billing = "AF 10 true" });
            context.SaveChanges();
        }

    }
}