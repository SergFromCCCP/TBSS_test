namespace Billing.DL
{
    public struct Dates
    {
        public int BillFirst;
        public int BillLast;
        public int PayFirst;
        public int PayLast;

        public override string ToString()
        {
            return $"{BillFirst} {BillLast} {PayFirst} {PayLast}";
        }

        public Dates(int billFirst, int billLast, int payFirst, int payLast)
        {
            BillFirst = billFirst;
            BillLast = billLast;
            PayFirst = payFirst;
            PayLast = payLast;
        }

        public Dates(int InitValue = 1) : this(InitValue, InitValue, InitValue, InitValue)
        {
        }

        public Dates(string constructor)
        {
            var r = constructor.Split();
            if (r.Length != 4)
                throw new System.ArgumentException("должно делиться на 4");
            BillFirst = int.Parse(r[0]);
            BillLast = int.Parse(r[1]);
            PayFirst = int.Parse(r[2]);
            PayLast = int.Parse(r[3]);

        }

        public string GetDescription()
        {
            return $"При дате счета с {BillFirst} по {BillLast} оплата с {PayFirst} по {PayLast}";
        }
    }
}