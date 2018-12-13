using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public static class BillingFactory
    {
        public enum BillingTypeEnum
        {
            BF = 0,//billing before
            AF,//billing after fixed
            AI//billing after interval
        }

        public static IBillingType GetBillingType(string constructor = "BF")
        {
            constructor = constructor.Trim();
            if (constructor.StartsWith(BillingTypeEnum.BF.ToString()))
                return new BillBefore();
            if (constructor.StartsWith(BillingTypeEnum.AF.ToString()))
                return new BillAfterFixed(constructor);
            if (constructor.StartsWith(BillingTypeEnum.AI.ToString()))
                return new BillAfterInterval(constructor);
            throw new ArgumentException("Нераспознанный конструктор");
        }
    }
}
