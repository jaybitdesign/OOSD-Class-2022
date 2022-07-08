using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HILMI HISHMEH + JAMES B
//LAB 2 - JULY 2022
//CUSTOMER LIST - TOTAL KWH, LIST CUSTOMERS
namespace CustomerData
{
    public class CustomerList
    {
        public List<Customer> listOfCustomers = new List<Customer>(); // list of customers
        // Constructor
        public CustomerList()
        {
        }

        //Create
        public void AddCustomer(Customer customer)
        {
            listOfCustomers.Add(customer);
        }
        //Read
        public Customer GetCustomerById(int customerId)
        {
            return listOfCustomers.Find(Customer => Customer.accountNo == customerId);
        }

        // Get full list of cutsomers
        public List<Customer> GetCustomerList()
        {
            return listOfCustomers;
        }

        // total number of customers
        public int GetTotalNumberOfCustomers()
        {
            return listOfCustomers.Count;
        }

        // total number of KWH used
        public decimal GetTotalNumberOfKWH()
        {
            decimal totalKWH = 0;
            for (int i = 0; i < GetCustomerList().Count; i++)
            {
                totalKWH += GetCustomerList()[i].numberOfKWH;
            }
            return totalKWH;
        }

        // total bill amounts
        public decimal GetTotalBillAmounts()
        {
            decimal totalBillAmounts = 0;
            for (int i = 0; i < GetCustomerList().Count; i++)
            {
                totalBillAmounts += GetCustomerList()[i].CalculateCharge();
            }
            return totalBillAmounts;
        }

        // get average KWH
        public decimal GetAverageKWH()
        {
            return GetTotalNumberOfKWH() / GetTotalNumberOfCustomers();
        }

        // get average bill
        public decimal GetAverageBill()
        {
            return GetTotalBillAmounts() / GetTotalNumberOfCustomers();
        }

        // does the account number exist?
        public Boolean AccountNumberExists(int acccountNumber)
        {
            Boolean exists = false;
            for (int i = 0; i < GetCustomerList().Count; i++)
            {
                if (GetCustomerList()[i].accountNo == acccountNumber)
                {
                    exists = true;
                }
            }
            return exists;
        }

        // get unique account number
        public int GetNewAccountNumber(String accountNumber) {
            int newAccountNumber = 0;
            try
            {
                newAccountNumber = Convert.ToInt32(accountNumber);
                if (newAccountNumber == 0 || AccountNumberExists(newAccountNumber))
                {
                    newAccountNumber = GetSystemAccountNumber();
                }                
            }
            catch (FormatException e)
            {
                newAccountNumber = GetSystemAccountNumber();
            }          
            return newAccountNumber;
        }

        // generates a random account number and checks if it already exists
        // if exists, it tries again until it finds a unique one
        public int GetSystemAccountNumber()
        {
            Random rnd = new Random();
            int accountNumber = rnd.Next(100000, 9999999);
            if (AccountNumberExists(accountNumber))
            {
                accountNumber = GetSystemAccountNumber();
            }
            return accountNumber;
        }
    }
}
