using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateChargeTest()
        {
            // create customer
            Customer testCustomer = new Customer(1234, "testfirst", "testlast", 12);
            // create expected value
            decimal expectedCharge = 12.84m;
            decimal actualCharge = testCustomer.CalculateCharge();
            // check if expected equals actual
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void AverageBillTest()
        {
            // create customers
            Customer testCustomer1 = new Customer(1234, "hilmi1", "hishmeh1", 12);
            Customer testCustomer2 = new Customer(1235, "hilmi2", "hishmeh2", 24);
            Customer testCustomer3 = new Customer(1236, "hilmi3", "hilshmeh3", 36);
            // create customer list from customers
            CustomerList customerList = new CustomerList();
            customerList.AddCustomer(testCustomer1);
            customerList.AddCustomer(testCustomer2);
            customerList.AddCustomer(testCustomer3);
            // create expected value
            decimal expectedAverageBill = 13.68m;
            decimal actualAverageBill = customerList.GetAverageBill();
            // check if expected equal actual
            Assert.AreEqual(expectedAverageBill, actualAverageBill);

        }

        [TestMethod()]
        public void TotalKWHTest()
        {
            // create customers
            Customer testCustomer1 = new Customer(1234, "testfirst1", "testlast1", 12);
            Customer testCustomer2 = new Customer(1235, "testfirst2", "testlast2", 24);
            Customer testCustomer3 = new Customer(1236, "testfirst3", "testlast3", 36);
            // create customer list from customers
            CustomerList customerList = new CustomerList();
            customerList.AddCustomer(testCustomer1);
            customerList.AddCustomer(testCustomer2);
            customerList.AddCustomer(testCustomer3);
            // create expected value
            decimal expectedAverageBill = 72;
            decimal actualAverageBill = customerList.GetTotalNumberOfKWH();
            // check if expected equal actual
            Assert.AreEqual(expectedAverageBill, actualAverageBill);

        }
    }
}