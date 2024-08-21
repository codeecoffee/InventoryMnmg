namespace InventoryMgmt
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
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PartsBox = new GroupBox();
            PartsSearchInput = new TextBox();
            PartsSearchBtt = new Button();
            dataGridView1 = new DataGridView();
            ProductsBox = new GroupBox();
            ProductsSearchInput = new TextBox();
            dataGridView2 = new DataGridView();
            ProductsSearchBtt = new Button();
            PartsBttBox = new GroupBox();
            PartDelete = new Button();
            PartModify = new Button();
            PartAdd = new Button();
            ProductsBttBox = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            MainScreenPanel = new FlowLayoutPanel();
            splitContainer1 = new SplitContainer();
            PartsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ProductsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            PartsBttBox.SuspendLayout();
            ProductsBttBox.SuspendLayout();
            MainScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
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
            label2.Click += label2_Click;
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
            PartsBox.Controls.Add(PartsSearchInput);
            PartsBox.Controls.Add(PartsSearchBtt);
            PartsBox.Controls.Add(dataGridView1);
            PartsBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PartsBox.Location = new Point(3, 3);
            PartsBox.Name = "PartsBox";
            PartsBox.Size = new Size(599, 454);
            PartsBox.TabIndex = 0;
            PartsBox.TabStop = false;
            PartsBox.Text = "Parts";
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
            PartsSearchBtt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartsSearchBtt.Location = new Point(256, 42);
            PartsSearchBtt.Name = "PartsSearchBtt";
            PartsSearchBtt.Size = new Size(94, 43);
            PartsSearchBtt.TabIndex = 1;
            PartsSearchBtt.Text = "Search";
            PartsSearchBtt.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(587, 354);
            dataGridView1.TabIndex = 0;
            // 
            // ProductsBox
            // 
            ProductsBox.Controls.Add(ProductsSearchInput);
            ProductsBox.Controls.Add(dataGridView2);
            ProductsBox.Controls.Add(ProductsSearchBtt);
            ProductsBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProductsBox.Location = new Point(608, 3);
            ProductsBox.Name = "ProductsBox";
            ProductsBox.Size = new Size(781, 454);
            ProductsBox.TabIndex = 1;
            ProductsBox.TabStop = false;
            ProductsBox.Text = "Products";
            ProductsBox.Enter += groupBox2_Enter;
            // 
            // ProductsSearchInput
            // 
            ProductsSearchInput.Location = new Point(567, 42);
            ProductsSearchInput.Name = "ProductsSearchInput";
            ProductsSearchInput.Size = new Size(205, 43);
            ProductsSearchInput.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(762, 354);
            dataGridView2.TabIndex = 1;
            // 
            // ProductsSearchBtt
            // 
            ProductsSearchBtt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductsSearchBtt.Location = new Point(451, 42);
            ProductsSearchBtt.Name = "ProductsSearchBtt";
            ProductsSearchBtt.Size = new Size(94, 43);
            ProductsSearchBtt.TabIndex = 3;
            ProductsSearchBtt.Text = "Search";
            ProductsSearchBtt.UseVisualStyleBackColor = true;
            // 
            // PartsBttBox
            // 
            PartsBttBox.Controls.Add(PartDelete);
            PartsBttBox.Controls.Add(PartModify);
            PartsBttBox.Controls.Add(PartAdd);
            PartsBttBox.Location = new Point(2, 462);
            PartsBttBox.Margin = new Padding(2);
            PartsBttBox.Name = "PartsBttBox";
            PartsBttBox.Padding = new Padding(2);
            PartsBttBox.Size = new Size(318, 56);
            PartsBttBox.TabIndex = 2;
            PartsBttBox.TabStop = false;
            PartsBttBox.Enter += PartsBttBox_Enter;
            // 
            // PartDelete
            // 
            PartDelete.Location = new Point(204, 16);
            PartDelete.Margin = new Padding(2);
            PartDelete.Name = "PartDelete";
            PartDelete.Size = new Size(68, 33);
            PartDelete.TabIndex = 2;
            PartDelete.Text = "Delete";
            PartDelete.UseVisualStyleBackColor = true;
            // 
            // PartModify
            // 
            PartModify.Location = new Point(110, 16);
            PartModify.Margin = new Padding(2);
            PartModify.Name = "PartModify";
            PartModify.Size = new Size(68, 33);
            PartModify.TabIndex = 1;
            PartModify.Text = "Modify";
            PartModify.UseVisualStyleBackColor = true;
            // 
            // PartAdd
            // 
            PartAdd.Location = new Point(25, 16);
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
            ProductsBttBox.Controls.Add(button1);
            ProductsBttBox.Controls.Add(button2);
            ProductsBttBox.Controls.Add(button3);
            ProductsBttBox.Location = new Point(1092, 462);
            ProductsBttBox.Margin = new Padding(2);
            ProductsBttBox.Name = "ProductsBttBox";
            ProductsBttBox.Padding = new Padding(2);
            ProductsBttBox.Size = new Size(294, 56);
            ProductsBttBox.TabIndex = 3;
            ProductsBttBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(202, 16);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(68, 33);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(110, 16);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(68, 33);
            button2.TabIndex = 1;
            button2.Text = "Modify";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(25, 16);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(68, 33);
            button3.TabIndex = 0;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainScreenPanel
            // 
            MainScreenPanel.Controls.Add(PartsBox);
            MainScreenPanel.Controls.Add(ProductsBox);
            MainScreenPanel.Controls.Add(PartsBttBox);
            MainScreenPanel.Controls.Add(splitContainer1);
            MainScreenPanel.Controls.Add(ProductsBttBox);
            MainScreenPanel.Location = new Point(12, 106);
            MainScreenPanel.Name = "MainScreenPanel";
            MainScreenPanel.Size = new Size(1401, 598);
            MainScreenPanel.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(323, 461);
            splitContainer1.Margin = new Padding(1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(766, 43);
            splitContainer1.SplitterDistance = 254;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ProductsBox.ResumeLayout(false);
            ProductsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            PartsBttBox.ResumeLayout(false);
            ProductsBttBox.ResumeLayout(false);
            MainScreenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel MainScreenPanel;
        private SplitContainer splitContainer1;
        private Button PartsSearchBtt;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox PartsSearchInput;
        private TextBox ProductsSearchInput;
        private Button ProductsSearchBtt;
    }
}
