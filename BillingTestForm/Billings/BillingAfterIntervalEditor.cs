using Billing.DL;
using System;
using System.Windows.Forms;

namespace BillingTestForm
{
    public partial class BillingAfterIntervalEditor : Form
    {
        public Dates Dates { get; private set; }
        public BillingAfterIntervalEditor(Dates dates)
        {
            InitializeComponent();

            inpBillFirst.Value = dates.BillFirst;
            inpBillLast.Value = dates.BillLast;
            inpPayFirst.Value = dates.PayFirst;
            inpPayLast.Value = dates.PayLast;
        }

        private void BillingAfterIntervalEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dates = new Dates
            {
                BillFirst = (int)inpBillFirst.Value,
                BillLast = (int)inpBillLast.Value,
                PayFirst = (int)inpPayFirst.Value,
                PayLast = (int)inpPayLast.Value
            };
        }
    }
}
