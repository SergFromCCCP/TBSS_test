using Billing.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingTestForm
{
    public class AgreementPresenter
    {
        private IUnitOfWork uof;
        private formAgreement _view;

        public AgreementPresenter(formAgreement view, AgreementContext context)
        {
            _view = view;
            uof = new UnitOfWork(context);
            _view.UpdateView();
        }

        public void Add()
        {
            //var f = new AgreementEditor(
            //    new Agreement()
            //    {
            //        Billing = "",
            //        Date = DateTime.Now,
            //        Number = "0",
            //        Company = new Company { CompanyID = 1, INN = "111", ShortName = "aaa" }
            //    }
            //    );
            //f.ShowDialog();
            //if (f.DialogResult != DialogResult.OK) return;
            //uof.Agreements.Add(f.Agreement);
            //uof.Complete();
            //_view.UpdateView();
        }
    }
}
