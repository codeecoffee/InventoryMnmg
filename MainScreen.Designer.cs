﻿namespace InventoryMgmt
{
    partial class MainScreen
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PartsBox = new GroupBox();
            PartsGridView = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outsourcedPartBindingSource = new BindingSource(components);
            PartsSearchInput = new TextBox();
            PartsSearchBtt = new Button();
            ProductsBox = new GroupBox();
            ProductsSearchInput = new TextBox();
            ProductsGridView = new DataGridView();
            ProductsSearchBtt = new Button();
            PartsBttBox = new GroupBox();
            PartDelete = new Button();
            PartModify = new Button();
            PartAdd = new Button();
            ProductsBttBox = new GroupBox();
            ProductDelete = new Button();
            ProductModify = new Button();
            ProductAdd = new Button();
            MainScreenPanel = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            ExitBtt = new Button();
            inHousePartBindingSource = new BindingSource(components);
            PartsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedPartBindingSource).BeginInit();
            ProductsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGridView).BeginInit();
            PartsBttBox.SuspendLayout();
            ProductsBttBox.SuspendLayout();
            MainScreenPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inHousePartBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(519, 46);
            label2.TabIndex = 1;
            label2.Text = "Inventory Management System";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1401, 598);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // PartsBox
            // 
            PartsBox.BackColor = Color.OldLace;
            PartsBox.Controls.Add(PartsGridView);
            PartsBox.Controls.Add(PartsSearchInput);
            PartsBox.Controls.Add(PartsSearchBtt);
            PartsBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PartsBox.Location = new Point(3, 3);
            PartsBox.Name = "PartsBox";
            PartsBox.Size = new Size(599, 454);
            PartsBox.TabIndex = 0;
            PartsBox.TabStop = false;
            PartsBox.Text = "Parts";
            // 
            // PartsGridView
            // 
            PartsGridView.AllowUserToAddRows = false;
            PartsGridView.AllowUserToDeleteRows = false;
            PartsGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PartsGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PartsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsGridView.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            PartsGridView.DataSource = outsourcedPartBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PartsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            PartsGridView.EnableHeadersVisualStyles = false;
            PartsGridView.Location = new Point(4, 90);
            PartsGridView.Margin = new Padding(1);
            PartsGridView.MultiSelect = false;
            PartsGridView.Name = "PartsGridView";
            PartsGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            PartsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            PartsGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            PartsGridView.Size = new Size(599, 360);
            PartsGridView.TabIndex = 3;
            PartsGridView.CellContentClick += PartsGridView_CellContentClick;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "ID";
            partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            partIDDataGridViewTextBoxColumn.ReadOnly = true;
            partIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 230;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 75F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 75;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.FillWeight = 80F;
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.ReadOnly = true;
            inStockDataGridViewTextBoxColumn.Width = 85;
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.FillWeight = 50F;
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.MinimumWidth = 6;
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            minDataGridViewTextBoxColumn.ReadOnly = true;
            minDataGridViewTextBoxColumn.Width = 55;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.FillWeight = 50F;
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            maxDataGridViewTextBoxColumn.ReadOnly = true;
            maxDataGridViewTextBoxColumn.Width = 55;
            // 
            // outsourcedPartBindingSource
            // 
            outsourcedPartBindingSource.DataSource = typeof(OutsourcedPart);
            outsourcedPartBindingSource.CurrentChanged += outsourcedPartBindingSource_CurrentChanged;
            // 
            // PartsSearchInput
            // 
            PartsSearchInput.Location = new Point(372, 42);
            PartsSearchInput.Name = "PartsSearchInput";
            PartsSearchInput.Size = new Size(205, 43);
            PartsSearchInput.TabIndex = 2;
            // 
            // PartsSearchBtt
            // 
            PartsSearchBtt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PartsSearchBtt.Location = new Point(256, 42);
            PartsSearchBtt.Name = "PartsSearchBtt";
            PartsSearchBtt.Size = new Size(94, 43);
            PartsSearchBtt.TabIndex = 1;
            PartsSearchBtt.Text = "Search";
            PartsSearchBtt.UseVisualStyleBackColor = true;
            // 
            // ProductsBox
            // 
            ProductsBox.BackColor = Color.MistyRose;
            ProductsBox.Controls.Add(ProductsSearchInput);
            ProductsBox.Controls.Add(ProductsGridView);
            ProductsBox.Controls.Add(ProductsSearchBtt);
            ProductsBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProductsBox.Location = new Point(608, 3);
            ProductsBox.Name = "ProductsBox";
            ProductsBox.Size = new Size(781, 454);
            ProductsBox.TabIndex = 1;
            ProductsBox.TabStop = false;
            ProductsBox.Text = "Products";
            // 
            // ProductsSearchInput
            // 
            ProductsSearchInput.Location = new Point(567, 42);
            ProductsSearchInput.Name = "ProductsSearchInput";
            ProductsSearchInput.Size = new Size(205, 43);
            ProductsSearchInput.TabIndex = 4;
            // 
            // ProductsGridView
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ProductsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProductsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ProductsGridView.DefaultCellStyle = dataGridViewCellStyle6;
            ProductsGridView.Location = new Point(13, 94);
            ProductsGridView.Name = "ProductsGridView";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ProductsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ProductsGridView.RowHeadersWidth = 51;
            ProductsGridView.Size = new Size(762, 354);
            ProductsGridView.TabIndex = 1;
            // 
            // ProductsSearchBtt
            // 
            ProductsSearchBtt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductsSearchBtt.Location = new Point(451, 42);
            ProductsSearchBtt.Name = "ProductsSearchBtt";
            ProductsSearchBtt.Size = new Size(94, 43);
            ProductsSearchBtt.TabIndex = 3;
            ProductsSearchBtt.Text = "Search";
            ProductsSearchBtt.UseVisualStyleBackColor = true;
            // 
            // PartsBttBox
            // 
            PartsBttBox.BackColor = Color.OldLace;
            PartsBttBox.Controls.Add(PartDelete);
            PartsBttBox.Controls.Add(PartModify);
            PartsBttBox.Controls.Add(PartAdd);
            PartsBttBox.Location = new Point(2, 462);
            PartsBttBox.Margin = new Padding(2);
            PartsBttBox.Name = "PartsBttBox";
            PartsBttBox.Padding = new Padding(2);
            PartsBttBox.Size = new Size(600, 56);
            PartsBttBox.TabIndex = 2;
            PartsBttBox.TabStop = false;
            // 
            // PartDelete
            // 
            PartDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PartDelete.Location = new Point(449, 16);
            PartDelete.Margin = new Padding(2);
            PartDelete.Name = "PartDelete";
            PartDelete.Size = new Size(68, 33);
            PartDelete.TabIndex = 2;
            PartDelete.Text = "Delete";
            PartDelete.UseVisualStyleBackColor = true;
            PartDelete.Click += PartDelete_Click;
            // 
            // PartModify
            // 
            PartModify.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PartModify.Location = new Point(283, 19);
            PartModify.Margin = new Padding(2);
            PartModify.Name = "PartModify";
            PartModify.Size = new Size(68, 33);
            PartModify.TabIndex = 1;
            PartModify.Text = "Modify";
            PartModify.UseVisualStyleBackColor = true;
            PartModify.Click += PartModify_Click;
            // 
            // PartAdd
            // 
            PartAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PartAdd.Location = new Point(86, 16);
            PartAdd.Margin = new Padding(2);
            PartAdd.Name = "PartAdd";
            PartAdd.Size = new Size(68, 33);
            PartAdd.TabIndex = 0;
            PartAdd.Text = "Add";
            PartAdd.UseVisualStyleBackColor = true;
            PartAdd.Click += PartAdd_Click;
            // 
            // ProductsBttBox
            // 
            ProductsBttBox.BackColor = Color.MistyRose;
            ProductsBttBox.Controls.Add(ProductDelete);
            ProductsBttBox.Controls.Add(ProductModify);
            ProductsBttBox.Controls.Add(ProductAdd);
            ProductsBttBox.Location = new Point(606, 462);
            ProductsBttBox.Margin = new Padding(2);
            ProductsBttBox.Name = "ProductsBttBox";
            ProductsBttBox.Padding = new Padding(2);
            ProductsBttBox.Size = new Size(783, 56);
            ProductsBttBox.TabIndex = 3;
            ProductsBttBox.TabStop = false;
            // 
            // ProductDelete
            // 
            ProductDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductDelete.Location = new Point(612, 16);
            ProductDelete.Margin = new Padding(2);
            ProductDelete.Name = "ProductDelete";
            ProductDelete.Size = new Size(68, 33);
            ProductDelete.TabIndex = 2;
            ProductDelete.Text = "Delete";
            ProductDelete.UseVisualStyleBackColor = true;
            // 
            // ProductModify
            // 
            ProductModify.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductModify.Location = new Point(410, 16);
            ProductModify.Margin = new Padding(2);
            ProductModify.Name = "ProductModify";
            ProductModify.Size = new Size(68, 33);
            ProductModify.TabIndex = 1;
            ProductModify.Text = "Modify";
            ProductModify.UseVisualStyleBackColor = true;
            // 
            // ProductAdd
            // 
            ProductAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductAdd.Location = new Point(191, 16);
            ProductAdd.Margin = new Padding(2);
            ProductAdd.Name = "ProductAdd";
            ProductAdd.Size = new Size(68, 33);
            ProductAdd.TabIndex = 0;
            ProductAdd.Text = "Add";
            ProductAdd.UseVisualStyleBackColor = true;
            ProductAdd.Click += ProductAdd_Click;
            // 
            // MainScreenPanel
            // 
            MainScreenPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainScreenPanel.Controls.Add(PartsBox);
            MainScreenPanel.Controls.Add(ProductsBox);
            MainScreenPanel.Controls.Add(PartsBttBox);
            MainScreenPanel.Controls.Add(ProductsBttBox);
            MainScreenPanel.Controls.Add(groupBox1);
            MainScreenPanel.Location = new Point(12, 106);
            MainScreenPanel.Name = "MainScreenPanel";
            MainScreenPanel.Size = new Size(1401, 598);
            MainScreenPanel.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(ExitBtt);
            groupBox1.Location = new Point(2, 522);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1399, 76);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // ExitBtt
            // 
            ExitBtt.BackColor = Color.Tomato;
            ExitBtt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtt.Location = new Point(1319, 24);
            ExitBtt.Margin = new Padding(2);
            ExitBtt.Name = "ExitBtt";
            ExitBtt.Size = new Size(68, 33);
            ExitBtt.TabIndex = 2;
            ExitBtt.Text = "Exit";
            ExitBtt.UseVisualStyleBackColor = false;
            ExitBtt.Click += ExitBtt_Click;
            // 
            // inHousePartBindingSource
            // 
            inHousePartBindingSource.DataSource = typeof(InHousePart);
            inHousePartBindingSource.Sort = "ID";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 729);
            Controls.Add(MainScreenPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainScreen";
            Text = "Main Screen";
            PartsBox.ResumeLayout(false);
            PartsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PartsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedPartBindingSource).EndInit();
            ProductsBox.ResumeLayout(false);
            ProductsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGridView).EndInit();
            PartsBttBox.ResumeLayout(false);
            ProductsBttBox.ResumeLayout(false);
            MainScreenPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inHousePartBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox PartsBox;
        private GroupBox ProductsBox;
        private GroupBox PartsBttBox;
        private Button PartDelete;
        private Button PartModify;
        private Button PartAdd;
        private GroupBox ProductsBttBox;
        private Button ProductDelete;
        private Button ProductModify;
        private Button ProductAdd;
        private FlowLayoutPanel MainScreenPanel;
        private Button PartsSearchBtt;
        private DataGridView ProductsGridView;
        private TextBox PartsSearchInput;
        private TextBox ProductsSearchInput;
        private Button ProductsSearchBtt;
        private GroupBox groupBox1;
        private Button ExitBtt;
        private DataGridView PartsGridView;
        private BindingSource outsourcedPartBindingSource;
        private BindingSource inHousePartBindingSource;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
    }
}
