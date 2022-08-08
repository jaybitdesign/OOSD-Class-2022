using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupportData;
using TechSupportData.DatabaseModels;

/**
 *  ProductMaintenance database application & unit tests
 *  Written & Designed by: James Buchanan / Jaybit Design
 *  Created: July 8th, 2022
 */
namespace ProductMaintenence
{
    /// <summary>
    /// A ProductMaintenanceEdit form that contains all logic required to view, add, edit, and delete products.
    /// </summary>
    public partial class ProductMaintenanceEdit : Form
    {
        // Initialize form action and product details
        private string formAction;
        private string productCode;
        private string productName;
        private string productVersion;
        private string productDate;

        // Define the ProductMaintenanceEdit constructor
        public ProductMaintenanceEdit(
            string formAction,
            string productCode,
            string productName,
            string productVersion,
            string productDate
        )
        {
            InitializeComponent();

            // Set the form action and product details
            this.formAction = formAction;
            this.productCode = productCode;
            this.productName = productName;
            this.productVersion = productVersion;
            this.productDate = productDate;
        }

        /// <summary>
        /// Populate the form with values from the constructor
        /// </summary>
        private void PopulateForm()
        {

            // Sets the textBox values to the values from the form constructor
            textBoxProductCode.Text = productCode;
            textBoxProductName.Text = productName;
            textBoxProductVersion.Text = productVersion;
            textBoxProductDate.Text = productDate;

            // Write the form action to console
            Validation.WriteColor("Opened form: [" + formAction.ToUpper() + "]\n", ConsoleColor.Green);

            // Determine form action
            switch (formAction)
            {

                // Form action "add"
                case "add":

                    // Sets the form text to "add product"
                    this.Text = "Add Product";

                    break;

                // Form action "edit"
                case "edit":

                    // Sets the form text to "modify product"
                    this.Text = "Modify Product";

                    // Set the active control to product name
                    this.ActiveControl = textBoxProductName;

                    // Set the product code to read only
                    textBoxProductCode.ReadOnly = true;

                    break;

                // Form action "show"
                case "show":

                    // Set the form text to "show product"
                    this.Text = "Show Product";

                    // Sets the active control to the cancel button
                    this.ActiveControl = buttonCancelForm;

                    // Set all text bnoxes to read only
                    textBoxProductCode.ReadOnly = true;
                    textBoxProductName.ReadOnly = true;
                    textBoxProductVersion.ReadOnly = true;
                    textBoxProductDate.ReadOnly = true;

                    // Set the submit button to disabled
                    buttonSubmitForm.Enabled = false;

                    break;
            }
        }

        /// <summary>
        /// Close the form dialog
        /// </summary>
        private void CloseDialog()
        {
            // Create a new main form object
            ProductMaintenance productMaintenence = new ProductMaintenance();

            // Show the main form
            productMaintenence.Show();

            // Close the form
            this.Close();
        }

        /// <summary>
        /// Logic for cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelForm_Click(object sender, EventArgs e)
        {
            // Only confim if its not the "show" form function
            if (formAction != "show")
            {
                // Confirm if the user wants to cancel
                DialogResult confirm = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo);

                // If they want to cancel
                if (confirm == DialogResult.Yes)
                {
                    // Close dialog
                    CloseDialog();
                }
            }
            // If it's "show", just close without asking
            else
            {
                // Close the dialog
                CloseDialog();
            }
        }

        /// <summary>
        /// Logic for edit form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductMaintenenceEdit_Load(object sender, EventArgs e)
        {
            // Populate the form with values passed in.
            PopulateForm();
        }

