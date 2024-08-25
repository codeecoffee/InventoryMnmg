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
            outsourcedPartBindingSource = new BindingSource(components);
            CandidatePartsLabel = new TextBox();
            SearchBoxInput = new TextBox();
            SearchBtt = new Button();
            Title = new Label();
            inHousePartBindingSource = new BindingSource(components);
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            // PartId
            // 
            PartId.BackColor = SystemColors.ActiveCaption;
            PartId.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartId.Location = new Point(122, 40);
            PartId.Margin = new Padding(3, 2, 3, 2);
            PartId.Name = "PartId";
            PartId.ReadOnly = true;
            PartId.Size = new Size(110, 29);
            PartId.TabIndex = 16;
            // 
            // PartIdLabel
            // 
            PartIdLabel.AutoSize = true;
            PartIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartIdLabel.Location = new Point(5, 40);
            PartIdLabel.Name = "PartIdLabel";
            PartIdLabel.Size = new Size(34, 30);
            PartIdLabel.TabIndex = 15;
            PartIdLabel.Text = "ID";
            // 
            // PartMaxLabel
            // 
            PartMaxLabel.AutoSize = true;
            PartMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMaxLabel.Location = new Point(193, 270);
            PartMaxLabel.Name = "PartMaxLabel";
            PartMaxLabel.Size = new Size(48, 25);
            PartMaxLabel.TabIndex = 12;
            PartMaxLabel.Text = "Max";
            // 
            // PartMaxInput
            // 
            PartMaxInput.BackColor = Color.Gainsboro;
            PartMaxInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartMaxInput.Location = new Point(262, 269);
            PartMaxInput.Margin = new Padding(3, 2, 3, 2);
            PartMaxInput.Name = "PartMaxInput";
            PartMaxInput.Size = new Size(80, 29);
            PartMaxInput.TabIndex = 11;
            // 
            // PartMinLabel
            // 
            PartMinLabel.AutoSize = true;
            PartMinLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMinLabel.Location = new Point(5, 270);
            PartMinLabel.Name = "PartMinLabel";
            PartMinLabel.Size = new Size(45, 25);
            PartMinLabel.TabIndex = 10;
            PartMinLabel.Text = "Min";
            // 
            // PartMinInput
            // 
            PartMinInput.BackColor = Color.Gainsboro;
            PartMinInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartMinInput.Location = new Point(71, 268);
            PartMinInput.Margin = new Padding(3, 2, 3, 2);
            PartMinInput.Name = "PartMinInput";
            PartMinInput.Size = new Size(80, 29);
            PartMinInput.TabIndex = 9;
            // 
            // PartPriceLabel
            // 
            PartPriceLabel.AutoSize = true;
            PartPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartPriceLabel.Location = new Point(5, 203);
            PartPriceLabel.Name = "PartPriceLabel";
            PartPriceLabel.Size = new Size(98, 25);
            PartPriceLabel.TabIndex = 8;
            PartPriceLabel.Text = "Price/Cost";
            // 
            // PartPriceInput
            // 
            PartPriceInput.BackColor = Color.Gainsboro;
            PartPriceInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartPriceInput.Location = new Point(122, 197);
            PartPriceInput.Margin = new Padding(3, 2, 3, 2);
            PartPriceInput.Name = "PartPriceInput";
            PartPriceInput.Size = new Size(236, 29);
            PartPriceInput.TabIndex = 7;
            // 
            // PartInventoryLabel
            // 
            PartInventoryLabel.AutoSize = true;
            PartInventoryLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartInventoryLabel.Location = new Point(5, 144);
            PartInventoryLabel.Name = "PartInventoryLabel";
            PartInventoryLabel.Size = new Size(91, 25);
            PartInventoryLabel.TabIndex = 6;
            PartInventoryLabel.Text = "Inventory";
            // 
            // PartInventoryInput
            // 
            PartInventoryInput.BackColor = Color.Gainsboro;
            PartInventoryInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartInventoryInput.Location = new Point(122, 138);
            PartInventoryInput.Margin = new Padding(3, 2, 3, 2);
            PartInventoryInput.Name = "PartInventoryInput";
            PartInventoryInput.Size = new Size(236, 29);
            PartInventoryInput.TabIndex = 5;
            // 
            // PartNameLabel
            // 
            PartNameLabel.AutoSize = true;
            PartNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartNameLabel.Location = new Point(5, 86);
            PartNameLabel.Name = "PartNameLabel";
            PartNameLabel.Size = new Size(62, 25);
            PartNameLabel.TabIndex = 4;
            PartNameLabel.Text = "Name";
            // 
            // PartNameInput
            // 
            PartNameInput.BackColor = Color.Gainsboro;
            PartNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            PartNameInput.Location = new Point(122, 80);
            PartNameInput.Margin = new Padding(3, 2, 3, 2);
            PartNameInput.Name = "PartNameInput";
            PartNameInput.Size = new Size(236, 29);
            PartNameInput.TabIndex = 3;
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
            SelectedParts.Location = new Point(469, 223);
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
            AllParts.Location = new Point(469, 64);
            AllParts.Margin = new Padding(3, 2, 3, 2);
            AllParts.Name = "AllParts";
            AllParts.RowHeadersWidth = 51;
            AllParts.Size = new Size(704, 116);
            AllParts.TabIndex = 20;
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
            SearchBtt.Size = new Size(82, 22);
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