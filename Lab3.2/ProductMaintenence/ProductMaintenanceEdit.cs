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

        //
        private string formAction;

        //
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
        ){
            //
            InitializeComponent();

            //
            this.formAction = formAction;
            this.productCode = productCode;
            this.productName = productName;
            this.productVersion = productVersion;
            this.productDate = productDate;
        }

        //
        private void PopulateForm()
        {
            //
            textBoxProductCode.Text = productCode;
            textBoxProductName.Text = productName;
            textBoxProductVersion.Text = productVersion;
            datePickerProductDate.Value = DateTime.Parse(productDate); // Parse DateTime from type string

            //
            switch (formAction)
            {

                //
                case "add":
                    //
                    this.Text = "Add Product";

                    break;

                //
                case "edit":
                    //
                    this.Text = "Modify Product";

                    //
                    this.ActiveControl = textBoxProductName;

                    //
                    textBoxProductCode.ReadOnly = true;

                    break;

                //
                case "show":

                    //
                    this.Text = "Show Product";

                    //
                    this.ActiveControl = buttonCancelForm;

                    //
                    textBoxProductCode.ReadOnly = true;
                    textBoxProductName.ReadOnly = true;
                    textBoxProductVersion.ReadOnly = true;
                    datePickerProductDate.Enabled = false;
                    buttonSubmitForm.Enabled = false;

                    break;
            }
        }

        //
        private void CloseDialog()
        {
            //
            ProductMaintenance productMaintenence = new ProductMaintenance();

            //
            productMaintenence.Show();

            //
            this.Close();
        }

        //
        private void buttonCancelForm_Click(object sender, EventArgs e)
        {
            //
            if (formAction != "show")
            {
                //
                DialogResult confirm = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo);

                //
                if (confirm == DialogResult.Yes)
                {
                    //
                    CloseDialog();
                }
            } 
            //
            else
            {
                //
                CloseDialog();
            }
        }

        private void ProductMaintenenceEdit_Load(object sender, EventArgs e)
        {
            //
            PopulateForm();
        }

        //
        private void buttonSubmitForm_Click(object sender, EventArgs e)
        {
            //
            DialogResult confirm = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

            //
            if (confirm == DialogResult.Yes)
            {
                //
                switch (formAction)
                {
                    case "add":
                        //
                        break;

                    case "edit":
                        //
                        break;
                }
            }

            //
            CloseDialog();
        }
    }
}
