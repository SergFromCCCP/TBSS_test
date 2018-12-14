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

        public DateTime GetFirstDate(DateTime billDate)
        {
            return billDate;
        }

        public DateTime GetLastDate(DateTime billDate)
        {
            return billDate;
        }

        public override string ToString()
        {
            return GetConstructor();
        }
    }
}
