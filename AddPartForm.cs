using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMgmt
{
    public partial class AddPartForm : Form
    {
        private int newPartId;
        
        public AddPartForm()
        {
            InitializeComponent();
            this.Load += AddPartForm_Load;
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        { 
            newPartId = Inventory.GeneratePartId();
            PartId.Text = newPartId.ToString();

        }

        private void PartCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PartSave_Click(object sender, EventArgs e)
        {

            string name = PartNameInput.Text;
            int inventory = int.Parse(PartInventoryInput.Text); //instock
            decimal price = decimal.Parse(PartPriceInput.Text);
            int max = int.Parse(PartMaxInput.Text);
            int min = int.Parse(PartMinInput.Text);




            if (string.IsNullOrWhiteSpace(this.PartNameInput.Text) ||
                string.IsNullOrWhiteSpace(this.PartInventoryInput.Text) ||
                string.IsNullOrWhiteSpace(this.PartPriceInput.Text) ||
                string.IsNullOrWhiteSpace(this.PartMaxInput.Text) ||
                string.IsNullOrWhiteSpace(this.PartMinInput.Text)
                )
            {
                MessageBox.Show("Please fill out all fields");
                return;

            }

            //bool isNumeric = int.TryParse(PartInventoryInput.Text, out int inventory)
            //                && decimal.TryParse(PartPriceInput.Text, out decimal price)
            //                && int.TryParse(PartMinInput.Text, out int min)
            //                && int.TryParse(PartMaxInput.Text, out int max);




            //if (!isNumeric)
            //{
            //    MessageBox.Show("Please enter valid numbers for Inventory, Price, Min and Max");
            //}

            if (min > max)
            {
                MessageBox.Show("Min value cannot be greater than Max value");
                return;
            }
            //if (min < inventory || max > inventory)
            //{
            //    MessageBox.Show("Inventory must be between Min and Max values.");
            //    return;
            //}

            Part? newPart = null;

            if (PartInhouse.Checked)
            {
                bool machineIdValid = int.TryParse(PartMachineIdOrCompanyInput.Text, out int machineId);
                if (!machineIdValid)
                {
                    MessageBox.Show("Please enter a valid Machine Id");
                    return;
                }
                newPart = new InHousePart(newPartId, name, price, inventory, min, max, machineId);
            }
            else if (PartOutsourced.Checked)
            {
                string companyName = PartMachineIdOrCompanyInput.Text;
                newPart = new OutsourcedPart(newPartId, name, price, inventory, min, max, companyName);

            }
            else
            {
                MessageBox.Show("Please select either In-house or Outsourced.");
                return;
            }
            if (newPart != null) 
            { 
                Inventory.Instance.AddPart(newPart);
                this.Close();
            }
        }
        private void PartInhouse_CheckedChanged(object sender, EventArgs e)
        {
            PartMachineOrCompanyLabel.Text = "Machine ID";
        }

        private void PartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            PartMachineOrCompanyLabel.Text = "Company Name";
        }


    }
}
