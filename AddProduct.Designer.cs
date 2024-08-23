namespace InventoryMgmt
{
    partial class AddProduct
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PartSave = new Button();
            ProductsBttBox = new GroupBox();
            PartCancel = new Button();
            PartId = new TextBox();
            PartIdLabel = new Label();
            PartMaxLabel = new Label();
            PartMaxInput = new TextBox();
            PartMinLabel = new Label();
            PartMinInput = new TextBox();
            PartPriceLabel = new Label();
            PartPriceInput = new TextBox();
            PartInventoryLabel = new Label();
            PartInventoryInput = new TextBox();
            PartNameLabel = new Label();
            PartNameInput = new TextBox();
            AddPartPanel = new FlowLayoutPanel();
            ProductContainer = new GroupBox();
            DeletePart = new Button();
            SelectedParts = new DataGridView();
            AddedPartsLabel = new TextBox();
            AddPart = new Button();
            AllParts = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outsourcedPartBindingSource = new BindingSource(components);
            CandidatePartsLabel = new TextBox();
            SearchBoxInput = new TextBox();
            SearchBtt = new Button();
            Title = new Label();
            inHousePartBindingSource = new BindingSource(components);
            ProductsBttBox.SuspendLayout();
            AddPartPanel.SuspendLayout();
            ProductContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SelectedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedPartBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inHousePartBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PartSave
            // 
            PartSave.BackColor = Color.DarkSeaGreen;
            PartSave.Location = new Point(561, 36);
            PartSave.Margin = new Padding(2, 3, 2, 3);
            PartSave.Name = "PartSave";
            PartSave.Size = new Size(69, 33);
            PartSave.TabIndex = 0;
            PartSave.Text = "Save";
            PartSave.UseVisualStyleBackColor = false;
            // 
            // ProductsBttBox
            // 
            ProductsBttBox.Controls.Add(PartCancel);
            ProductsBttBox.Controls.Add(PartSave);
            ProductsBttBox.Location = new Point(2, 510);
            ProductsBttBox.Margin = new Padding(2, 3, 2, 3);
            ProductsBttBox.Name = "ProductsBttBox";
            ProductsBttBox.Padding = new Padding(2, 3, 2, 3);
            ProductsBttBox.Size = new Size(1399, 87);
            ProductsBttBox.TabIndex = 3;
            ProductsBttBox.TabStop = false;
            // 
            // PartCancel
            // 
            PartCancel.BackColor = Color.IndianRed;
            PartCancel.Location = new Point(869, 36);
            PartCancel.Margin = new Padding(2, 3, 2, 3);
            PartCancel.Name = "PartCancel";
            PartCancel.Size = new Size(69, 33);
            PartCancel.TabIndex = 1;
            PartCancel.Text = "Cancel";
            PartCancel.UseVisualStyleBackColor = false;
            // 
            // PartId
            // 
            PartId.BackColor = SystemColors.ActiveCaption;
            PartId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartId.Location = new Point(139, 53);
            PartId.Name = "PartId";
            PartId.ReadOnly = true;
            PartId.Size = new Size(125, 34);
            PartId.TabIndex = 16;
            // 
            // PartIdLabel
            // 
            PartIdLabel.AutoSize = true;
            PartIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartIdLabel.Location = new Point(6, 53);
            PartIdLabel.Name = "PartIdLabel";
            PartIdLabel.Size = new Size(44, 38);
            PartIdLabel.TabIndex = 15;
            PartIdLabel.Text = "ID";
            // 
            // PartMaxLabel
            // 
            PartMaxLabel.AutoSize = true;
            PartMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMaxLabel.Location = new Point(221, 360);
            PartMaxLabel.Name = "PartMaxLabel";
            PartMaxLabel.Size = new Size(58, 31);
            PartMaxLabel.TabIndex = 12;
            PartMaxLabel.Text = "Max";
            // 
            // PartMaxInput
            // 
            PartMaxInput.BackColor = Color.Gainsboro;
            PartMaxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartMaxInput.Location = new Point(300, 359);
            PartMaxInput.Name = "PartMaxInput";
            PartMaxInput.Size = new Size(91, 34);
            PartMaxInput.TabIndex = 11;
            // 
            // PartMinLabel
            // 
            PartMinLabel.AutoSize = true;
            PartMinLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMinLabel.Location = new Point(6, 360);
            PartMinLabel.Name = "PartMinLabel";
            PartMinLabel.Size = new Size(54, 31);
            PartMinLabel.TabIndex = 10;
            PartMinLabel.Text = "Min";
            // 
            // PartMinInput
            // 
            PartMinInput.BackColor = Color.Gainsboro;
            PartMinInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartMinInput.Location = new Point(81, 357);
            PartMinInput.Name = "PartMinInput";
            PartMinInput.Size = new Size(91, 34);
            PartMinInput.TabIndex = 9;
            // 
            // PartPriceLabel
            // 
            PartPriceLabel.AutoSize = true;
            PartPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartPriceLabel.Location = new Point(6, 271);
            PartPriceLabel.Name = "PartPriceLabel";
            PartPriceLabel.Size = new Size(118, 31);
            PartPriceLabel.TabIndex = 8;
            PartPriceLabel.Text = "Price/Cost";
            // 
            // PartPriceInput
            // 
            PartPriceInput.BackColor = Color.Gainsboro;
            PartPriceInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartPriceInput.Location = new Point(139, 263);
            PartPriceInput.Name = "PartPriceInput";
            PartPriceInput.Size = new Size(269, 34);
            PartPriceInput.TabIndex = 7;
            // 
            // PartInventoryLabel
            // 
            PartInventoryLabel.AutoSize = true;
            PartInventoryLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartInventoryLabel.Location = new Point(6, 192);
            PartInventoryLabel.Name = "PartInventoryLabel";
            PartInventoryLabel.Size = new Size(109, 31);
            PartInventoryLabel.TabIndex = 6;
            PartInventoryLabel.Text = "Inventory";
            // 
            // PartInventoryInput
            // 
            PartInventoryInput.BackColor = Color.Gainsboro;
            PartInventoryInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartInventoryInput.Location = new Point(139, 184);
            PartInventoryInput.Name = "PartInventoryInput";
            PartInventoryInput.Size = new Size(269, 34);
            PartInventoryInput.TabIndex = 5;
            // 
            // PartNameLabel
            // 
            PartNameLabel.AutoSize = true;
            PartNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartNameLabel.Location = new Point(6, 115);
            PartNameLabel.Name = "PartNameLabel";
            PartNameLabel.Size = new Size(75, 31);
            PartNameLabel.TabIndex = 4;
            PartNameLabel.Text = "Name";
            // 
            // PartNameInput
            // 
            PartNameInput.BackColor = Color.Gainsboro;
            PartNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartNameInput.Location = new Point(139, 107);
            PartNameInput.Name = "PartNameInput";
            PartNameInput.Size = new Size(269, 34);
            PartNameInput.TabIndex = 3;
            // 
            // AddPartPanel
            // 
            AddPartPanel.Controls.Add(ProductContainer);
            AddPartPanel.Controls.Add(ProductsBttBox);
            AddPartPanel.Location = new Point(12, 100);
            AddPartPanel.Name = "AddPartPanel";
            AddPartPanel.Size = new Size(1401, 597);
            AddPartPanel.TabIndex = 7;
            // 
            // ProductContainer
            // 
            ProductContainer.Controls.Add(DeletePart);
            ProductContainer.Controls.Add(SelectedParts);
            ProductContainer.Controls.Add(AddedPartsLabel);
            ProductContainer.Controls.Add(AddPart);
            ProductContainer.Controls.Add(AllParts);
            ProductContainer.Controls.Add(CandidatePartsLabel);
            ProductContainer.Controls.Add(SearchBoxInput);
            ProductContainer.Controls.Add(SearchBtt);
            ProductContainer.Controls.Add(PartId);
            ProductContainer.Controls.Add(PartIdLabel);
            ProductContainer.Controls.Add(PartMaxLabel);
            ProductContainer.Controls.Add(PartMaxInput);
            ProductContainer.Controls.Add(PartMinLabel);
            ProductContainer.Controls.Add(PartMinInput);
            ProductContainer.Controls.Add(PartPriceLabel);
            ProductContainer.Controls.Add(PartPriceInput);
            ProductContainer.Controls.Add(PartInventoryLabel);
            ProductContainer.Controls.Add(PartInventoryInput);
            ProductContainer.Controls.Add(PartNameLabel);
            ProductContainer.Controls.Add(PartNameInput);
            ProductContainer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProductContainer.Location = new Point(3, 3);
            ProductContainer.Name = "ProductContainer";
            ProductContainer.Size = new Size(1398, 501);
            ProductContainer.TabIndex = 0;
            ProductContainer.TabStop = false;
            ProductContainer.Text = "Add Product";
            // 
            // DeletePart
            // 
            DeletePart.BackColor = SystemColors.ActiveBorder;
            DeletePart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeletePart.Location = new Point(1247, 466);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(94, 29);
            DeletePart.TabIndex = 24;
            DeletePart.Text = "Delete";
            DeletePart.UseVisualStyleBackColor = false;
            // 
            // SelectedParts
            // 
            SelectedParts.AllowUserToAddRows = false;
            SelectedParts.AllowUserToDeleteRows = false;
            SelectedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectedParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            SelectedParts.Location = new Point(536, 297);
            SelectedParts.Name = "SelectedParts";
            SelectedParts.RowHeadersWidth = 51;
            SelectedParts.Size = new Size(805, 155);
            SelectedParts.TabIndex = 23;
            // 
            // AddedPartsLabel
            // 
            AddedPartsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddedPartsLabel.Location = new Point(536, 264);
            AddedPartsLabel.Name = "AddedPartsLabel";
            AddedPartsLabel.Size = new Size(229, 27);
            AddedPartsLabel.TabIndex = 22;
            AddedPartsLabel.Text = "Parts Associated with this Product";
            AddedPartsLabel.TextChanged += AddedPartsLabel_TextChanged;
            // 
            // AddPart
            // 
            AddPart.BackColor = SystemColors.ActiveBorder;
            AddPart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPart.Location = new Point(1247, 247);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(94, 29);
            AddPart.TabIndex = 21;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = false;
            AddPart.Click += AddPart_Click;
            // 
            // AllParts
            // 
            AllParts.AllowUserToAddRows = false;
            AllParts.AllowUserToDeleteRows = false;
            AllParts.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            AllParts.DataSource = outsourcedPartBindingSource;
            AllParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            AllParts.Location = new Point(536, 86);
            AllParts.Name = "AllParts";
            AllParts.RowHeadersWidth = 51;
            AllParts.Size = new Size(805, 155);
            AllParts.TabIndex = 20;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            partIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.MinimumWidth = 6;
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            minDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            maxDataGridViewTextBoxColumn.Width = 125;
            // 
            // outsourcedPartBindingSource
            // 
            outsourcedPartBindingSource.DataSource = typeof(OutsourcedPart);
            // 
            // CandidatePartsLabel
            // 
            CandidatePartsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CandidatePartsLabel.Location = new Point(536, 53);
            CandidatePartsLabel.Name = "CandidatePartsLabel";
            CandidatePartsLabel.Size = new Size(138, 27);
            CandidatePartsLabel.TabIndex = 19;
            CandidatePartsLabel.Text = "All candidate Parts";
            // 
            // SearchBoxInput
            // 
            SearchBoxInput.BackColor = Color.Gainsboro;
            SearchBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            SearchBoxInput.Location = new Point(1070, 26);
            SearchBoxInput.Name = "SearchBoxInput";
            SearchBoxInput.Size = new Size(271, 34);
            SearchBoxInput.TabIndex = 18;
            // 
            // SearchBtt
            // 
            SearchBtt.BackColor = SystemColors.ActiveBorder;
            SearchBtt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtt.Location = new Point(952, 31);
            SearchBtt.Name = "SearchBtt";
            SearchBtt.Size = new Size(94, 29);
            SearchBtt.TabIndex = 17;
            SearchBtt.Text = "Search";
            SearchBtt.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(12, 32);
            Title.Name = "Title";
            Title.Size = new Size(519, 46);
            Title.TabIndex = 6;
            Title.Text = "Inventory Management System";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1425, 729);
            Controls.Add(AddPartPanel);
            Controls.Add(Title);
            Name = "AddProduct";
            Text = "Add Product";
            ProductsBttBox.ResumeLayout(false);
            AddPartPanel.ResumeLayout(false);
            ProductContainer.ResumeLayout(false);
            ProductContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SelectedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedPartBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inHousePartBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PartSave;
        private GroupBox ProductsBttBox;
        private Button PartCancel;
        private TextBox PartId;
        private Label PartIdLabel;
        private Label PartMaxLabel;
        private TextBox PartMaxInput;
        private Label PartMinLabel;
        private TextBox PartMinInput;
        private Label PartPriceLabel;
        private TextBox PartPriceInput;
        private Label PartInventoryLabel;
        private TextBox PartInventoryInput;
        private Label PartNameLabel;
        private TextBox PartNameInput;
        private FlowLayoutPanel AddPartPanel;
        private GroupBox ProductContainer;
        private Label Title;
        private TextBox CandidatePartsLabel;
        private TextBox SearchBoxInput;
        private Button SearchBtt;
        private DataGridView AllParts;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource outsourcedPartBindingSource;
        private BindingSource inHousePartBindingSource;
        private Button AddPart;
        private TextBox AddedPartsLabel;
        private DataGridView SelectedParts;
        private Button DeletePart;
    }
}