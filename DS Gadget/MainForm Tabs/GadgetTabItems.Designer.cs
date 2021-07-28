namespace DS_Gadget
{
    partial class GadgetTabItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblUpgrade;
            System.Windows.Forms.Label lblInfusion;
            System.Windows.Forms.Label lblQuantity;
            System.Windows.Forms.Label lblCategory;
            this.maxUpgrade = new System.Windows.Forms.CheckBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nudUpgrade = new System.Windows.Forms.NumericUpDown();
            this.cmbInfusion = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbxQuantityRestrict = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            lblUpgrade = new System.Windows.Forms.Label();
            lblInfusion = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // maxUpgrade
            // 
            this.maxUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxUpgrade.AutoSize = true;
            this.maxUpgrade.Checked = true;
            this.maxUpgrade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maxUpgrade.Location = new System.Drawing.Point(171, 49);
            this.maxUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.maxUpgrade.Name = "maxUpgrade";
            this.maxUpgrade.Size = new System.Drawing.Size(130, 24);
            this.maxUpgrade.TabIndex = 26;
            this.maxUpgrade.Text = "Max Upgrade";
            this.maxUpgrade.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(4, 100);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(284, 26);
            this.searchBox.TabIndex = 16;
            this.searchBox.Text = "Search...";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Click);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // lbxItems
            // 
            this.lbxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.IntegralHeight = false;
            this.lbxItems.ItemHeight = 20;
            this.lbxItems.Location = new System.Drawing.Point(4, 132);
            this.lbxItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbxItems.MinimumSize = new System.Drawing.Size(0, 24);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.ScrollAlwaysVisible = true;
            this.lbxItems.Size = new System.Drawing.Size(284, 304);
            this.lbxItems.TabIndex = 23;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            this.lbxItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            this.lbxItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxItems_MouseDoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(188, 67);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // nudUpgrade
            // 
            this.nudUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudUpgrade.Enabled = false;
            this.nudUpgrade.Location = new System.Drawing.Point(96, 70);
            this.nudUpgrade.Margin = new System.Windows.Forms.Padding(4);
            this.nudUpgrade.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudUpgrade.Name = "nudUpgrade";
            this.nudUpgrade.Size = new System.Drawing.Size(84, 26);
            this.nudUpgrade.TabIndex = 22;
            this.nudUpgrade.Click += new System.EventHandler(this.nudUpgrade_Click);
            this.nudUpgrade.Enter += new System.EventHandler(this.nudUpgrade_Click);
            // 
            // lblUpgrade
            // 
            lblUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblUpgrade.AutoSize = true;
            lblUpgrade.Location = new System.Drawing.Point(93, 49);
            lblUpgrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpgrade.Name = "lblUpgrade";
            lblUpgrade.Size = new System.Drawing.Size(71, 20);
            lblUpgrade.TabIndex = 21;
            lblUpgrade.Text = "Upgrade";
            // 
            // cmbInfusion
            // 
            this.cmbInfusion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInfusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInfusion.Enabled = false;
            this.cmbInfusion.FormattingEnabled = true;
            this.cmbInfusion.Location = new System.Drawing.Point(4, 70);
            this.cmbInfusion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInfusion.MaxDropDownItems = 100;
            this.cmbInfusion.MinimumSize = new System.Drawing.Size(84, 0);
            this.cmbInfusion.Name = "cmbInfusion";
            this.cmbInfusion.Size = new System.Drawing.Size(84, 28);
            this.cmbInfusion.TabIndex = 20;
            this.cmbInfusion.SelectedIndexChanged += new System.EventHandler(this.cmbInfusion_SelectedIndexChanged);
            // 
            // lblInfusion
            // 
            lblInfusion.AutoSize = true;
            lblInfusion.Location = new System.Drawing.Point(4, 49);
            lblInfusion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfusion.Name = "lblInfusion";
            lblInfusion.Size = new System.Drawing.Size(66, 20);
            lblInfusion.TabIndex = 19;
            lblInfusion.Text = "Infusion";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Enabled = false;
            this.nudQuantity.Location = new System.Drawing.Point(96, 22);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(84, 26);
            this.nudQuantity.TabIndex = 18;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxQuantityRestrict
            // 
            this.cbxQuantityRestrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxQuantityRestrict.AutoSize = true;
            this.cbxQuantityRestrict.Checked = true;
            this.cbxQuantityRestrict.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxQuantityRestrict.Location = new System.Drawing.Point(176, 23);
            this.cbxQuantityRestrict.Margin = new System.Windows.Forms.Padding(4);
            this.cbxQuantityRestrict.Name = "cbxQuantityRestrict";
            this.cbxQuantityRestrict.Size = new System.Drawing.Size(90, 24);
            this.cbxQuantityRestrict.TabIndex = 25;
            this.cbxQuantityRestrict.Text = "Restrict";
            this.cbxQuantityRestrict.UseVisualStyleBackColor = true;
            this.cbxQuantityRestrict.CheckedChanged += new System.EventHandler(this.cbxQuantityRestrict_CheckedChanged);
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(93, 0);
            lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(68, 20);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "Quantity";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(4, 21);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.MaxDropDownItems = 100;
            this.cmbCategory.MinimumSize = new System.Drawing.Size(84, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(84, 28);
            this.cmbCategory.TabIndex = 15;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(4, 0);
            lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(73, 20);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // GadgetTabItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.maxUpgrade);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nudUpgrade);
            this.Controls.Add(lblUpgrade);
            this.Controls.Add(this.cmbInfusion);
            this.Controls.Add(lblInfusion);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbxQuantityRestrict);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(lblCategory);
            this.Name = "GadgetTabItems";
            this.Size = new System.Drawing.Size(292, 440);
            ((System.ComponentModel.ISupportInitialize)(this.nudUpgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nudUpgrade;
        private System.Windows.Forms.ComboBox cmbInfusion;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.CheckBox cbxQuantityRestrict;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.CheckBox maxUpgrade;
    }
}
