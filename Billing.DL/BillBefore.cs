using System;

namespace Billing.DL
{
    public class BillBefore : IBilllingType
    {
        public DateTime GetFirstDate(Bill bill)
        {
            return bill.Date;
        }

        public DateTime GetLastDate(Bill bill)
        {
            return bill.Date;
        }
    }
}
