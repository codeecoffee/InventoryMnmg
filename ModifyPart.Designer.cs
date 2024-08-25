namespace InventoryMgmt
{
    partial class ModifyPart
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
            ModifiedPartSave = new Button();
            ProductsBttBox = new GroupBox();
            PartCancel = new Button();
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
            AddPartPanel = new FlowLayoutPanel();
            PartBox = new GroupBox();
            Title = new Label();
            ProductsBttBox.SuspendLayout();
            AddPartPanel.SuspendLayout();
            PartBox.SuspendLayout();
            SuspendLayout();
            // 
            // ModifiedPartSave
            // 
            ModifiedPartSave.BackColor = Color.DarkSeaGreen;
            ModifiedPartSave.Location = new Point(491, 27);
            ModifiedPartSave.Margin = new Padding(2);
            ModifiedPartSave.Name = "ModifiedPartSave";
            ModifiedPartSave.Size = new Size(60, 25);
            ModifiedPartSave.TabIndex = 0;
            ModifiedPartSave.Text = "Save";
            ModifiedPartSave.UseVisualStyleBackColor = false;
            // 
            // ProductsBttBox
            // 
            ProductsBttBox.Controls.Add(PartCancel);
            ProductsBttBox.Controls.Add(ModifiedPartSave);
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
            // 
            // PartId
            // 
            PartId.BackColor = SystemColors.ActiveCaption;
            PartId.Location = new Point(122, 40);
            PartId.Margin = new Padding(3, 2, 3, 2);
            PartId.Name = "PartId";
            PartId.ReadOnly = true;
            PartId.Size = new Size(110, 36);
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
            // PartMachineOrCompanyLabel
            // 
            PartMachineOrCompanyLabel.AutoSize = true;
            PartMachineOrCompanyLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMachineOrCompanyLabel.Location = new Point(5, 327);
            PartMachineOrCompanyLabel.Name = "PartMachineOrCompanyLabel";
            PartMachineOrCompanyLabel.Size = new Size(106, 25);
            PartMachineOrCompanyLabel.TabIndex = 14;
            PartMachineOrCompanyLabel.Text = "Machine Id";
            // 
            // PartMachineIdOrCompanyInput
            // 
            PartMachineIdOrCompanyInput.Location = new Point(122, 321);
            PartMachineIdOrCompanyInput.Margin = new Padding(3, 2, 3, 2);
            PartMachineIdOrCompanyInput.Name = "PartMachineIdOrCompanyInput";
            PartMachineIdOrCompanyInput.Size = new Size(480, 36);
            PartMachineIdOrCompanyInput.TabIndex = 13;
            // 
            // PartMaxLabel
            // 
            PartMaxLabel.AutoSize = true;
            PartMaxLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartMaxLabel.Location = new Point(404, 270);
            PartMaxLabel.Name = "PartMaxLabel";
            PartMaxLabel.Size = new Size(48, 25);
            PartMaxLabel.TabIndex = 12;
            PartMaxLabel.Text = "Max";
            // 
            // PartMaxInput
            // 
            PartMaxInput.Location = new Point(522, 264);
            PartMaxInput.Margin = new Padding(3, 2, 3, 2);
            PartMaxInput.Name = "PartMaxInput";
            PartMaxInput.Size = new Size(80, 36);
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
            PartMinInput.Location = new Point(122, 264);
            PartMinInput.Margin = new Padding(3, 2, 3, 2);
            PartMinInput.Name = "PartMinInput";
            PartMinInput.Size = new Size(80, 36);
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
            PartPriceInput.Location = new Point(122, 197);
            PartPriceInput.Margin = new Padding(3, 2, 3, 2);
            PartPriceInput.Name = "PartPriceInput";
            PartPriceInput.Size = new Size(480, 36);
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
            PartInventoryInput.Location = new Point(122, 138);
            PartInventoryInput.Margin = new Padding(3, 2, 3, 2);
            PartInventoryInput.Name = "PartInventoryInput";
            PartInventoryInput.Size = new Size(480, 36);
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
            PartNameInput.Location = new Point(122, 80);
            PartNameInput.Margin = new Padding(3, 2, 3, 2);
            PartNameInput.Name = "PartNameInput";
            PartNameInput.Size = new Size(480, 36);
            PartNameInput.TabIndex = 3;
            // 
            // PartOutsourced
            // 
            PartOutsourced.AutoSize = true;
            PartOutsourced.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PartOutsourced.Location = new Point(457, 16);
            PartOutsourced.Margin = new Padding(3, 2, 3, 2);
            PartOutsourced.Name = "PartOutsourced";
            PartOutsourced.Size = new Size(114, 25);
            PartOutsourced.TabIndex = 2;
            PartOutsourced.TabStop = true;
            PartOutsourced.Text = "Outsourced";
            PartOutsourced.UseVisualStyleBackColor = true;
            // 
            // PartInhouse
            // 
            PartInhouse.AutoSize = true;
            PartInhouse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PartInhouse.Location = new Point(228, 16);
            PartInhouse.Margin = new Padding(3, 2, 3, 2);
            PartInhouse.Name = "PartInhouse";
            PartInhouse.Size = new Size(95, 25);
            PartInhouse.TabIndex = 0;
            PartInhouse.TabStop = true;
            PartInhouse.Text = "In-House";
            PartInhouse.UseVisualStyleBackColor = true;
            // 
            // AddPartPanel
            // 
            AddPartPanel.Controls.Add(PartBox);
            AddPartPanel.Controls.Add(ProductsBttBox);
            AddPartPanel.Location = new Point(10, 75);
            AddPartPanel.Margin = new Padding(3, 2, 3, 2);
            AddPartPanel.Name = "AddPartPanel";
            AddPartPanel.Size = new Size(1226, 448);
            AddPartPanel.TabIndex = 7;
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
            PartBox.Location = new Point(3, 2);
            PartBox.Margin = new Padding(3, 2, 3, 2);
            PartBox.Name = "PartBox";
            PartBox.Padding = new Padding(3, 2, 3, 2);
            PartBox.Size = new Size(1223, 376);
            PartBox.TabIndex = 0;
            PartBox.TabStop = false;
            PartBox.Text = "Modify Part";
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
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 547);
            Controls.Add(AddPartPanel);
            Controls.Add(Title);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModifyPart";
            Text = "ModifyPart";
            ProductsBttBox.ResumeLayout(false);
            AddPartPanel.ResumeLayout(false);
            PartBox.ResumeLayout(false);
            PartBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ModifiedPartSave;
        private GroupBox ProductsBttBox;
        private Button PartCancel;
        private TextBox PartId;
        private Label PartIdLabel;
        private Label PartMachineOrCompanyLabel;
        private TextBox PartMachineIdOrCompanyInput;
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
        private RadioButton PartOutsourced;
        private RadioButton PartInhouse;
        private FlowLayoutPanel AddPartPanel;
        private GroupBox PartBox;
        private Label Title;
    }
}