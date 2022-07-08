using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day6Excercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Excercise.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void AccountNoConstructorTest()
        {
            //arrange
            Account account;
            decimal expectedBalance = 0;
            decimal actualBalance;

            //act
            account = new Account();
            actualBalance = account.Balance;
  
            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void AccountPositiveConstructorTest()
        {
            //arrange
            Account account;
            decimal initialBalance = 100;
            decimal expectedBalance = 100;
            decimal actualBalance;

            //act
            account = new Account(initialBalance);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void AccountNegativeConstructorTest()
        {
            //arrange
            Account account;
            decimal initialBalance = -100;
            decimal expectedBalance = 0;
            decimal actualBalance;

            //act
            account = new Account(initialBalance);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void DepositTest()
        {
            //arrange
            Account account = new Account(500);
            decimal amount = 50;
            decimal expectedBalance = 550;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            //act
            actualResult = account.Deposit(amount);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void DepositNegativeTest()
        {
            //arrange
            Account account = new Account(500);
            decimal amount = -50;
            decimal expectedBalance = 500;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            //act
            actualResult = account.Deposit(amount);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void WithdrawlTest()
        {
            //arrange
            Account account = new Account(500);
            decimal amount = 50;
            decimal expectedBalance = 450;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            //act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawlNegativeTest()
        {
            //arrange
            Account account = new Account(500);
            decimal amount = -50;
            decimal expectedBalance = 500;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            //act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawlNSFTest()
        {
            //arrange
            Account account = new Account(500);
            decimal amount = 600;
            decimal expectedBalance = 500;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            //act
            actualResult = account.Withdraw(amount);
            actualBalance = account.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}