﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
    public class Bill
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public decimal Amount
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Счет {Number} от {Date.ToShortDateString()} на сумму {Amount}";
        }
    }
}
