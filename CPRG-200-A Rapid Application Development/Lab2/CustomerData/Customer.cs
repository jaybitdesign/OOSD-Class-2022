using System;

namespace CustomerData
/**
 * HILMI HISHMEH + James Buchanan
 * constuctor + calculations
 * LAB 2
 * July 2022
 */
{
    public class Customer
    {
        //global constants
        public const decimal ADMINCHARGE = 12m; // admin charge
        public const decimal KWHCHARGE = 0.07m; // charge per kWH

        //Customer Info
        public int accountNo { get; set; } //account number
        public string firstName { get; set; }// first name
        public string lastName { get; set; }//last name
        public decimal numberOfKWH { get; set; } //kwh used

        // constructor
        public Customer(int accountNo, string firstName, string lastName,
                         decimal numberOfKWH)
        {
            this.accountNo = accountNo;
            this.firstName = firstName;
            this.lastName = lastName;
            this.numberOfKWH = numberOfKWH;
        }

        //calculate charges 
        public decimal CalculateCharge()
        {
            return (numberOfKWH * KWHCHARGE) + ADMINCHARGE;

        }

        public override string ToString() 
        {
            return "Account " + accountNo + 
                " Name: " + firstName + " " + lastName + 
                " KWH " + numberOfKWH + 
                " Charge $" + CalculateCharge();
        }
    }
}
