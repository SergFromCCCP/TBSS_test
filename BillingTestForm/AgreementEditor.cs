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
    public partial class AgreementEditor : Form
    {
        public Agreement Agreement { get; private set; }

        public AgreementEditor(Agreement agreement)
        {
            InitializeComponent();
            Agreement = agreement;

            WriteToForm();
        }

        private void AgreementEditor_Load(object sender, EventArgs e)
        {

        }

        private void WriteToForm()
        {
            Text = "Редактор договора с ";// + Agreement.Company.ShortName;
            dtpDate.Value = Agreement.Date;
            txtNumber.Text = Agreement.Number;
            txtBilling.Text = Agreement.Billing;
        }

        private void ReadFromForm()
        {
            Agreement.Date = dtpDate.Value;
            Agreement.Number = txtNumber.Text;
            Agreement.Billing = txtBilling.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadFromForm();
        }

        private void btnSetBilling_Click(object sender, EventArgs e)
        {
            var f = new BillingEditor(txtBilling.Text);
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK) return;
            txtBilling.Text = f.GetBilling();
        }
    }
}
