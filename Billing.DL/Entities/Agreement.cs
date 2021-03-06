﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DL
{
  public  class Agreement
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CompanyId { get; set; }
        public DateTime Date { get; set; }
        public string Billing { get; set; }
        public override string ToString()
        {
            return $"Договор {Number} от {Date.ToShortDateString()}";
        }
    }
}
