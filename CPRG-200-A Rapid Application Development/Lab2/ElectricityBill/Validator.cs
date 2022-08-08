using System;
using System.Windows.Forms;

namespace ElectricityBill
{
    /// <summary>
    /// A repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if text box has input in it
        /// </summary>
        /// <param name="textBox"> text box to check (needs to have Tag set to meaningful name)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if(textBox.Text == "") // incorrect
            {
                MessageBox.Show(textBox.Tag + " must be provided");
                isValid = false;
                textBox.Focus(); // focus on the text box to assist user
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains int that is greater than or equal to zero
        /// </summary>
        /// <param name="textBox">text box to check (needs to have Tag set to meaningful name)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int value;
            if(!Int32.TryParse(textBox.Text, out value)) // cannot parse as int
            {
                MessageBox.Show(textBox.Tag + " must be  a whole number");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            else if(value < 0) // int, but negative
            {
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains int that is between minumum value and maximum value
        /// 
        /// </summary>
        /// <param name="textBox">text box to check (needs to have Tag set to meaningful name)</param>
        /// <param name="minVal">minumum value</param>
        /// <param name="maxVal">maximum value</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsIntInRange(TextBox textBox, int minVal, int maxVal)
        {
            bool isValid = true;
            double value;
            if (!Double.TryParse(textBox.Text, out value)) // cannot parse as double
            {
                MessageBox.Show(textBox.Tag + " must be a whole number");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < minVal || value > maxVal) // int, but outside of allowed range
            {
                MessageBox.Show($"{textBox.Tag} must be between {minVal} and {maxVal}");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains double that is greater than of equal to zero
        /// </summary>
        /// <param name="textBox">text box to check (needs to have Tag set to meaningful name)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            double value;
            if (!Double.TryParse(textBox.Text, out value)) // cannot parse as double
            {
                MessageBox.Show(textBox.Tag + " must be a number");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // int, but negative
            {
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains decimal that is greater than of equal to zero
        /// </summary>
        /// <param name="textBox">text box to check (needs to have Tag set to meaningful name)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal value;
            if (!Decimal.TryParse(textBox.Text, out value)) // cannot parse as decimal
            {
                MessageBox.Show(textBox.Tag + " must be a number");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // int, but negative
            {
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                isValid = false;
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

    }// class
}// namespace
