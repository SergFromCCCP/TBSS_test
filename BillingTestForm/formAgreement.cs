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
    public partial class formAgreement : Form
    {
        private UnitOfWork uof = new UnitOfWork(new AgreementContext());

        public formAgreement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void formAgreement_Load(object sender, EventArgs e)
        {
            listCompanies.DataSource = uof.Companies.GetAll();
            listCompanies.DisplayMember = "ShortName";
            listCompanies.ValueMember = "CompanyID";
        }

        public void UpdateView()
        {
            string selectedCompanyName = listCompanies.SelectedItem.ToString();
            listAgreements.DataSource = uof.Agreements.GetAgreementsByCompanyName(selectedCompanyName);
        }

        public int SelectedId
        {
            get
            {
                if (listAgreements.SelectedItems.Count == 0) return -1;
                return ((Agreement)listAgreements.SelectedItem).Id;
            }
            set
            {
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Agreements.Add(f.Agreement);
            //UpdateView(Agreements);
        }
    }
}
