using System;
using System.Linq;

namespace Billing.DL
{
    public class BillAfterFixed : IBillingType
    {
        private string Id = BillingFactory.BillingTypeEnum.AF.ToString();
        private int DaysForPayment;
        private bool OnlyWorkDays;

        public BillAfterFixed(int daysForPayment, bool onlyWorkDays)
        {
            DaysForPayment = daysForPayment;
            OnlyWorkDays = onlyWorkDays;
        }

        public BillAfterFixed(string constructor)
        {
            if (!constructor.StartsWith(Id))
                throw new ArgumentException();
            try
            {
                var c = constructor.Trim().Split();
                DaysForPayment = int.Parse(c[1]);
                OnlyWorkDays = bool.Parse(c[2]);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public override string ToString()
        {
            return GetConstructor();
        }

        public DateTime GetFirstDate(Bill bill)
        {
            return bill.Date;
        }

        public DateTime GetLastDate(Bill bill)
        {
            if (!OnlyWorkDays)
                return bill.Date.AddDays(DaysForPayment);
            var currentDate = GetFirstDate(bill);
            for (int i = 0; i < DaysForPayment; i++)
                currentDate = NextWorkDay(currentDate);
            return currentDate;
        }

        private DateTime NextWorkDay(DateTime date)
        {
            var result = date.AddDays(1);
            while (IsWeekend(result))
            {
                result = result.AddDays(1);
            }
            return result;
        }
        private bool IsWeekend(DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday) ||
                (date.DayOfWeek == DayOfWeek.Sunday) ||
                (IsHolyday(date));
        }

        private bool IsHolyday(DateTime date)
        {
            DateTime[] holidays = new DateTime[] {
                                            new DateTime(2018,03,08),
                                            new DateTime(2018,01,01),
                                            new DateTime(2018,01,03),
                                            new DateTime(2018,02,23),
                                            new DateTime(2018,05,09)
                            };
            return holidays.Contains(date.Date);
        }

        public string GetConstructor()
        {
            return string.Join(" ", new[] { Id, DaysForPayment.ToString(), OnlyWorkDays.ToString() });
        }
    }
}
