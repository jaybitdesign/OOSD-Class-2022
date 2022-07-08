using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * HILMI HISHMEH + James B
 * LAB 2
 * Form
 * July 2022
 */
namespace ElectricityBill

{
    public partial class Form1 : Form
    {
        CustomerData.CustomerList currentCustomers = new CustomerData.CustomerList();

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCustomersProcessed_Click(object sender, EventArgs e)
        {

        }

         
        // Exit form
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();            

        }

        // Checks if all mandatory fields are filled properly
        private Boolean isValidForm() {
            Boolean firstName = ElectricityBill.Validator.IsPresent(txtFirstName);
            Boolean lastName = ElectricityBill.Validator.IsPresent(txtLastName);
            Boolean KWHUsed = ElectricityBill.Validator.IsNonNegativeInt(txtKWHUsed);
            if(firstName && lastName && KWHUsed)
            {
                return true;
            }
            return false;
        }
        private void btnSubmit_Click(object sender, EventArgs e) //Submit Button
        {
            // only start if all mandatory fields are filled
            if (isValidForm())
            {
                // create a unique account number from the input field.
                // If not provided or already exists, generate a random ID
                int accountNumber = currentCustomers.GetNewAccountNumber(txtAccountNumber.Text);
                // create customer object
                CustomerData.Customer customer = new CustomerData.Customer(
                     accountNumber,
                     txtFirstName.Text,
                     txtLastName.Text,
                     Convert.ToDecimal(txtKWHUsed.Text)
                     );
                // Add to list
                currentCustomers.AddCustomer(customer);
                // reset
                CustomerListBox.Items.Clear();
                // add all customers
                for (int i = 0; i < currentCustomers.GetCustomerList().Count; i++)
                {
                    CustomerData.Customer currentCustomer = currentCustomers.GetCustomerList()[i];
                    CustomerListBox.Items.Add(currentCustomer.ToString());
                }
                // fill form fields
                txtBillAmount.Text = customer.CalculateCharge().ToString();
                txtAverageBillAmount.Text = currentCustomers.GetAverageBill().ToString();
                txtTotalKWHUsed.Text = currentCustomers.GetTotalNumberOfKWH().ToString();
                txtCustomersProcessed.Text = currentCustomers.GetCustomerList().Count.ToString();
            }
            
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        // validate KWH field
        private void txtKWHUsed_TextChanged(object sender, EventArgs e)
        {
            ElectricityBill.Validator.IsNonNegativeInt(txtKWHUsed);
        }

        // Validate account number
        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            ElectricityBill.Validator.IsNonNegativeInt(txtAccountNumber);
        }

        // show client information once selected
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCustomer = CustomerListBox.SelectedItem.ToString();
            int accountNumber = 0;
            try
            {
                // get account number from the ToString
                accountNumber = Int32.Parse(selectedCustomer.Split(' ')[1]);
            }
            catch (FormatException) 
            { 
                // show error including the account number
                Console.WriteLine("Account has invalid number: " + selectedCustomer.Split(' ')[1]); 
            }

            // get customer and show information
            CustomerData.Customer customer = currentCustomers.GetCustomerById(accountNumber);

            txtFirstName.Text = customer.firstName;
            txtLastName.Text = customer.lastName;
            txtKWHUsed.Text = customer.numberOfKWH.ToString();
            txtAccountNumber.Text = accountNumber.ToString();
            txtBillAmount.Text = customer.CalculateCharge().ToString();
        }

        
        //Reset all form fields
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtAccountNumber.ResetText();
            txtKWHUsed.ResetText();
        }
    }
}
