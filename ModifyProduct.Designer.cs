namespace InventoryMgmt
{
    partial class ModifyProduct
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
            inHousePartBindingSource = new BindingSource(components);
            CandidatePartsLabel = new TextBox();
            SearchBoxInput = new TextBox();
            outsourcedPartBindingSource = new BindingSource(components);
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
            ProductContainer = new GroupBox();
            SearchBtt = new Button();
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
            ProductsBttBox = new GroupBox();
            ProductCancel = new Button();
            ProductSave = new Button();
            Title = new Label();
            ((System.ComponentModel.ISupportInitialize)inHousePartBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedPartBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllParts).BeginInit();
            ProductContainer.SuspendLayout();
            AddPartPanel.SuspendLayout();
            ProductsBttBox.SuspendLayout();
            SuspendLayout();
            // 
            // CandidatePartsLabel
            // 
            CandidatePartsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CandidatePartsLabel.Location = new Point(536, 54);
            CandidatePartsLabel.Margin = new Padding(3, 2, 3, 2);
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
            SearchBoxInput.Margin = new Padding(3, 2, 3, 2);
            SearchBoxInput.Name = "SearchBoxInput";
            SearchBoxInput.Size = new Size(271, 34);
            SearchBoxInput.TabIndex = 18;
            SearchBoxInput.TextChanged += SearchBoxInput_TextChanged;
            // 
            // outsourcedPartBindingSource
            // 
            outsourcedPartBindingSource.DataSource = typeof(OutsourcedPart);
            // 
            // DeletePart
            // 
            DeletePart.BackColor = SystemColors.ActiveBorder;
            DeletePart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeletePart.Location = new Point(1247, 466);
            DeletePart.Margin = new Padding(3, 2, 3, 2);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(94, 30);
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
            SelectedParts.Location = new Point(536, 298);
            SelectedParts.Margin = new Padding(3, 2, 3, 2);
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
            SelectedParts.Size = new Size(805, 154);
            SelectedParts.TabIndex = 23;
            // 
            // AddedPartsLabel
            // 
            AddedPartsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddedPartsLabel.Location = new Point(536, 264);
            AddedPartsLabel.Margin = new Padding(3, 2, 3, 2);
            AddedPartsLabel.Name = "AddedPartsLabel";
            AddedPartsLabel.Size = new Size(229, 27);
            AddedPartsLabel.TabIndex = 22;
            AddedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AddPart
            // 
            AddPart.BackColor = SystemColors.ActiveBorder;
            AddPart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPart.Location = new Point(1247, 246);
            AddPart.Margin = new Padding(3, 2, 3, 2);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(94, 30);
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
            AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            AllParts.DataSource = outsourcedPartBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            AllParts.DefaultCellStyle = dataGridViewCellStyle4;
            AllParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            AllParts.Location = new Point(536, 86);
            AllParts.Margin = new Padding(3, 2, 3, 2);
            AllParts.Name = "AllParts";
            AllParts.RowHeadersWidth = 51;
            AllParts.Size = new Size(805, 154);
            AllParts.TabIndex = 20;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "ID";
            partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            partIDDataGridViewTextBoxColumn.Width = 50;
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
            priceDataGridViewTextBoxColumn.Width = 75;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.Width = 95;
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.MinimumWidth = 6;
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            minDataGridViewTextBoxColumn.Width = 75;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            maxDataGridViewTextBoxColumn.Width = 75;
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
            ProductContainer.Size = new Size(1398, 502);
            ProductContainer.TabIndex = 0;
            ProductContainer.TabStop = false;
            ProductContainer.Text = "Modify Product";
            // 
            // SearchBtt
            // 
            SearchBtt.BackColor = SystemColors.ActiveBorder;
            SearchBtt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtt.Location = new Point(952, 30);
            SearchBtt.Margin = new Padding(3, 2, 3, 2);
            SearchBtt.Name = "SearchBtt";
            SearchBtt.Size = new Size(94, 34);
            SearchBtt.TabIndex = 17;
            SearchBtt.Text = "Search";
            SearchBtt.UseVisualStyleBackColor = false;
            SearchBtt.Click += SearchBtt_Click;
            // 
            // ProductId
            // 
            ProductId.BackColor = SystemColors.ActiveCaption;
            ProductId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductId.Location = new Point(139, 54);
            ProductId.Margin = new Padding(3, 2, 3, 2);
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Size = new Size(125, 34);
            ProductId.TabIndex = 16;
            // 
            // ProductIdLabel
            // 
            ProductIdLabel.AutoSize = true;
            ProductIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductIdLabel.Location = new Point(6, 54);
            ProductIdLabel.Name = "ProductIdLabel";
            ProductIdLabel.Size = new Size(44, 38);
            ProductIdLabel.TabIndex = 15;
            ProductIdLabel.Text = "ID";
            // 
            // ProductMaxLabel
            // 
            ProductMaxLabel.AutoSize = true;
            ProductMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductMaxLabel.Location = new Point(222, 360);
            ProductMaxLabel.Name = "ProductMaxLabel";
            ProductMaxLabel.Size = new Size(58, 31);
            ProductMaxLabel.TabIndex = 12;
            ProductMaxLabel.Text = "Max";
            // 
            // ProductMaxInput
            // 
            ProductMaxInput.BackColor = Color.Gainsboro;
            ProductMaxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductMaxInput.Location = new Point(299, 358);
            ProductMaxInput.Margin = new Padding(3, 2, 3, 2);
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
            ProductMinInput.Location = new Point(81, 358);
            ProductMinInput.Margin = new Padding(3, 2, 3, 2);
            ProductMinInput.Name = "ProductMinInput";
            ProductMinInput.Size = new Size(91, 34);
            ProductMinInput.TabIndex = 9;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPriceLabel.Location = new Point(6, 270);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(118, 31);
            ProductPriceLabel.TabIndex = 8;
            ProductPriceLabel.Text = "Price/Cost";
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.BackColor = Color.Gainsboro;
            ProductPriceInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductPriceInput.Location = new Point(139, 262);
            ProductPriceInput.Margin = new Padding(3, 2, 3, 2);
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
            ProductInventoryInput.Margin = new Padding(3, 2, 3, 2);
            ProductInventoryInput.Name = "ProductInventoryInput";
            ProductInventoryInput.Size = new Size(269, 34);
            ProductInventoryInput.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameLabel.Location = new Point(6, 114);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(75, 31);
            ProductNameLabel.TabIndex = 4;
            ProductNameLabel.Text = "Name";
            // 
            // ProductNameInput
            // 
            ProductNameInput.BackColor = Color.Gainsboro;
            ProductNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ProductNameInput.Location = new Point(139, 106);
            ProductNameInput.Margin = new Padding(3, 2, 3, 2);
            ProductNameInput.Name = "ProductNameInput";
            ProductNameInput.Size = new Size(269, 34);
            ProductNameInput.TabIndex = 3;
            // 
            // AddPartPanel
            // 
            AddPartPanel.Controls.Add(ProductContainer);
            AddPartPanel.Controls.Add(ProductsBttBox);
            AddPartPanel.Location = new Point(12, 100);
            AddPartPanel.Margin = new Padding(3, 2, 3, 2);
            AddPartPanel.Name = "AddPartPanel";
            AddPartPanel.Size = new Size(1401, 598);
            AddPartPanel.TabIndex = 9;
            // 
            // ProductsBttBox
            // 
            ProductsBttBox.Controls.Add(ProductCancel);
            ProductsBttBox.Controls.Add(ProductSave);
            ProductsBttBox.Location = new Point(2, 508);
            ProductsBttBox.Margin = new Padding(2);
            ProductsBttBox.Name = "ProductsBttBox";
            ProductsBttBox.Padding = new Padding(2);
            ProductsBttBox.Size = new Size(1399, 86);
            ProductsBttBox.TabIndex = 3;
            ProductsBttBox.TabStop = false;
            // 
            // ProductCancel
            // 
            ProductCancel.BackColor = Color.IndianRed;
            ProductCancel.Location = new Point(869, 36);
            ProductCancel.Margin = new Padding(2);
            ProductCancel.Name = "ProductCancel";
            ProductCancel.Size = new Size(69, 34);
            ProductCancel.TabIndex = 1;
            ProductCancel.Text = "Cancel";
            ProductCancel.UseVisualStyleBackColor = false;
            ProductCancel.Click += ProductCancel_Click;
            // 
            // ProductSave
            // 
            ProductSave.BackColor = Color.DarkSeaGreen;
            ProductSave.Location = new Point(561, 36);
            ProductSave.Margin = new Padding(2);
            ProductSave.Name = "ProductSave";
            ProductSave.Size = new Size(69, 34);
            ProductSave.TabIndex = 0;
            ProductSave.Text = "Save";
            ProductSave.UseVisualStyleBackColor = false;
            ProductSave.Click += ProductSave_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(12, 32);
            Title.Name = "Title";
            Title.Size = new Size(519, 46);
            Title.TabIndex = 8;
            Title.Text = "Inventory Management System";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 730);
            Controls.Add(AddPartPanel);
            Controls.Add(Title);
            Margin = new Padding(2);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)inHousePartBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedPartBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllParts).EndInit();
            ProductContainer.ResumeLayout(false);
            ProductContainer.PerformLayout();
            AddPartPanel.ResumeLayout(false);
            ProductsBttBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource inHousePartBindingSource;
        private TextBox CandidatePartsLabel;
        private TextBox SearchBoxInput;
        private BindingSource outsourcedPartBindingSource;
        private Button DeletePart;
        private DataGridView SelectedParts;
        private TextBox AddedPartsLabel;
        private Button AddPart;
        private DataGridView AllParts;
        private GroupBox ProductContainer;
        private Button SearchBtt;
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
        private GroupBox ProductsBttBox;
        private Button ProductCancel;
        private Button ProductSave;
        private Label Title;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
    }
}