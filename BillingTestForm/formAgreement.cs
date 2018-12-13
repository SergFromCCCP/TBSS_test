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
    public partial class formAgreement : Form
    {
        private Billing.DL.IBillingType currentBilling = Billing.DL.BillingFactory.GetBillingType("AF 5 false");

        public formAgreement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new BillingEditor(currentBilling.GetConstructor());
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK) return;
            currentBilling = Billing.DL.BillingFactory.GetBillingType(f.GetBilling());
            Text = currentBilling.ToString();
        }

        private void formAgreement_Load(object sender, EventArgs e)
        {

        }
    }
}
