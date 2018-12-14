using System;

namespace Billing.DL
{
    public interface IBillingType
    {
        DateTime GetFirstDate(DateTime billDate);
        DateTime GetLastDate(DateTime billDate);
        string GetConstructor();
    }
}
