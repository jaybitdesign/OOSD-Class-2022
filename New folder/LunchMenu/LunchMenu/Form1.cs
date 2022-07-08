namespace LunchMenu
{
    public partial class LunchMenuForm : Form
    {

        // Declare tax percentage
        const decimal TaxPercent = 0.05m;

        // Declare burger details
        const decimal BurgerPrice = 6.95m;
        const decimal BurgerAddonPrice = 0.75m;
        string[] BurgerAddons =
        {
            "+$0.75 Lettuce, Tomatoes, Onions",
            "+$0.75 Ketchup, Mustard, Mayo",
            "+$0.75 French Fries"
        };

        // Declare pizza details
        const decimal PizzaPrice = 5.95m;
        const decimal PizzaAddonPrice = 0.50m;
        string[] PizzaAddons =
        {
            "+$0.50 Pepperoni",
            "+$0.50 Sausage",
            "+$0.50 Olives"
        };

        // Declare salad details
        const decimal SaladPrice = 4.95m;
        const decimal SaladAddonPrice = 0.25m;
        string[] SaladAddons =
        {
            "+$0.25 Croutons",
            "+$0.25 Bacon Bits",
            "+$0.25 Bread Sticks"
        };

        public LunchMenuForm() { InitializeComponent(); }

        private void LunchMenuForm_Load(object sender, EventArgs e) { }

        // Exit program on click
        private void buttonExit_Click(object sender, EventArgs e) { Application.Exit(); }

        // Reset text boxes and addon checkboxes on click
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset text boxes
            subtotalTextBox.Text = "0.00";
            taxTextBox.Text = "0.00";
            totalTextBox.Text = "0.00";

            // Reset addons checkboxes
            addonBox1.Checked = false;
            addonBox2.Checked = false;
            addonBox3.Checked = false;
        }

        // Calculate price and tax on click
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;

            // If burger option is checked
            if (menuButton1.Checked)
            {
                // Set the subtotal to burger price
                subtotal = BurgerPrice;

                // Calculate burger addons
                if (addonBox1.Checked) { subtotal += BurgerAddonPrice; } 
                if (addonBox2.Checked) { subtotal += BurgerAddonPrice; }
                if (addonBox3.Checked) { subtotal += BurgerAddonPrice; }
            }

            // If pizza option is checked
            if (menuButton2.Checked)
            {
                // Set the subtotal to pizza price
                subtotal = PizzaPrice;

                // Calculate pizza addons
                if (addonBox1.Checked) { subtotal += PizzaAddonPrice; }
                if (addonBox2.Checked) { subtotal += PizzaAddonPrice; }
                if (addonBox3.Checked) { subtotal += PizzaAddonPrice; }
            }

            // If salad option is checked
            if (menuButton3.Checked)
            {
                // Set the subtotal to salad price
                subtotal = SaladPrice;

                // Calculate salad addons
                if (addonBox1.Checked) { subtotal += SaladAddonPrice; }
                if (addonBox2.Checked) { subtotal += SaladAddonPrice; }
                if (addonBox3.Checked) { subtotal += SaladAddonPrice; }
            }

            // Calculate tax
            decimal tax = subtotal * TaxPercent;

            // Calculate total
            decimal total = subtotal + tax;

            // Set text boxes with price and tax values
            subtotalTextBox.Text = subtotal.ToString("c");
            taxTextBox.Text = tax.ToString("c");
            totalTextBox.Text = total.ToString("c");

        }

        // Update burger addon checkboxes
        private void menuButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Set addons text to burger details
            addonBox1.Text = BurgerAddons[0];
            addonBox2.Text = BurgerAddons[1];
            addonBox3.Text = BurgerAddons[2];

            // Reset addons checkboxes
            addonBox1.Checked = false;
            addonBox2.Checked = false;
            addonBox3.Checked = false;
        }

        // Update pizza addon checkboxes
        private void menuButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Set addons text to pizza details
            addonBox1.Text = PizzaAddons[0];
            addonBox2.Text = PizzaAddons[1];
            addonBox3.Text = PizzaAddons[2];

            // Reset addons checkboxes
            addonBox1.Checked = false;
            addonBox2.Checked = false;
            addonBox3.Checked = false;
        }

        // Update salad addon checkboxes
        private void menuButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Set addons text to salad details
            addonBox1.Text = SaladAddons[0];
            addonBox2.Text = SaladAddons[1];
            addonBox3.Text = SaladAddons[2];

            // Reset addons checkboxes
            addonBox1.Checked = false;
            addonBox2.Checked = false;
            addonBox3.Checked = false;
        }
    }
}