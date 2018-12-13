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
    public partial class BillingEditor : Form
    {
        private List<Billing.DL.Dates> dates = new List<Billing.DL.Dates>();
        private Billing.DL.IBillingType billing;
        public BillingEditor(string billingConstructor = "BF")
        {
            InitializeComponent();
            billing = Billing.DL.BillingFactory.GetBillingType(billingConstructor);
        }

        public string GetBilling()
        {
            if (rbAfterFixed.Checked)
                return "AF " + numFixedDays.Value.ToString() + " " + checkOnlyWorkDays.Checked.ToString();
            if (rbAfterInterval.Checked)
            {
                return "AI " + string.Join(" ", dates);
            }
            return "BF";
        }

        private void BillingEditor_Load(object sender, EventArgs e)
        {
            if (billing is Billing.DL.BillBefore)
                rbBefore.Checked = true;
            if (billing is Billing.DL.BillAfterFixed)
            {
                rbAfterFixed.Checked = true;
                var c = billing.GetConstructor().Split();
                numFixedDays.Value = int.Parse(c[1]);
                checkOnlyWorkDays.Checked = bool.Parse(c[2]);
            }
            if (billing is Billing.DL.BillAfterInterval)
            {
                rbAfterInterval.Checked = true;
                var d = billing.GetConstructor().Split().Skip(1);
                int c = d.Count() / 4;
                for (int i = 0; i < c; i++)
                {
                    var v =string.Join(" ", d.Skip(i * 4).Take(4).ToArray());
                    dates.Add(new Billing.DL.Dates(v));
                }
                RefreshList();
            }
        }

        private void RefreshList()
        {
            listInterval.Items.Clear();
            foreach (var v in dates)
            {
                listInterval.Items.Add(v.GetDescription());
            }
        }
        private void btnAddInterval_Click(object sender, EventArgs e)
        {
            var f = new BillingAfterIntervalEditor(new Billing.DL.Dates(1));
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK)
                return;
            dates.Add(f.Dates);
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listInterval.SelectedItems.Count == 0) return;
            var index = listInterval.SelectedIndex;
            var f = new BillingAfterIntervalEditor(dates[index]);
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK)
                return;

            dates[index] = f.Dates;
            RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listInterval.SelectedItems.Count == 0) return;
            var index = listInterval.SelectedIndex;
            dates.RemoveAt(index);
            RefreshList();
        }

        private void rbBefore_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            gbAfterInterval.Location = gbAfterFixed.Location;

            bool isBefore = rbBefore.Checked;
            bool isAfterFixed = rbAfterFixed.Checked;
            bool isAfterInterval = rbAfterInterval.Checked;

            gbAfterFixed.Visible = isAfterFixed;
            gbAfterInterval.Visible = isAfterInterval;
        }
    }
}
