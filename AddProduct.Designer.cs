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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            PartSave = new Button();
            ProductsBttBox = new GroupBox();
            PartCancel = new Button();
            ProductId = new TextBox();
            ProductIdLabel = new Label();
            ProductMaxLabel = new Label();
            ProductMaxInput = new TextBox();
            ProductMinLabel = new Label();
            ProductMinInput = new TextBox();
            ProductPriceLabel = new Label();
            ProductPriceInput = new TextBox();
            ProductInventoryLabel = new Label();
            ProductInventoryInput = new TextBox();
            ProductNameLabel = new Label();
            ProductNameInput = new TextBox();
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
            PartSave.Click += PartSave_Click;
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
            PartCancel.Click += PartCancel_Click;
            // 
            // ProductId
            // 
            ProductId.BackColor = SystemColors.ActiveCaption;
            ProductId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductId.Location = new Point(139, 53);
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Size = new Size(125, 34);
            ProductId.TabIndex = 16;
            // 
            // ProductIdLabel
            // 
            ProductIdLabel.AutoSize = true;
            ProductIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductIdLabel.Location = new Point(6, 53);
            ProductIdLabel.Name = "ProductIdLabel";
            ProductIdLabel.Size = new Size(44, 38);
            ProductIdLabel.TabIndex = 15;
            ProductIdLabel.Text = "ID";
            // 
            // ProductMaxLabel
            // 
            ProductMaxLabel.AutoSize = true;
            ProductMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductMaxLabel.Location = new Point(221, 360);
            ProductMaxLabel.Name = "ProductMaxLabel";
            ProductMaxLabel.Size = new Size(58, 31);
            ProductMaxLabel.TabIndex = 12;
            ProductMaxLabel.Text = "Max";
            // 
            // ProductMaxInput
            // 
            ProductMaxInput.BackColor = Color.Gainsboro;
            ProductMaxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductMaxInput.Location = new Point(299, 359);
            ProductMaxInput.Name = "ProductMaxInput";
            ProductMaxInput.Size = new Size(91, 34);
            ProductMaxInput.TabIndex = 11;
            // 
            // ProductMinLabel
            // 
            ProductMinLabel.AutoSize = true;
            ProductMinLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductMinLabel.Location = new Point(6, 360);
            ProductMinLabel.Name = "ProductMinLabel";
            ProductMinLabel.Size = new Size(54, 31);
            ProductMinLabel.TabIndex = 10;
            ProductMinLabel.Text = "Min";
            // 
            // ProductMinInput
            // 
            ProductMinInput.BackColor = Color.Gainsboro;
            ProductMinInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductMinInput.Location = new Point(81, 357);
            ProductMinInput.Name = "ProductMinInput";
            ProductMinInput.Size = new Size(91, 34);
            ProductMinInput.TabIndex = 9;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPriceLabel.Location = new Point(6, 271);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(118, 31);
            ProductPriceLabel.TabIndex = 8;
            ProductPriceLabel.Text = "Price/Cost";
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.BackColor = Color.Gainsboro;
            ProductPriceInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductPriceInput.Location = new Point(139, 263);
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(269, 34);
            ProductPriceInput.TabIndex = 7;
            // 
            // ProductInventoryLabel
            // 
            ProductInventoryLabel.AutoSize = true;
            ProductInventoryLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductInventoryLabel.Location = new Point(6, 192);
            ProductInventoryLabel.Name = "ProductInventoryLabel";
            ProductInventoryLabel.Size = new Size(109, 31);
            ProductInventoryLabel.TabIndex = 6;
            ProductInventoryLabel.Text = "Inventory";
            // 
            // ProductInventoryInput
            // 
            ProductInventoryInput.BackColor = Color.Gainsboro;
            ProductInventoryInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductInventoryInput.Location = new Point(139, 184);
            ProductInventoryInput.Name = "ProductInventoryInput";
            ProductInventoryInput.Size = new Size(269, 34);
            ProductInventoryInput.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameLabel.Location = new Point(6, 115);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(75, 31);
            ProductNameLabel.TabIndex = 4;
            ProductNameLabel.Text = "Name";
            // 
            // ProductNameInput
            // 
            ProductNameInput.BackColor = Color.Gainsboro;
            ProductNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductNameInput.Location = new Point(139, 107);
            ProductNameInput.Name = "ProductNameInput";
            ProductNameInput.Size = new Size(269, 34);
            ProductNameInput.TabIndex = 3;
            // 
            // AddPartPanel
            // 
            AddPartPanel.Controls.Add(ProductContainer);
            AddPartPanel.Controls.Add(ProductsBttBox);
            AddPartPanel.Location = new Point(11, 100);
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
            ProductContainer.Controls.Add(ProductId);
            ProductContainer.Controls.Add(ProductIdLabel);
            ProductContainer.Controls.Add(ProductMaxLabel);
            ProductContainer.Controls.Add(ProductMaxInput);
            ProductContainer.Controls.Add(ProductMinLabel);
            ProductContainer.Controls.Add(ProductMinInput);
            ProductContainer.Controls.Add(ProductPriceLabel);
            ProductContainer.Controls.Add(ProductPriceInput);
            ProductContainer.Controls.Add(ProductInventoryLabel);
            ProductContainer.Controls.Add(ProductInventoryInput);
            ProductContainer.Controls.Add(ProductNameLabel);
            ProductContainer.Controls.Add(ProductNameInput);
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
            DeletePart.Location = new Point(1247, 467);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(94, 29);
            DeletePart.TabIndex = 24;
            DeletePart.Text = "Delete";
            DeletePart.UseVisualStyleBackColor = false;
            DeletePart.Click += DeletePart_Click;
            // 
            // SelectedParts
            // 
            SelectedParts.AllowUserToAddRows = false;
            SelectedParts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SelectedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SelectedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SelectedParts.DefaultCellStyle = dataGridViewCellStyle2;
            SelectedParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            SelectedParts.Location = new Point(536, 297);
            SelectedParts.Name = "SelectedParts";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SelectedParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            AllParts.DataSource = outsourcedPartBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            AllParts.DefaultCellStyle = dataGridViewCellStyle5;
            AllParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            AllParts.Location = new Point(536, 85);
            AllParts.Name = "AllParts";
            AllParts.RowHeadersWidth = 51;
            AllParts.Size = new Size(805, 155);
            AllParts.TabIndex = 20;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "ID";
            partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            partIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 390;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.Width = 75;
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.MinimumWidth = 6;
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            minDataGridViewTextBoxColumn.Width = 40;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            maxDataGridViewTextBoxColumn.Width = 45;
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
            SearchBoxInput.Location = new Point(1070, 27);
            SearchBoxInput.Name = "SearchBoxInput";
            SearchBoxInput.Size = new Size(271, 34);
            SearchBoxInput.TabIndex = 18;
            SearchBoxInput.TextChanged += SearchBoxInput_TextChanged;
            // 
            // SearchBtt
            // 
            SearchBtt.BackColor = SystemColors.ActiveBorder;
            SearchBtt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtt.Location = new Point(952, 31);
            SearchBtt.Name = "SearchBtt";
            SearchBtt.Size = new Size(94, 35);
            SearchBtt.TabIndex = 17;
            SearchBtt.Text = "Search";
            SearchBtt.UseVisualStyleBackColor = false;
            SearchBtt.Click += SearchBtt_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(11, 32);
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
        private TextBox ProductId;
        private Label ProductIdLabel;
        private Label ProductMaxLabel;
        private TextBox ProductMaxInput;
        private Label ProductMinLabel;
        private TextBox ProductMinInput;
        private Label ProductPriceLabel;
        private TextBox ProductPriceInput;
        private Label ProductInventoryLabel;
        private TextBox ProductInventoryInput;
        private Label ProductNameLabel;
        private TextBox ProductNameInput;
        private FlowLayoutPanel AddPartPanel;
        private GroupBox ProductContainer;
        private Label Title;
        private TextBox CandidatePartsLabel;
        private TextBox SearchBoxInput;
        private Button SearchBtt;
        private DataGridView AllParts;
        private BindingSource outsourcedPartBindingSource;
        private BindingSource inHousePartBindingSource;
        private Button AddPart;
        private TextBox AddedPartsLabel;
        private DataGridView SelectedParts;
        private Button DeletePart;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
    }
}