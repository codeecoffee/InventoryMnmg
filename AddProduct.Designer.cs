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
            SelectedParts = new DataGridView();
            AddedPartsLabel = new TextBox();
            AddPart = new Button();
            dataGridView1 = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outsourcedPartBindingSource = new BindingSource(components);
            CandidatePartsLabel = new TextBox();
            textBox1 = new TextBox();
            SearchBtt = new Button();
            Title = new Label();
            inHousePartBindingSource = new BindingSource(components);
            ProductsBttBox.SuspendLayout();
            AddPartPanel.SuspendLayout();
            ProductContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SelectedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            ProductContainer.Controls.Add(SelectedParts);
            ProductContainer.Controls.Add(AddedPartsLabel);
            ProductContainer.Controls.Add(AddPart);
            ProductContainer.Controls.Add(dataGridView1);
            ProductContainer.Controls.Add(CandidatePartsLabel);
            ProductContainer.Controls.Add(textBox1);
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
            // SelectedParts
            // 
            SelectedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectedParts.Location = new Point(536, 297);
            SelectedParts.Name = "SelectedParts";
            SelectedParts.RowHeadersWidth = 51;
            SelectedParts.Size = new Size(805, 158);
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
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            dataGridView1.DataSource = outsourcedPartBindingSource;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(536, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 155);
            dataGridView1.TabIndex = 20;
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
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(1070, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 34);
            textBox1.TabIndex = 18;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox1;
        private Button SearchBtt;
        private DataGridView dataGridView1;
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
    }
}