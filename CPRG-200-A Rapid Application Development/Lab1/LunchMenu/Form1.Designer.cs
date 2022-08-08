namespace LunchMenu
{
    partial class LunchMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuButton3 = new System.Windows.Forms.RadioButton();
            this.menuButton2 = new System.Windows.Forms.RadioButton();
            this.menuButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addonBox3 = new System.Windows.Forms.CheckBox();
            this.addonBox2 = new System.Windows.Forms.CheckBox();
            this.addonBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.menuButton3);
            this.groupBox2.Controls.Add(this.menuButton2);
            this.groupBox2.Controls.Add(this.menuButton1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Course";
            // 
            // menuButton3
            // 
            this.menuButton3.AutoSize = true;
            this.menuButton3.Location = new System.Drawing.Point(16, 72);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Size = new System.Drawing.Size(91, 19);
            this.menuButton3.TabIndex = 2;
            this.menuButton3.Text = "Salad - $4.95";
            this.menuButton3.UseVisualStyleBackColor = true;
            this.menuButton3.CheckedChanged += new System.EventHandler(this.menuButton3_CheckedChanged);
            // 
            // menuButton2
            // 
            this.menuButton2.AutoSize = true;
            this.menuButton2.Location = new System.Drawing.Point(16, 47);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(89, 19);
            this.menuButton2.TabIndex = 1;
            this.menuButton2.Text = "Pizza - $5.95";
            this.menuButton2.UseVisualStyleBackColor = true;
            this.menuButton2.CheckedChanged += new System.EventHandler(this.menuButton2_CheckedChanged);
            // 
            // menuButton1
            // 
            this.menuButton1.AutoSize = true;
            this.menuButton1.Checked = true;
            this.menuButton1.Location = new System.Drawing.Point(16, 21);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(124, 19);
            this.menuButton1.TabIndex = 0;
            this.menuButton1.TabStop = true;
            this.menuButton1.Text = "Hamburger - $6.95";
            this.menuButton1.UseVisualStyleBackColor = true;
            this.menuButton1.CheckedChanged += new System.EventHandler(this.menuButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addonBox3);
            this.groupBox3.Controls.Add(this.addonBox2);
            this.groupBox3.Controls.Add(this.addonBox1);
            this.groupBox3.Location = new System.Drawing.Point(229, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add-on Items";
            // 
            // addonBox3
            // 
            this.addonBox3.AutoSize = true;
            this.addonBox3.Location = new System.Drawing.Point(18, 72);
            this.addonBox3.Name = "addonBox3";
            this.addonBox3.Size = new System.Drawing.Size(127, 19);
            this.addonBox3.TabIndex = 2;
            this.addonBox3.Text = "+$0.75 French Fries";
            this.addonBox3.UseVisualStyleBackColor = true;
            // 
            // addonBox2
            // 
            this.addonBox2.AutoSize = true;
            this.addonBox2.Location = new System.Drawing.Point(18, 47);
            this.addonBox2.Name = "addonBox2";
            this.addonBox2.Size = new System.Drawing.Size(194, 19);
            this.addonBox2.TabIndex = 1;
            this.addonBox2.Text = "+$0.75 Ketchup, Mustard, Mayo";
            this.addonBox2.UseVisualStyleBackColor = true;
            // 
            // addonBox1
            // 
            this.addonBox1.AutoSize = true;
            this.addonBox1.Location = new System.Drawing.Point(18, 22);
            this.addonBox1.Name = "addonBox1";
            this.addonBox1.Size = new System.Drawing.Size(207, 19);
            this.addonBox1.TabIndex = 0;
            this.addonBox1.Text = " +$0.75 Lettuce, Tomatoes, Onions";
            this.addonBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.totalTextBox);
            this.groupBox4.Controls.Add(this.taxTextBox);
            this.groupBox4.Controls.Add(this.subtotalTextBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 112);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax (5%):";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(72, 78);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalTextBox.TabIndex = 3;
            this.totalTextBox.Text = "0.00";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(72, 49);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(100, 23);
            this.taxTextBox.TabIndex = 2;
            this.taxTextBox.Text = "0.00";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(72, 20);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 23);
            this.subtotalTextBox.TabIndex = 1;
            this.subtotalTextBox.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(229, 137);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(236, 31);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Order Now";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(229, 174);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(236, 31);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset Order";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(229, 211);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(236, 31);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit Menu";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // LunchMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(478, 259);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "LunchMenuForm";
            this.Text = "Lunch Menu - James Buchanan";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonOrder;
        private Button buttonReset;
        private Button buttonExit;
        private RadioButton menuButton3;
        private RadioButton menuButton2;
        private RadioButton menuButton1;
        private CheckBox addonBox3;
        private CheckBox addonBox2;
        private CheckBox addonBox1;
        private Label label3;
        private Label label2;
        private TextBox totalTextBox;
        private TextBox taxTextBox;
        private TextBox subtotalTextBox;
        private Label label1;
    }
}