using TechSupportData.DatabaseModels;

/**
*  ProductMaintenance database application & unit tests
*  Written & Designed by: James Buchanan & Hilmi Abou-Hishmeh
*  Created: July 8th, 2022
*/
namespace ProductMaintenence
{   
    /// <summary>
    /// A ProductMaintenance form that displays the productsListBox with data from the database, as well as all neccesary controls.
    /// </summary>
    public partial class ProductMaintenance : Form
    {

        /// <summary>
        /// Define the ProductMaintenance constructor
        /// </summary>
        public ProductMaintenance()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refresh the productsListBox to have the most current data from the database models
        /// </summary>
        private void RefreshProductsListBox()
        {
            // Clear the list box
            productsListBox.Items.Clear();

            // Connect to the database
            using (TechSupportContext database = new TechSupportContext())
            {
                // Get a list of all product objects
                List<Product> productsData = (List<Product>)(
                    from product in database.Products
                        orderby product.Name
                        select product
                ).ToList();

                // White headers to console
                Validation.WriteColor(
                    "[CODE](10)".PadRight(10 + 2) +
                    "[NAME](50)".PadRight(50 + 2) +
                    "[VERSION](18)".PadRight(18 + 2) +
                    "[DATE TIME]",
                    ConsoleColor.Red
                );
                foreach (Product p in productsData)
                {
                    string[] str = p.ToString().Split("| ");
                    Validation.WriteColor("["+str[0]+"]" + str[1] + str[2] + str[3], ConsoleColor.Blue);
                }
                Console.WriteLine();

                // Loop through every product
                foreach (var product in productsData)
                {
                    // If the product is not null
                    if(product is not null)

                        // Add the product to list box
                        productsListBox.Items.Add(product.ToString());
                }

            }

            // Refresh the list box
            productsListBox.Refresh();

            // Set the labelTotalProductsNumber text to be the count of productListBox items
            labelTotalProductsNumber.Text = productsListBox.Items.Count.ToString();
        }

        /// <summary>
        /// Open a new ProductMaintenanceEdit form with values passed in to populate the text boxes  
        /// </summary>
        /// <param name="formAction"></param>
        /// <param name="productCode"></param>
        /// <param name="productName"></param>
        /// <param name="productVersion"></param>
        /// <param name="productDate"></param>
        private void ShowDialog(
            string formAction="add",
            string productCode="",
            string productName="",
            string productVersion="",
            string productDate= "2022-01-01"
        )
        {

            // Create a new ProductMaintenance form object with values passed in to populate the text boxes
            ProductMaintenanceEdit addProductForm = new(
                formAction, 
                productCode,
                productName, 
                productVersion, 
                productDate
            );

            // Hide the main ProductMaintenance form
            this.Hide();

            // Open a ProductMaintenanceEdit form as a dialog
            addProductForm.ShowDialog();
        }

        /// <summary>
        /// Open a new ProductMaintenanceEdit form using data from a selected productsListBox item
        /// </summary>
        /// <param name="formAction"></param>
        private void ParseBySelection(string formAction)
        {
            // If the selected item IS NOT NULL
            if (productsListBox.SelectedItem is not null)
            {
                // Define a productString that gets the value of the selected productsListBox item
                string productString = productsListBox.SelectedItem.ToString()!;

                // Create an array of properties, splitting them with "| "
                string[] productProperties = productString.Split("| ");

                // Open a new ProductMaintenanceEdit form using data from a productString
                ShowDialog(
                    formAction: formAction,
                    productCode: productProperties[0].Trim(),
                    productName: productProperties[1].Trim(), 
                    productVersion: productProperties[2].Trim(),
                    productDate: productProperties[3].Trim()
                );
            }

            // If the selected item IS NULL
            else
            {
                // Open a new dialog window to confirm that the user must select a productsListBox item
                MessageBox.Show(
                    "Please make a selection before trying to make changes",
                    "Invalid Selection",
                    MessageBoxButtons.OK
                );
            }
        }

        /// <summary>
        /// Open a new ProductMaintenanceEdit form using data from a productString
        /// </summary>
        /// <param name="formAction"></param>
        /// <param name="productString"></param>
        private void ParseByProductString(string formAction, string productString)
        {
            // If the selected item IS NOT NULL
            if (productsListBox.SelectedItem is not null)
            {
                // Create an array of properties, splitting them with "| "
                string[] productProperties = productString.Split("| ");

                // Open a new ProductMaintenanceEdit form using data from a productString
                ShowDialog(
                    formAction: formAction,
                    productCode: productProperties[0].Trim(),
                    productName: productProperties[1].Trim(),
                    productVersion: productProperties[2].Trim(),
                    productDate: productProperties[3].Trim()
                );
            }

            // If the selected item IS NULL
            else
            {
                // Open a new dialog window to confirm that the user must select a productsListBox item
                MessageBox.Show(
                    "Please make a selection before trying to make changes",
                    "Invalid Selection",
                    MessageBoxButtons.OK
                );
            }
        }

