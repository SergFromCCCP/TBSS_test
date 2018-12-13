using System;

namespace Billing.DL
{
    public interface IBillingType
    {
        DateTime GetFirstDate(Bill bill);
        DateTime GetLastDate(Bill bill);
        string GetConstructor();
    }
}
