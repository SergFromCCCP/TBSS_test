using System;

namespace Billing.DL
{
    public class BillBefore : IBilllingType
    {
        public BillBefore()
        {
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
            return "BillBefore";
        }
    }
}
