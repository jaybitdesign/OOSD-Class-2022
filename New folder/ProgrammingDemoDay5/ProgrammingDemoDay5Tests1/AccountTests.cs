using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingDemoDay5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDemoDay5.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositSuccessTest()
        {

            AccountTests account = new Account(500);
            decimal amount = 50;
            decimal expectedBalance = 550;
            decimal actualBalance;

            bool expectedResult = true;
            bool actualResult;

            actualResult = account.Deposit(amount);
            actualBalance = account.Balance;
            Assert.Fail();
        }
    }
}