
namespace InventoryMgmt
{
    partial class AddPartForm
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
            Title = new Label();
            AddPartPanel = new FlowLayoutPanel();
            PartBox = new GroupBox();
            PartId = new TextBox();
            PartIdLabel = new Label();
            PartMachineOrCompanyLabel = new Label();
            PartMachineIdOrCompanyInput = new TextBox();
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
            PartOutsourced = new RadioButton();
            PartInhouse = new RadioButton();
            ProductsBttBox = new GroupBox();
            PartCancel = new Button();
            PartSave = new Button();
            AddPartPanel.SuspendLayout();
            PartBox.SuspendLayout();
            ProductsBttBox.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(11, 41);
            Title.Name = "Title";
            Title.Size = new Size(519, 46);
            Title.TabIndex = 2;
            Title.Text = "Inventory Management System";
            // 
            // AddPartPanel
            // 
            AddPartPanel.Controls.Add(PartBox);
            AddPartPanel.Controls.Add(ProductsBttBox);
            AddPartPanel.Location = new Point(11, 109);
            AddPartPanel.Name = "AddPartPanel";
            AddPartPanel.Size = new Size(1401, 597);
            AddPartPanel.TabIndex = 5;
            // 
            // PartBox
            // 
            PartBox.Controls.Add(PartId);
            PartBox.Controls.Add(PartIdLabel);
            PartBox.Controls.Add(PartMachineOrCompanyLabel);
            PartBox.Controls.Add(PartMachineIdOrCompanyInput);
            PartBox.Controls.Add(PartMaxLabel);
            PartBox.Controls.Add(PartMaxInput);
            PartBox.Controls.Add(PartMinLabel);
            PartBox.Controls.Add(PartMinInput);
            PartBox.Controls.Add(PartPriceLabel);
            PartBox.Controls.Add(PartPriceInput);
            PartBox.Controls.Add(PartInventoryLabel);
            PartBox.Controls.Add(PartInventoryInput);
            PartBox.Controls.Add(PartNameLabel);
            PartBox.Controls.Add(PartNameInput);
            PartBox.Controls.Add(PartOutsourced);
            PartBox.Controls.Add(PartInhouse);
            PartBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PartBox.Location = new Point(3, 3);
            PartBox.Name = "PartBox";
            PartBox.Size = new Size(1398, 501);
            PartBox.TabIndex = 0;
            PartBox.TabStop = false;
            PartBox.Text = "Add Part";
            // 
            // PartId
            // 
            PartId.Location = new Point(139, 53);
            PartId.Name = "PartId";
            PartId.ReadOnly = true;
            PartId.Size = new Size(125, 43);
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
            // PartMachineOrCompanyLabel
            // 
            PartMachineOrCompanyLabel.AutoSize = true;
            PartMachineOrCompanyLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMachineOrCompanyLabel.Location = new Point(6, 436);
            PartMachineOrCompanyLabel.Name = "PartMachineOrCompanyLabel";
            PartMachineOrCompanyLabel.Size = new Size(128, 31);
            PartMachineOrCompanyLabel.TabIndex = 14;
            PartMachineOrCompanyLabel.Text = "Machine Id";
            // 
            // PartMachineIdOrCompanyInput
            // 
            PartMachineIdOrCompanyInput.Location = new Point(139, 428);
            PartMachineIdOrCompanyInput.Name = "PartMachineIdOrCompanyInput";
            PartMachineIdOrCompanyInput.Size = new Size(548, 43);
            PartMachineIdOrCompanyInput.TabIndex = 13;
            // 
            // PartMaxLabel
            // 
            PartMaxLabel.AutoSize = true;
            PartMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMaxLabel.Location = new Point(462, 360);
            PartMaxLabel.Name = "PartMaxLabel";
            PartMaxLabel.Size = new Size(58, 31);
            PartMaxLabel.TabIndex = 12;
            PartMaxLabel.Text = "Max";
            // 
            // PartMaxInput
            // 
            PartMaxInput.Location = new Point(597, 352);
            PartMaxInput.Name = "PartMaxInput";
            PartMaxInput.Size = new Size(91, 43);
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
            PartMinInput.Location = new Point(139, 352);
            PartMinInput.Name = "PartMinInput";
            PartMinInput.Size = new Size(91, 43);
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
            PartPriceInput.Location = new Point(139, 263);
            PartPriceInput.Name = "PartPriceInput";
            PartPriceInput.Size = new Size(548, 43);
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
            PartInventoryInput.Location = new Point(139, 184);
            PartInventoryInput.Name = "PartInventoryInput";
            PartInventoryInput.Size = new Size(548, 43);
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
            PartNameInput.Location = new Point(139, 107);
            PartNameInput.Name = "PartNameInput";
            PartNameInput.Size = new Size(548, 43);
            PartNameInput.TabIndex = 3;
            // 
            // PartOutsourced
            // 
            PartOutsourced.AutoSize = true;
            PartOutsourced.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PartOutsourced.Location = new Point(522, 21);
            PartOutsourced.Name = "PartOutsourced";
            PartOutsourced.Size = new Size(139, 32);
            PartOutsourced.TabIndex = 2;
            PartOutsourced.TabStop = true;
            PartOutsourced.Text = "Outsourced";
            PartOutsourced.UseVisualStyleBackColor = true;
            PartOutsourced.CheckedChanged += PartOutsourced_CheckedChanged;
            // 
            // PartInhouse
            // 
            PartInhouse.AutoSize = true;
            PartInhouse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PartInhouse.Location = new Point(261, 21);
            PartInhouse.Name = "PartInhouse";
            PartInhouse.Size = new Size(118, 32);
            PartInhouse.TabIndex = 0;
            PartInhouse.TabStop = true;
            PartInhouse.Text = "In-House";
            PartInhouse.UseVisualStyleBackColor = true;
            PartInhouse.CheckedChanged += PartInhouse_CheckedChanged;
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
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 729);
            Controls.Add(AddPartPanel);
            Controls.Add(Title);
            Name = "AddPartForm";
            Text = "Add Part";
            Load += AddPartForm_Load;
            AddPartPanel.ResumeLayout(false);
            PartBox.ResumeLayout(false);
            PartBox.PerformLayout();
            ProductsBttBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Title;

        private GroupBox PartBox;
        private FlowLayoutPanel AddPartPanel;
        private GroupBox ProductsBttBox;

        private Button PartCancel;
        private Button PartSave;
        private RadioButton PartInhouse;
        private RadioButton PartOutsourced;

        private Label PartIdLabel;
        private TextBox PartId;

        private Label PartNameLabel;
        private TextBox PartNameInput;

        private Label PartInventoryLabel;
        private TextBox PartInventoryInput;

        private Label PartPriceLabel;
        private TextBox PartPriceInput;

        private Label PartMaxLabel;
        private TextBox PartMaxInput;

        private Label PartMinLabel;
        private TextBox PartMinInput;
        
        private Label PartMachineOrCompanyLabel;
        private TextBox PartMachineIdOrCompanyInput;
    }
}