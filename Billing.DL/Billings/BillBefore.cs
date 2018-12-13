using System;

namespace Billing.DL
{
    public class BillBefore : IBillingType
    {
        public BillBefore()
        {
        }

        public string GetConstructor()
        {
            return "";
        }

        public DateTime GetFirstDate(Bill bill)
        {
            return bill.Date;
        }

        public DateTime GetLastDate(Bill bill)
        {
            return bill.Date;
        }

        public override string ToString()
        {
            return GetConstructor();
        }
    }
}
