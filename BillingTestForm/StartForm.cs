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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnTestBillings_Click(object sender, EventArgs e)
        {
            var f = new formBillings();
            f.ShowDialog();
        }

        private void btnTestAgreement_Click(object sender, EventArgs e)
        {
            var f = new formAgreement();
            f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
