namespace Andre_Cherrier_Project_3
{
    partial class technologyStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(technologyStoreForm));
            this.addToCartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.computerListBox = new System.Windows.Forms.ListBox();
            this.televisionListBox = new System.Windows.Forms.ListBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.enterCoupon = new System.Windows.Forms.Label();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.computerCheckBox = new System.Windows.Forms.CheckBox();
            this.televisionCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneGroupBox = new System.Windows.Forms.GroupBox();
            this.computerGroupBox = new System.Windows.Forms.GroupBox();
            this.televisionGroupBox = new System.Windows.Forms.GroupBox();
            this.clearForm = new System.Windows.Forms.Button();
            this.couponTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.subTotalCartGridView = new System.Windows.Forms.DataGridView();
            this.itemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridView = new System.Windows.Forms.DataGridView();
            this.subTotalColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.couponButton = new System.Windows.Forms.Button();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.totalCartGridView = new System.Windows.Forms.DataGridView();
            this.totalGridView = new System.Windows.Forms.DataGridView();
            this.finalItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityPurchasedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDesriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPricePurchasedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGroupBox.SuspendLayout();
            this.computerGroupBox.SuspendLayout();
            this.televisionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subTotalCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTotalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(338, 486);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(103, 23);
            this.addToCartButton.TabIndex = 0;
            this.addToCartButton.Text = "Add to cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(675, 550);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit Form";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // phoneListBox
            // 
            this.phoneListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.Location = new System.Drawing.Point(6, 33);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(316, 95);
            this.phoneListBox.TabIndex = 2;
            this.phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            // 
            // computerListBox
            // 
            this.computerListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerListBox.FormattingEnabled = true;
            this.computerListBox.Location = new System.Drawing.Point(6, 33);
            this.computerListBox.Name = "computerListBox";
            this.computerListBox.Size = new System.Drawing.Size(316, 95);
            this.computerListBox.TabIndex = 3;
            this.computerListBox.SelectedIndexChanged += new System.EventHandler(this.computerListBox_SelectedIndexChanged);
            // 
            // televisionListBox
            // 
            this.televisionListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.televisionListBox.FormattingEnabled = true;
            this.televisionListBox.Location = new System.Drawing.Point(6, 33);
            this.televisionListBox.Name = "televisionListBox";
            this.televisionListBox.Size = new System.Drawing.Size(316, 95);
            this.televisionListBox.TabIndex = 4;
            this.televisionListBox.SelectedIndexChanged += new System.EventHandler(this.televisionListBox_SelectedIndexChanged);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(504, 21);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(29, 13);
            this.cartLabel.TabIndex = 5;
            this.cartLabel.Text = "Cart:";
            this.cartLabel.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(173, 417);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(86, 13);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Item Description:";
            this.descriptionLabel.Visible = false;
            // 
            // enterCoupon
            // 
            this.enterCoupon.AutoSize = true;
            this.enterCoupon.Location = new System.Drawing.Point(751, 236);
            this.enterCoupon.Name = "enterCoupon";
            this.enterCoupon.Size = new System.Drawing.Size(101, 13);
            this.enterCoupon.TabIndex = 7;
            this.enterCoupon.Text = "Enter coupon code:";
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Location = new System.Drawing.Point(40, 33);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(92, 17);
            this.phoneCheckBox.TabIndex = 11;
            this.phoneCheckBox.Text = "Show Phones";
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            this.phoneCheckBox.CheckedChanged += new System.EventHandler(this.PhoneCheckBox_CheckedChanged);
            // 
            // computerCheckBox
            // 
            this.computerCheckBox.AutoSize = true;
            this.computerCheckBox.Location = new System.Drawing.Point(40, 165);
            this.computerCheckBox.Name = "computerCheckBox";
            this.computerCheckBox.Size = new System.Drawing.Size(106, 17);
            this.computerCheckBox.TabIndex = 12;
            this.computerCheckBox.Text = "Show Computers";
            this.computerCheckBox.UseVisualStyleBackColor = true;
            this.computerCheckBox.CheckedChanged += new System.EventHandler(this.computerCheckBox_CheckedChanged);
            // 
            // televisionCheckBox
            // 
            this.televisionCheckBox.AutoSize = true;
            this.televisionCheckBox.Location = new System.Drawing.Point(40, 297);
            this.televisionCheckBox.Name = "televisionCheckBox";
            this.televisionCheckBox.Size = new System.Drawing.Size(109, 17);
            this.televisionCheckBox.TabIndex = 13;
            this.televisionCheckBox.Text = "Show Televisions";
            this.televisionCheckBox.UseVisualStyleBackColor = true;
            this.televisionCheckBox.CheckedChanged += new System.EventHandler(this.televisionCheckBox_CheckedChanged);
            // 
            // phoneGroupBox
            // 
            this.phoneGroupBox.Controls.Add(this.phoneListBox);
            this.phoneGroupBox.Location = new System.Drawing.Point(170, 12);
            this.phoneGroupBox.Name = "phoneGroupBox";
            this.phoneGroupBox.Size = new System.Drawing.Size(328, 134);
            this.phoneGroupBox.TabIndex = 14;
            this.phoneGroupBox.TabStop = false;
            this.phoneGroupBox.Text = "Phones";
            this.phoneGroupBox.Visible = false;
            // 
            // computerGroupBox
            // 
            this.computerGroupBox.Controls.Add(this.computerListBox);
            this.computerGroupBox.Location = new System.Drawing.Point(170, 146);
            this.computerGroupBox.Name = "computerGroupBox";
            this.computerGroupBox.Size = new System.Drawing.Size(328, 134);
            this.computerGroupBox.TabIndex = 0;
            this.computerGroupBox.TabStop = false;
            this.computerGroupBox.Text = "Computers";
            this.computerGroupBox.Visible = false;
            // 
            // televisionGroupBox
            // 
            this.televisionGroupBox.Controls.Add(this.televisionListBox);
            this.televisionGroupBox.Location = new System.Drawing.Point(170, 280);
            this.televisionGroupBox.Name = "televisionGroupBox";
            this.televisionGroupBox.Size = new System.Drawing.Size(328, 134);
            this.televisionGroupBox.TabIndex = 0;
            this.televisionGroupBox.TabStop = false;
            this.televisionGroupBox.Text = "Televisions";
            this.televisionGroupBox.Visible = false;
            // 
            // clearForm
            // 
            this.clearForm.Location = new System.Drawing.Point(675, 521);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(75, 23);
            this.clearForm.TabIndex = 17;
            this.clearForm.Text = "Clear Form";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // couponTextBox
            // 
            this.couponTextBox.Location = new System.Drawing.Point(867, 233);
            this.couponTextBox.Name = "couponTextBox";
            this.couponTextBox.Size = new System.Drawing.Size(100, 20);
            this.couponTextBox.TabIndex = 19;
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(176, 433);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.ReadOnly = true;
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(322, 43);
            this.itemDescriptionTextBox.TabIndex = 20;
            this.itemDescriptionTextBox.Visible = false;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(286, 488);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(32, 20);
            this.quantityTextBox.TabIndex = 21;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(167, 491);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(113, 13);
            this.quantityLabel.TabIndex = 22;
            this.quantityLabel.Text = "Enter quantity wanted:";
            // 
            // subTotalCartGridView
            // 
            this.subTotalCartGridView.AllowUserToAddRows = false;
            this.subTotalCartGridView.AllowUserToDeleteRows = false;
            this.subTotalCartGridView.AllowUserToResizeColumns = false;
            this.subTotalCartGridView.AllowUserToResizeRows = false;
            this.subTotalCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subTotalCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemColumn,
            this.quantityColumn,
            this.priceColumn,
            this.descriptionColumn});
            this.subTotalCartGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.subTotalCartGridView.Location = new System.Drawing.Point(504, 37);
            this.subTotalCartGridView.MultiSelect = false;
            this.subTotalCartGridView.Name = "subTotalCartGridView";
            this.subTotalCartGridView.ReadOnly = true;
            this.subTotalCartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subTotalCartGridView.Size = new System.Drawing.Size(614, 160);
            this.subTotalCartGridView.TabIndex = 23;
            this.subTotalCartGridView.Visible = false;
            // 
            // itemColumn
            // 
            this.itemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemColumn.HeaderText = "Item";
            this.itemColumn.Name = "itemColumn";
            this.itemColumn.ReadOnly = true;
            this.itemColumn.Width = 52;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 71;
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceColumn.HeaderText = "Subtotal Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 98;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            this.descriptionColumn.Width = 85;
            // 
            // subTotalDataGridView
            // 
            this.subTotalDataGridView.AllowUserToAddRows = false;
            this.subTotalDataGridView.AllowUserToDeleteRows = false;
            this.subTotalDataGridView.AllowUserToResizeColumns = false;
            this.subTotalDataGridView.AllowUserToResizeRows = false;
            this.subTotalDataGridView.ColumnHeadersVisible = false;
            this.subTotalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTotalColumnName,
            this.subTotalColumn,
            this.totalQuantityColumn});
            this.subTotalDataGridView.Location = new System.Drawing.Point(504, 203);
            this.subTotalDataGridView.Name = "subTotalDataGridView";
            this.subTotalDataGridView.ReadOnly = true;
            this.subTotalDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.subTotalDataGridView.RowHeadersVisible = false;
            this.subTotalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subTotalDataGridView.Size = new System.Drawing.Size(617, 22);
            this.subTotalDataGridView.TabIndex = 24;
            this.subTotalDataGridView.Visible = false;
            // 
            // subTotalColumnName
            // 
            this.subTotalColumnName.HeaderText = "Subtotal";
            this.subTotalColumnName.Name = "subTotalColumnName";
            this.subTotalColumnName.ReadOnly = true;
            this.subTotalColumnName.Width = 5;
            // 
            // subTotalColumn
            // 
            this.subTotalColumn.HeaderText = "Subtotal Cost";
            this.subTotalColumn.Name = "subTotalColumn";
            this.subTotalColumn.ReadOnly = true;
            this.subTotalColumn.Width = 5;
            // 
            // totalQuantityColumn
            // 
            this.totalQuantityColumn.HeaderText = "Total Quantity";
            this.totalQuantityColumn.Name = "totalQuantityColumn";
            this.totalQuantityColumn.ReadOnly = true;
            this.totalQuantityColumn.Width = 5;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(504, 231);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(109, 23);
            this.removeItemButton.TabIndex = 26;
            this.removeItemButton.Text = "Remove from cart";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Visible = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // couponButton
            // 
            this.couponButton.Location = new System.Drawing.Point(986, 231);
            this.couponButton.Name = "couponButton";
            this.couponButton.Size = new System.Drawing.Size(100, 23);
            this.couponButton.TabIndex = 27;
            this.couponButton.Text = "Enter coupon";
            this.couponButton.UseVisualStyleBackColor = true;
            this.couponButton.Click += new System.EventHandler(this.couponButton_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(628, 231);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(108, 23);
            this.finalizeButton.TabIndex = 28;
            this.finalizeButton.Text = "Finalize Purchase";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // totalCartGridView
            // 
            this.totalCartGridView.AllowUserToAddRows = false;
            this.totalCartGridView.AllowUserToDeleteRows = false;
            this.totalCartGridView.AllowUserToResizeColumns = false;
            this.totalCartGridView.AllowUserToResizeRows = false;
            this.totalCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finalItemColumn,
            this.totalQuantityPurchasedColumn,
            this.finalPriceColumn,
            this.finalDesriptionColumn});
            this.totalCartGridView.Location = new System.Drawing.Point(507, 270);
            this.totalCartGridView.Name = "totalCartGridView";
            this.totalCartGridView.Size = new System.Drawing.Size(614, 160);
            this.totalCartGridView.TabIndex = 29;
            this.totalCartGridView.Visible = false;
            // 
            // totalGridView
            // 
            this.totalGridView.AllowUserToAddRows = false;
            this.totalGridView.AllowUserToDeleteRows = false;
            this.totalGridView.AllowUserToResizeColumns = false;
            this.totalGridView.AllowUserToResizeRows = false;
            this.totalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalColumn,
            this.dataGridViewTextBoxColumn1,
            this.totalPricePurchasedColumn});
            this.totalGridView.Enabled = false;
            this.totalGridView.Location = new System.Drawing.Point(507, 436);
            this.totalGridView.Name = "totalGridView";
            this.totalGridView.ReadOnly = true;
            this.totalGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.totalGridView.Size = new System.Drawing.Size(614, 22);
            this.totalGridView.TabIndex = 30;
            this.totalGridView.Visible = false;
            // 
            // finalItemColumn
            // 
            this.finalItemColumn.HeaderText = "Item";
            this.finalItemColumn.Name = "finalItemColumn";
            this.finalItemColumn.ReadOnly = true;
            this.finalItemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalQuantityPurchasedColumn
            // 
            this.totalQuantityPurchasedColumn.HeaderText = "Quantity";
            this.totalQuantityPurchasedColumn.Name = "totalQuantityPurchasedColumn";
            this.totalQuantityPurchasedColumn.ReadOnly = true;
            this.totalQuantityPurchasedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // finalPriceColumn
            // 
            this.finalPriceColumn.HeaderText = "Final Price";
            this.finalPriceColumn.Name = "finalPriceColumn";
            this.finalPriceColumn.ReadOnly = true;
            this.finalPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // finalDesriptionColumn
            // 
            this.finalDesriptionColumn.HeaderText = "Description";
            this.finalDesriptionColumn.Name = "finalDesriptionColumn";
            this.finalDesriptionColumn.ReadOnly = true;
            this.finalDesriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            this.totalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Total Quantity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalPricePurchasedColumn
            // 
            this.totalPricePurchasedColumn.HeaderText = "Total";
            this.totalPricePurchasedColumn.Name = "totalPricePurchasedColumn";
            this.totalPricePurchasedColumn.ReadOnly = true;
            this.totalPricePurchasedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // technologyStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 623);
            this.Controls.Add(this.totalGridView);
            this.Controls.Add(this.totalCartGridView);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.couponButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.subTotalDataGridView);
            this.Controls.Add(this.subTotalCartGridView);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(this.couponTextBox);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.computerGroupBox);
            this.Controls.Add(this.televisionGroupBox);
            this.Controls.Add(this.phoneGroupBox);
            this.Controls.Add(this.televisionCheckBox);
            this.Controls.Add(this.computerCheckBox);
            this.Controls.Add(this.phoneCheckBox);
            this.Controls.Add(this.enterCoupon);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addToCartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "technologyStoreForm";
            this.Text = "Technology Store Form";
            this.phoneGroupBox.ResumeLayout(false);
            this.computerGroupBox.ResumeLayout(false);
            this.televisionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subTotalCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTotalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.ListBox computerListBox;
        private System.Windows.Forms.ListBox televisionListBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label enterCoupon;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.CheckBox computerCheckBox;
        private System.Windows.Forms.CheckBox televisionCheckBox;
        private System.Windows.Forms.GroupBox phoneGroupBox;
        private System.Windows.Forms.GroupBox computerGroupBox;
        private System.Windows.Forms.GroupBox televisionGroupBox;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.TextBox couponTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.DataGridView subTotalCartGridView;
        private System.Windows.Forms.DataGridView subTotalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityColumn;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button couponButton;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridView totalCartGridView;
        private System.Windows.Forms.DataGridView totalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityPurchasedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDesriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPricePurchasedColumn;
    }
}

