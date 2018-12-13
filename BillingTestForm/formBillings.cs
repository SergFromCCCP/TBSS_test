using Billing.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingTestForm
{
    public partial class formBillings : Form
    {
        public formBillings()
        {
            InitializeComponent();
            result.Text = string.Join(" ", Enum.GetValues(typeof(BillingFactory.BillingTypeEnum)));
        }

        private void GO_Click(object sender, EventArgs e)
        {
            try
            {
                var b = new Bill() { Date=dtp.Value};
                var bb = BillingFactory.GetBillingType(constructor.Text);
                result.Text = bb.ToString() + 
                    "\nFirstDate: " + bb.GetFirstDate(b).ToShortDateString() + 
                    "\nLastDate: " + bb.GetLastDate(b).ToShortDateString();
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }
        }
    }
}
