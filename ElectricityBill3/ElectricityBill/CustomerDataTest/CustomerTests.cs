using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            // create customer
            Customer testCustomer = new Customer(1234, "testfirst", "testlast", 12);

            decimal expectedCharge = 130;
            decimal actualCharge = testCustomer.CalculateCharge();
            Assert.AreEqual(expectedCharge, actualCharge);

        }

        [TestMethod()]
        public void AverageBillTest()
        {
            // create customer
            Customer testCustomer1 = new Customer(1234, "testfirst1", "testlast1", 12);
            Customer testCustomer2 = new Customer(1235, "testfirst2", "testlast2", 24);
            Customer testCustomer3 = new Customer(1236, "testfirst3", "testlast3", 36);

            CustomerList customerList = new CustomerList();
            customerList.AddCustomer(testCustomer1);
            customerList.AddCustomer(testCustomer2);
            customerList.AddCustomer(testCustomer3);

            decimal expectedAverageBill = 130;
            decimal actualAverageBill = customerList.GetAverageBill();
            Assert.AreEqual(expectedAverageBill, actualAverageBill);

        }
    }
}
