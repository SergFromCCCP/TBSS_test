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
        private UnitOfWork uof;

        public formAgreement()
        {
            InitializeComponent();
            uof = new UnitOfWork(new AgreementContext()); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new BillingEditor("BF");
            f.ShowDialog();
        }

        private void formAgreement_Load(object sender, EventArgs e)
        {
            UpdateCompanies();
        }

        private void UpdateCompanies()
        {
            try
            {
                listCompanies.DataSource = uof.Companies.GetAll();
                listCompanies.DisplayMember = "ShortName";
                listCompanies.ValueMember = "CompanyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateView()
        {
            //string selectedCompanyName = listCompanies.SelectedItem.ToString();
            //listAgreements.DataSource = uof.Agreements.GetAgreementsByCompanyName(selectedCompanyName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var company = (Company)listCompanies.SelectedItem;
            var f = new AgreementEditor(new Agreement { Date = DateTime.Now, CompanyId = company.CompanyID, Number = "", Billing = "BF" });
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK)
                return;

            uof.Agreements.Add(f.Agreement);
            uof.Complete();
            UpdateAgreements(company);
            //Agreements.Add(f.Agreement);

            //UpdateView(Agreements);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var company = (Company)listCompanies.SelectedItem;
            var agr = (Agreement)listAgreements.SelectedItem;
            if (agr == null) return;

            var f = new AgreementEditor(agr);
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK)
                return;

            uof.Agreements.Modify(agr);
            uof.Complete();
            UpdateAgreements(company);

        }

        private void UpdateAgreements(Company company)
        {
            var agr = uof.Agreements.Find(d => d.CompanyId == company.CompanyID).OrderBy(z=>z.Date).ToList();
            listAgreements.DataSource = agr;
        }

        private void UpdateBills(Company company)
        {
            var b = uof.Bills.Find(d => d.CompanyId == company.CompanyID).ToList();
            listBills.DataSource = b;
        }
        private void listCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            var company = (Company)listCompanies.SelectedItem;
            if (company == null) return;

            UpdateAgreements(company);
            UpdateBills(company);
        }

        private void listAgreements_SelectedIndexChanged(object sender, EventArgs e)
        {
            var agr = (Agreement)listAgreements.SelectedItem;
            if (agr == null) return;

            lblBilling.Text = agr.Billing;
        }

        private void listBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            var company = (Company)listCompanies.SelectedItem;

            if (listAgreements.SelectedItem == null) return;
            var lastAgreement = uof.Agreements.Find(z => z.CompanyId == company.CompanyID).OrderBy(z => z.Date).Last();
            var currentBilling = BillingFactory.GetBillingType(lastAgreement.Billing);

            var bill = ((Bill)listBills.SelectedItem);
            result.Text = "Оплата с " + currentBilling.GetFirstDate(bill).ToShortDateString() +
                " по " + currentBilling.GetLastDate(bill).ToShortDateString();
        }

    }
}
