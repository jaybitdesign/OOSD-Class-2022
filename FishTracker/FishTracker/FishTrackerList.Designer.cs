namespace FishTracker
{
    partial class FishTrackerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.groupBoxSortControls = new System.Windows.Forms.GroupBox();
            this.radioButtonPhoto = new System.Windows.Forms.RadioButton();
            this.radioButtonLength = new System.Windows.Forms.RadioButton();
            this.radioButtonTackle = new System.Windows.Forms.RadioButton();
            this.radioButtonWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecies = new System.Windows.Forms.RadioButton();
            this.checkBoxDescending = new System.Windows.Forms.CheckBox();
            this.buttonShowCatch = new System.Windows.Forms.Button();
            this.buttonAddCatch = new System.Windows.Forms.Button();
            this.buttonEditCatch = new System.Windows.Forms.Button();
            this.buttonDeleteCatch = new System.Windows.Forms.Button();
            this.dataGridViewCatches = new System.Windows.Forms.DataGridView();
            this.groupBoxSortControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatches)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Checked = true;
            this.radioButtonDate.Location = new System.Drawing.Point(12, 50);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(49, 19);
            this.radioButtonDate.TabIndex = 0;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // groupBoxSortControls
            // 
            this.groupBoxSortControls.Controls.Add(this.radioButtonPhoto);
            this.groupBoxSortControls.Controls.Add(this.checkBoxDescending);
            this.groupBoxSortControls.Controls.Add(this.radioButtonLength);
            this.groupBoxSortControls.Controls.Add(this.radioButtonTackle);
            this.groupBoxSortControls.Controls.Add(this.radioButtonWeight);
            this.groupBoxSortControls.Controls.Add(this.radioButtonLocation);
            this.groupBoxSortControls.Controls.Add(this.radioButtonSpecies);
            this.groupBoxSortControls.Controls.Add(this.radioButtonDate);
            this.groupBoxSortControls.Location = new System.Drawing.Point(12, 13);
            this.groupBoxSortControls.Name = "groupBoxSortControls";
            this.groupBoxSortControls.Size = new System.Drawing.Size(111, 235);
            this.groupBoxSortControls.TabIndex = 1;
            this.groupBoxSortControls.TabStop = false;
            this.groupBoxSortControls.Text = "Sort By";
            // 
            // radioButtonPhoto
            // 
            this.radioButtonPhoto.AutoSize = true;
            this.radioButtonPhoto.Location = new System.Drawing.Point(12, 100);
            this.radioButtonPhoto.Name = "radioButtonPhoto";
            this.radioButtonPhoto.Size = new System.Drawing.Size(57, 19);
            this.radioButtonPhoto.TabIndex = 8;
            this.radioButtonPhoto.Text = "Photo";
            this.radioButtonPhoto.UseVisualStyleBackColor = true;
            this.radioButtonPhoto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonLength
            // 
            this.radioButtonLength.AutoSize = true;
            this.radioButtonLength.Location = new System.Drawing.Point(12, 200);
            this.radioButtonLength.Name = "radioButtonLength";
            this.radioButtonLength.Size = new System.Drawing.Size(62, 19);
            this.radioButtonLength.TabIndex = 6;
            this.radioButtonLength.Text = "Length";
            this.radioButtonLength.UseVisualStyleBackColor = true;
            this.radioButtonLength.CheckedChanged += new System.EventHandler(this.radioButtonLength_CheckedChanged);
            // 
            // radioButtonTackle
            // 
            this.radioButtonTackle.AutoSize = true;
            this.radioButtonTackle.Location = new System.Drawing.Point(12, 150);
            this.radioButtonTackle.Name = "radioButtonTackle";
            this.radioButtonTackle.Size = new System.Drawing.Size(57, 19);
            this.radioButtonTackle.TabIndex = 5;
            this.radioButtonTackle.Text = "Tackle";
            this.radioButtonTackle.UseVisualStyleBackColor = true;
            this.radioButtonTackle.CheckedChanged += new System.EventHandler(this.radioButtonTackle_CheckedChanged);
            // 
            // radioButtonWeight
            // 
            this.radioButtonWeight.AutoSize = true;
            this.radioButtonWeight.Location = new System.Drawing.Point(12, 175);
            this.radioButtonWeight.Name = "radioButtonWeight";
            this.radioButtonWeight.Size = new System.Drawing.Size(63, 19);
            this.radioButtonWeight.TabIndex = 3;
            this.radioButtonWeight.Text = "Weight";
            this.radioButtonWeight.UseVisualStyleBackColor = true;
            this.radioButtonWeight.CheckedChanged += new System.EventHandler(this.radioButtonWeight_CheckedChanged);
            // 
            // radioButtonLocation
            // 
            this.radioButtonLocation.AutoSize = true;
            this.radioButtonLocation.Location = new System.Drawing.Point(12, 125);
            this.radioButtonLocation.Name = "radioButtonLocation";
            this.radioButtonLocation.Size = new System.Drawing.Size(71, 19);
            this.radioButtonLocation.TabIndex = 2;
            this.radioButtonLocation.Text = "Location";
            this.radioButtonLocation.UseVisualStyleBackColor = true;
            this.radioButtonLocation.CheckedChanged += new System.EventHandler(this.radioButtonLocation_CheckedChanged);
            // 
            // radioButtonSpecies
            // 
            this.radioButtonSpecies.AutoSize = true;
            this.radioButtonSpecies.Location = new System.Drawing.Point(12, 75);
            this.radioButtonSpecies.Name = "radioButtonSpecies";
            this.radioButtonSpecies.Size = new System.Drawing.Size(64, 19);
            this.radioButtonSpecies.TabIndex = 1;
            this.radioButtonSpecies.Text = "Species";
            this.radioButtonSpecies.UseVisualStyleBackColor = true;
            this.radioButtonSpecies.CheckedChanged += new System.EventHandler(this.radioButtonSpecies_CheckedChanged);
            // 
            // checkBoxDescending
            // 
            this.checkBoxDescending.AutoSize = true;
            this.checkBoxDescending.Checked = true;
            this.checkBoxDescending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDescending.Location = new System.Drawing.Point(12, 25);
            this.checkBoxDescending.Name = "checkBoxDescending";
            this.checkBoxDescending.Size = new System.Drawing.Size(91, 19);
            this.checkBoxDescending.TabIndex = 7;
            this.checkBoxDescending.Text = "Descending";
            this.checkBoxDescending.UseVisualStyleBackColor = true;
            this.checkBoxDescending.CheckedChanged += new System.EventHandler(this.checkBoxDescending_CheckedChanged);
            // 
            // buttonShowCatch
            // 
            this.buttonShowCatch.Location = new System.Drawing.Point(12, 254);
            this.buttonShowCatch.Name = "buttonShowCatch";
            this.buttonShowCatch.Size = new System.Drawing.Size(111, 32);
            this.buttonShowCatch.TabIndex = 2;
            this.buttonShowCatch.Text = "Show Catch";
            this.buttonShowCatch.UseVisualStyleBackColor = true;
            // 
            // buttonAddCatch
            // 
            this.buttonAddCatch.Location = new System.Drawing.Point(12, 292);
            this.buttonAddCatch.Name = "buttonAddCatch";
            this.buttonAddCatch.Size = new System.Drawing.Size(111, 32);
            this.buttonAddCatch.TabIndex = 3;
            this.buttonAddCatch.Text = "Add Catch";
            this.buttonAddCatch.UseVisualStyleBackColor = true;
            // 
            // buttonEditCatch
            // 
            this.buttonEditCatch.Location = new System.Drawing.Point(12, 330);
            this.buttonEditCatch.Name = "buttonEditCatch";
            this.buttonEditCatch.Size = new System.Drawing.Size(111, 32);
            this.buttonEditCatch.TabIndex = 4;
            this.buttonEditCatch.Text = "Edit Catch";
            this.buttonEditCatch.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCatch
            // 
            this.buttonDeleteCatch.Location = new System.Drawing.Point(12, 368);
            this.buttonDeleteCatch.Name = "buttonDeleteCatch";
            this.buttonDeleteCatch.Size = new System.Drawing.Size(111, 32);
            this.buttonDeleteCatch.TabIndex = 5;
            this.buttonDeleteCatch.Text = "Delete Catch";
            this.buttonDeleteCatch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCatches
            // 
            this.dataGridViewCatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatches.Location = new System.Drawing.Point(139, 13);
            this.dataGridViewCatches.Name = "dataGridViewCatches";
            this.dataGridViewCatches.RowTemplate.Height = 25;
            this.dataGridViewCatches.Size = new System.Drawing.Size(841, 387);
            this.dataGridViewCatches.TabIndex = 6;
            // 
            // FishTrackerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 412);
            this.Controls.Add(this.dataGridViewCatches);
            this.Controls.Add(this.buttonDeleteCatch);
            this.Controls.Add(this.buttonEditCatch);
            this.Controls.Add(this.buttonAddCatch);
            this.Controls.Add(this.buttonShowCatch);
            this.Controls.Add(this.groupBoxSortControls);
            this.Name = "FishTrackerList";
            this.Text = "FishTrackerList";
            this.Load += new System.EventHandler(this.FishTrackerList_Load);
            this.groupBoxSortControls.ResumeLayout(false);
            this.groupBoxSortControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton radioButtonDate;
        private GroupBox groupBoxSortControls;
        private RadioButton radioButtonSpecies;
        private RadioButton radioButtonLength;
        private RadioButton radioButtonTackle;
        private RadioButton radioButtonWeight;
        private RadioButton radioButtonLocation;
        private Button buttonShowCatch;
        private CheckBox checkBoxDescending;
        private Button buttonAddCatch;
        private Button buttonEditCatch;
        private Button buttonDeleteCatch;
        private DataGridView dataGridViewCatches;
        private TextBox textBoxTotalCatches;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private RadioButton radioButtonPhoto;
    }
}