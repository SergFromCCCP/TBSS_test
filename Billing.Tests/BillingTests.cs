using Billing.DL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Billing.Tests
{
    [TestClass]
    public class BillingTests
    {
        private Bill bill;
        private IBillingType billingType;

        [TestInitialize]
        public void TestInit()
        {
            bill = new Bill { Id = 1, Company = new Company(), Date = new DateTime(2018, 12, 10), Amount = 100, Number = 1.ToString() };
        }
        [TestMethod]
        public void TestBillBefore()
        {
            billingType = new BillBefore();
            Assert.AreEqual(bill.Date, billingType.GetFirstDate(bill));
            Assert.AreEqual(bill.Date, billingType.GetLastDate(bill));
        }

        [TestMethod]
        public void TestBillAfterFixedThisWeek()
        {
            bill = new Bill { Id = 1, Company = new Company(), Date = new DateTime(2018, 12, 10), Amount = 100, Number = 1.ToString() };
            billingType = new BillAfterFixed(1, false);
            Assert.AreEqual(new DateTime(2018, 12, 10), billingType.GetFirstDate(bill));
            Assert.AreEqual(new DateTime(2018, 12, 11), billingType.GetLastDate(bill));
            billingType = new BillAfterFixed(4, false);
            Assert.AreEqual(new DateTime(2018, 12, 14), billingType.GetLastDate(bill));
            billingType = new BillAfterFixed(4, true);
            Assert.AreEqual(new DateTime(2018, 12, 14), billingType.GetLastDate(bill));
        }
        [TestMethod]
        public void TestBillAfterFixedNextWeek()
        {
            bill = new Bill { Id = 1, Company = new Company(), Date = new DateTime(2018, 12, 10), Amount = 100, Number = 1.ToString() };
            billingType = new BillAfterFixed(5, false);
            Assert.AreEqual(new DateTime(2018, 12, 10), billingType.GetFirstDate(bill));
            Assert.AreEqual(new DateTime(2018, 12, 15), billingType.GetLastDate(bill));
            billingType = new BillAfterFixed(5, true);
            Assert.AreEqual(new DateTime(2018, 12, 10), billingType.GetFirstDate(bill));
            Assert.AreEqual(new DateTime(2018, 12, 17), billingType.GetLastDate(bill));
            billingType = new BillAfterFixed(9, true);
            Assert.AreEqual(new DateTime(2018, 12, 10), billingType.GetFirstDate(bill));
            Assert.AreEqual(new DateTime(2018, 12, 21), billingType.GetLastDate(bill));

        }
    }
}
