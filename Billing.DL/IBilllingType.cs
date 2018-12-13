using System;

namespace Billing.DL
{
    public interface IBilllingType
    {
        DateTime GetFirstDate(Bill bill);
        DateTime GetLastDate(Bill bill);
    }
}
