using System;
using System.Collections.Generic;
using System.Linq;

namespace Billing.DL
{
    public class BillAfterInterval : IBillingType
    {

        private string Id = BillingFactory.BillingTypeEnum.AI.ToString();
        private List<Dates> dates;

        public BillAfterInterval(string constructor)
        {
            dates = new List<Dates>();
            if (!constructor.StartsWith(Id))
                throw new ArgumentException();
            var d = constructor.Split().Skip(1);
            if (d.Count() % 4 != 0)
                throw new ArgumentException("Число параметров д.б. кратно 4");
            int c = d.Count() / 4;
            for (int i = 0; i < c; i++)
            {
                var v = d.Skip(i * 4).Take(4).Select(z => int.Parse(z)).ToArray();
                dates.Add(new Dates { BillFirst = v[0], BillLast = v[1], PayFirst = v[2], PayLast = v[3] });
            }
        }

        public override string ToString()
        {
            return GetConstructor();
        }
        public DateTime GetFirstDate(DateTime billDate)
        {
            Dates d1 = GetDatesForBill(billDate);
            var result = GetFirstDatOfNextMonth(billDate);
            return new DateTime(result.Year, result.Month, d1.PayFirst);
        }

        public DateTime GetLastDate(DateTime billDate)
        {
            Dates d1 = GetDatesForBill(billDate);
            var result = GetFirstDatOfNextMonth(billDate);
            return new DateTime(result.Year, result.Month, d1.PayLast);
        }

        private static DateTime GetFirstDatOfNextMonth(DateTime date)
        {
            return date.AddDays(-date.Date.Day + 1).AddMonths(1);
        }

        private Dates GetDatesForBill(DateTime date)
        {
            return dates.Find(d => IsBetween(date.Day, d.BillFirst, d.BillLast));
        }

        private bool IsBetween(int value, int min, int max)
        {
            if (min < max)
                return (value >= min) && (value <= max);
            return (value >= min) || (value <= max);
        }

        public string GetConstructor()
        {
            return Id + " " + string.Join(" ", dates.Select(d => d.ToString()));
        }
    }
}