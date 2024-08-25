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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            PartSave.Location = new Point(491, 27);
            PartSave.Margin = new Padding(2);
            PartSave.Name = "PartSave";
            PartSave.Size = new Size(60, 25);
            PartSave.TabIndex = 0;
            PartSave.Text = "Save";
            PartSave.UseVisualStyleBackColor = false;
            PartSave.Click += PartSave_Click;
            // 
            // ProductsBttBox
            // 
            ProductsBttBox.Controls.Add(PartCancel);
            ProductsBttBox.Controls.Add(PartSave);
            ProductsBttBox.Location = new Point(2, 382);
            ProductsBttBox.Margin = new Padding(2);
            ProductsBttBox.Name = "ProductsBttBox";
            ProductsBttBox.Padding = new Padding(2);
            ProductsBttBox.Size = new Size(1224, 65);
            ProductsBttBox.TabIndex = 3;
            ProductsBttBox.TabStop = false;
            // 
            // PartCancel
            // 
            PartCancel.BackColor = Color.IndianRed;
            PartCancel.Location = new Point(760, 27);
            PartCancel.Margin = new Padding(2);
            PartCancel.Name = "PartCancel";
            PartCancel.Size = new Size(60, 25);
            PartCancel.TabIndex = 1;
            PartCancel.Text = "Cancel";
            PartCancel.UseVisualStyleBackColor = false;
            PartCancel.Click += PartCancel_Click;
            // 
            // ProductId
            // 
            ProductId.BackColor = SystemColors.ActiveCaption;
            ProductId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductId.Location = new Point(122, 40);
            ProductId.Margin = new Padding(3, 2, 3, 2);
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Size = new Size(110, 29);
            ProductId.TabIndex = 16;
            // 
            // ProductIdLabel
            // 
            ProductIdLabel.AutoSize = true;
            ProductIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductIdLabel.Location = new Point(5, 40);
            ProductIdLabel.Name = "ProductIdLabel";
            ProductIdLabel.Size = new Size(34, 30);
            ProductIdLabel.TabIndex = 15;
            ProductIdLabel.Text = "ID";
            // 
            // ProductMaxLabel
            // 
            ProductMaxLabel.AutoSize = true;
            ProductMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductMaxLabel.Location = new Point(193, 270);
            ProductMaxLabel.Name = "ProductMaxLabel";
            ProductMaxLabel.Size = new Size(48, 25);
            ProductMaxLabel.TabIndex = 12;
            ProductMaxLabel.Text = "Max";
            // 
            // ProductMaxInput
            // 
            ProductMaxInput.BackColor = Color.Gainsboro;
            ProductMaxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductMaxInput.Location = new Point(262, 269);
            ProductMaxInput.Margin = new Padding(3, 2, 3, 2);
            ProductMaxInput.Name = "ProductMaxInput";
            ProductMaxInput.Size = new Size(80, 29);
            ProductMaxInput.TabIndex = 11;
            // 
            // ProductMinLabel
            // 
            ProductMinLabel.AutoSize = true;
            ProductMinLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductMinLabel.Location = new Point(5, 270);
            ProductMinLabel.Name = "ProductMinLabel";
            ProductMinLabel.Size = new Size(45, 25);
            ProductMinLabel.TabIndex = 10;
            ProductMinLabel.Text = "Min";
            // 
            // ProductMinInput
            // 
            ProductMinInput.BackColor = Color.Gainsboro;
            ProductMinInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductMinInput.Location = new Point(71, 268);
            ProductMinInput.Margin = new Padding(3, 2, 3, 2);
            ProductMinInput.Name = "ProductMinInput";
            ProductMinInput.Size = new Size(80, 29);
            ProductMinInput.TabIndex = 9;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPriceLabel.Location = new Point(5, 203);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(98, 25);
            ProductPriceLabel.TabIndex = 8;
            ProductPriceLabel.Text = "Price/Cost";
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.BackColor = Color.Gainsboro;
            ProductPriceInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductPriceInput.Location = new Point(122, 197);
            ProductPriceInput.Margin = new Padding(3, 2, 3, 2);
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(236, 29);
            ProductPriceInput.TabIndex = 7;
            // 
            // ProductInventoryLabel
            // 
            ProductInventoryLabel.AutoSize = true;
            ProductInventoryLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductInventoryLabel.Location = new Point(5, 144);
            ProductInventoryLabel.Name = "ProductInventoryLabel";
            ProductInventoryLabel.Size = new Size(91, 25);
            ProductInventoryLabel.TabIndex = 6;
            ProductInventoryLabel.Text = "Inventory";
            // 
            // ProductInventoryInput
            // 
            ProductInventoryInput.BackColor = Color.Gainsboro;
            ProductInventoryInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductInventoryInput.Location = new Point(122, 138);
            ProductInventoryInput.Margin = new Padding(3, 2, 3, 2);
            ProductInventoryInput.Name = "ProductInventoryInput";
            ProductInventoryInput.Size = new Size(236, 29);
            ProductInventoryInput.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameLabel.Location = new Point(5, 86);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(62, 25);
            ProductNameLabel.TabIndex = 4;
            ProductNameLabel.Text = "Name";
            // 
            // ProductNameInput
            // 
            ProductNameInput.BackColor = Color.Gainsboro;
            ProductNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductNameInput.Location = new Point(122, 80);
            ProductNameInput.Margin = new Padding(3, 2, 3, 2);
            ProductNameInput.Name = "ProductNameInput";
            ProductNameInput.Size = new Size(236, 29);
            ProductNameInput.TabIndex = 3;
            // 
            // AddPartPanel
            // 
            AddPartPanel.Controls.Add(ProductContainer);
            AddPartPanel.Controls.Add(ProductsBttBox);
            AddPartPanel.Location = new Point(10, 75);
            AddPartPanel.Margin = new Padding(3, 2, 3, 2);
            AddPartPanel.Name = "AddPartPanel";
            AddPartPanel.Size = new Size(1226, 448);
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
            ProductContainer.Location = new Point(3, 2);
            ProductContainer.Margin = new Padding(3, 2, 3, 2);
            ProductContainer.Name = "ProductContainer";
            ProductContainer.Padding = new Padding(3, 2, 3, 2);
            ProductContainer.Size = new Size(1223, 376);
            ProductContainer.TabIndex = 0;
            ProductContainer.TabStop = false;
            ProductContainer.Text = "Add Product";
            // 
            // DeletePart
            // 
            DeletePart.BackColor = SystemColors.ActiveBorder;
            DeletePart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeletePart.Location = new Point(1091, 350);
            DeletePart.Margin = new Padding(3, 2, 3, 2);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(82, 22);
            DeletePart.TabIndex = 24;
            DeletePart.Text = "Delete";
            DeletePart.UseVisualStyleBackColor = false;
            DeletePart.Click += DeletePart_Click;
            // 
            // SelectedParts
            // 
            SelectedParts.AllowUserToAddRows = false;
            SelectedParts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            SelectedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            SelectedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            SelectedParts.DefaultCellStyle = dataGridViewCellStyle7;
            SelectedParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            SelectedParts.Location = new Point(469, 223);
            SelectedParts.Margin = new Padding(3, 2, 3, 2);
            SelectedParts.Name = "SelectedParts";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            SelectedParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            SelectedParts.RowHeadersWidth = 51;
            SelectedParts.Size = new Size(704, 116);
            SelectedParts.TabIndex = 23;
            // 
            // AddedPartsLabel
            // 
            AddedPartsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddedPartsLabel.Location = new Point(469, 198);
            AddedPartsLabel.Margin = new Padding(3, 2, 3, 2);
            AddedPartsLabel.Name = "AddedPartsLabel";
            AddedPartsLabel.Size = new Size(201, 23);
            AddedPartsLabel.TabIndex = 22;
            AddedPartsLabel.Text = "Parts Associated with this Product";
            AddedPartsLabel.TextChanged += AddedPartsLabel_TextChanged;
            // 
            // AddPart
            // 
            AddPart.BackColor = SystemColors.ActiveBorder;
            AddPart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPart.Location = new Point(1091, 185);
            AddPart.Margin = new Padding(3, 2, 3, 2);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(82, 22);
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            AllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            AllParts.DataSource = outsourcedPartBindingSource;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            AllParts.DefaultCellStyle = dataGridViewCellStyle10;
            AllParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            AllParts.Location = new Point(469, 64);
            AllParts.Margin = new Padding(3, 2, 3, 2);
            AllParts.Name = "AllParts";
            AllParts.RowHeadersWidth = 51;
            AllParts.Size = new Size(704, 116);
            AllParts.TabIndex = 20;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
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
            CandidatePartsLabel.Location = new Point(469, 40);
            CandidatePartsLabel.Margin = new Padding(3, 2, 3, 2);
            CandidatePartsLabel.Name = "CandidatePartsLabel";
            CandidatePartsLabel.Size = new Size(121, 23);
            CandidatePartsLabel.TabIndex = 19;
            CandidatePartsLabel.Text = "All candidate Parts";
            // 
            // SearchBoxInput
            // 
            SearchBoxInput.BackColor = Color.Gainsboro;
            SearchBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            SearchBoxInput.Location = new Point(936, 20);
            SearchBoxInput.Margin = new Padding(3, 2, 3, 2);
            SearchBoxInput.Name = "SearchBoxInput";
            SearchBoxInput.Size = new Size(238, 29);
            SearchBoxInput.TabIndex = 18;
            // 
            // SearchBtt
            // 
            SearchBtt.BackColor = SystemColors.ActiveBorder;
            SearchBtt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtt.Location = new Point(833, 23);
            SearchBtt.Margin = new Padding(3, 2, 3, 2);
            SearchBtt.Name = "SearchBtt";
            SearchBtt.Size = new Size(82, 26);
            SearchBtt.TabIndex = 17;
            SearchBtt.Text = "Search";
            SearchBtt.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(10, 24);
            Title.Name = "Title";
            Title.Size = new Size(420, 37);
            Title.TabIndex = 6;
            Title.Text = "Inventory Management System";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1247, 547);
            Controls.Add(AddPartPanel);
            Controls.Add(Title);
            Margin = new Padding(3, 2, 3, 2);
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