        /// <summary>
        /// Logic for submit form button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmitForm_Click(object sender, EventArgs e)
        {

            // Create a new generic product object
            Product newProduct = new Product();

            // Get a list of all textBoxes to be validated
            List<TextBox> textBoxList = new();
            textBoxList.Add(textBoxProductCode);
            textBoxList.Add(textBoxProductName);
            textBoxList.Add(textBoxProductVersion);

            // Determine the form function
            switch (formAction)
            {
                //If the form action is "add"
                case "add":

                    // Validate textBoxList
                    if (Validation.ContainsLegalCharacters(textBoxList, "|!@#$%^&*()-=_+[],<>:?`~")) 
                    {
                        // Validate textBoxProductCode
                        if (Validation.IsLengthWithinBounds(textBoxProductCode, 1, 10))
                        {
                            // Validate textBoxProductName
                            if (Validation.IsLengthWithinBounds(textBoxProductName, 1, 50))
                            {
                                // Validate textBoxProductVersion
                                if (Validation.IsValidDecimal(textBoxProductVersion))
                                {
                                    // Validate textBoxProductDate
                                    if (Validation.IsValidDateTime(textBoxProductDate))
                                    {
                                        // Confirm if they want to save the changes
                                        DialogResult confirm = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

                                        // If they want to save changes
                                        if (confirm == DialogResult.Yes)
                                        {
                                            // Set the new products details from the text box values
                                            newProduct.ProductCode = textBoxProductCode.Text;
                                            newProduct.Name = textBoxProductName.Text;
                                            newProduct.Version = Convert.ToDecimal(textBoxProductVersion.Text);
                                            newProduct.ReleaseDate = Convert.ToDateTime(textBoxProductDate.Text);

                                            // Open a connection to the database
                                            using (TechSupportContext database = new TechSupportContext())
                                            {
                                                // Add the new product to the database
                                                database.Products.Add(newProduct);
                                                // Save changes
                                                database.SaveChanges();
                                            }

                                            // Close the dialog
                                            CloseDialog();
                                        }
                                    }
                                    // Invalid Date
                                    else
                                    {
                                        MessageBox.Show(
                                        "Invalid Date Time format provided!",
                                        "Invalid Date Time",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                    }
                                }
                                // Invalid Version
                                else
                                {
                                    MessageBox.Show(
                                        "Invalid Version format provided!",
                                        "Invalid Version",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                }
                            }
                            // Invalid Name
                            else
                            {
                                MessageBox.Show(
                                        "Invalid Name length provided!",
                                        "Invalid Name",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                            }
                        }
                        // Invalid Code
                        else
                        {
                            MessageBox.Show(
                                        "Invalid Code length provided!",
                                        "Invalid Code",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                        }
                    } 
                    // Invalid Characters
                    else
                    {
                            MessageBox.Show(
                                        "Invalid characters provided!",
                                        "Invalid Code",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                    }

                    break;

                // If the form action is "edit"
                case "edit":

                    // Validate textBoxList
                    if (Validation.ContainsLegalCharacters(textBoxList, "!@#$%^&*()-=_+[],<>:?`~"))
                    {
                        // Validate textBoxProductCode
                        if (Validation.IsLengthWithinBounds(textBoxProductCode, 1, 10))
                        {
                            // Validate textBoxProductName
                            if (Validation.IsLengthWithinBounds(textBoxProductName, 1, 50))
                            {
                                // Validate textBoxProductVersion
                                if (Validation.IsValidDecimal(textBoxProductVersion))
                                {
                                    // Validate textBoxProductDate
                                    if (Validation.IsValidDateTime(textBoxProductDate))
                                    {
                                        // Ask if they are sure about making changes
                                        DialogResult confirm = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

                                        // If they confirm the changes
                                        if (confirm == DialogResult.Yes)
                                        {

                                            // Get the products details from the form constructor
                                            newProduct.ProductCode = productCode;
                                            newProduct.Name = productName;
                                            newProduct.Version = Convert.ToDecimal(productVersion);
                                            newProduct.ReleaseDate = Convert.ToDateTime(productDate);

                                            // Create a new product object
                                            Product updatedProduct = new Product();

                                            // Set the objects properties to be the values from text boxes
                                            updatedProduct.ProductCode = productCode;
                                            updatedProduct.Name = textBoxProductName.Text;
                                            updatedProduct.Version = Convert.ToDecimal(textBoxProductVersion.Text);
                                            updatedProduct.ReleaseDate = Convert.ToDateTime(textBoxProductDate.Text);

                                            // Open a connection to the database
                                            using (TechSupportContext database = new TechSupportContext())
                                            {
                                                //Remove the product from the database
                                                database.Products.Remove(newProduct);
                                                // Add the updated product to the database
                                                database.Products.Add(updatedProduct);
                                                // Save the changes
                                                database.SaveChanges();
                                            }

                                            // Close the dialog
                                            CloseDialog();
                                        }
                                    }
                                    // Invalid Date
                                    else
                                    {
                                        MessageBox.Show(
                                        "Invalid Date Time format provided!",
                                        "Invalid Date Time",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                    }
                                }
                                // Invalid Version
                                else
                                {
                                    MessageBox.Show(
                                        "Invalid Version format provided!",
                                        "Invalid Version",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                }
                            }
                            // Invalid Name
                            else
                            {
                                MessageBox.Show(
                                        "Invalid Name length provided!",
                                        "Invalid Name",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                            }
                        }
                        // Invalid Code
                        else
                        {
                            MessageBox.Show(
                                        "Invalid Code length provided!",
                                        "Invalid Code",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                        }
                    }
                    // Invalid Characters
                    else
                    {
                        MessageBox.Show(
                                    "Invalid characters provided!",
                                    "Invalid Code",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                    }
                break;
            }
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}