        /// <summary>
        /// Handle the buttonDeleteProduct click event and delete a user from the database, then refresh the productsListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            // If the selected item IS NOT NULL
            if (productsListBox.SelectedItem is not null)
            {
                //
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);

                //
                if (confirm == DialogResult.Yes)
                {
                    // Delete product from database

                    //
                    Product updatedProduct = new Product();

                    //
                    if (productsListBox.SelectedItem is not null)
                    {
                        // Define a productString that gets the value of the selected productsListBox item
                        string productString = productsListBox.SelectedItem.ToString()!;

                        // Write the product to console
                        Console.WriteLine(productString);

                        // Create an array of properties, splitting them with "| "
                        string[] productProperties = productString.Split("| ");

                        // Create new geneeric product object
                        Product deleteProduct = new Product();

                        // Set the objects values
                        deleteProduct.ProductCode = productProperties[0].Trim();
                        deleteProduct.Name = productProperties[1].Trim();
                        deleteProduct.Version = Convert.ToDecimal(productProperties[2].Trim());
                        deleteProduct.ReleaseDate = Convert.ToDateTime(productProperties[3].Trim());

                        // Connect to the database
                        using (TechSupportContext database = new TechSupportContext())
                        {
                            // Remove the product
                            database.Products.Remove(deleteProduct);
                            // Save changes
                            database.SaveChanges();
                        }
                    }

                    // Refresh products listbox
                    RefreshProductsListBox();
                }
            }

            // If the selected item IS NULL
            else
            {
                // Open a new dialog window to confirm that the user must select a productsListBox item
                MessageBox.Show(
                    "Please make a selection before trying to make changes",
                    "Invalid Selection",
                    MessageBoxButtons.OK
                );
            }
        }

        /// <summary>
        /// Handle the buttonEditProduct click event and open a new blank ProductMaintenanceEdit "add product" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Open a new ProductMaintenance "add product" form
            ShowDialog();
        }

        /// <summary>
        /// Handle the buttonEditProduct click event and open a new ProductMaintenanceEdit "edit product" form by parsing the selected productsListBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            // Open a new ProductMaintenance "edit product" form with data from parsed productString
            ParseBySelection("edit");
        }

        /// <summary>
        /// Handle the buttonShowProduct click event and open a new ProductMaintenanceEdit "show product" form by parsing the selected productsListBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowProduct_Click(object sender, EventArgs e)
        {
            // Open a new ProductMaintenance "show product" form with data from parsed productString
            ParseBySelection("show");
        }

        /// <summary>
        /// Handle the buttonExit click event and close the program after confirming
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Open a new dialog window to confirm if the user wants to exit
            DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            // If the user confirms "yes"
            if (confirm == DialogResult.Yes)
            {
                // Exit the  application
                Application.Exit();
            }
        }

        /// <summary>
        /// Handle a MouseDoubleClick event and open a new ProductMaintenanceEdit form with data passed in from double clicking a productsListBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Define a string to be used to capture the active selection
            string selection;

            // Get the index of the productsListBox item at the mouse click location
            int index = this.productsListBox.IndexFromPoint(e.Location);

            // If there is an acive selection
            if (index != System.Windows.Forms.ListBox.NoMatches && productsListBox.SelectedIndex >= 0)
            {
                // Get the selected productsListBox item and convert it to a string
                selection = this.productsListBox.SelectedItem.ToString()!;

                // Open a new ProductMaintenanceEdit form with data from the clicked productsItemBox list item
                ParseByProductString("show", selection);
            }
        }

        // When the form loads, manipulate active controls and populate productsListBox
        private void ProductMaintenence_Load(object sender, EventArgs e)
        {
            // Refresh the productsListBox with values from the database
            RefreshProductsListBox();

            // Sets the active control to buttonShowProduct
            this.ActiveControl = buttonShowProduct;

            // If the item count in the productsListBox is greater than zero
            if (this.productsListBox.Items.Count > 0)
            {
                // Then set the productsListBox selected item to the first in the list
                this.productsListBox.SelectedIndex = 0;
            }
        }

        // Handle refresh button click
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Call the refresh method
            RefreshProductsListBox();
        }
    }

}

