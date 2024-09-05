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
    public partial class ModifyPart : Form
    {
        private Part selectedPart;
        public ModifyPart(Part part)
        {
            InitializeComponent();
            selectedPart = part;
            PopulateFields();
        }
        private void PopulateFields()
        {
            PartId.Text = selectedPart.PartID.ToString();
            PartNameInput.Text = selectedPart.Name;
            PartInventoryInput.Text = selectedPart.InStock.ToString();
            PartPriceInput.Text = selectedPart.Price.ToString();
            PartMinInput.Text = selectedPart.Min.ToString();
            PartMaxInput.Text = selectedPart.Max.ToString();

            if (selectedPart is InHousePart inHousePart)
            {
                PartInhouse.Checked = true;
                PartMachineIdOrCompanyInput.Text = inHousePart.MachineId.ToString();
            }
            else if (selectedPart is OutsourcedPart outsourcedPart)
            {
                PartOutsourced.Checked = true;
                PartMachineIdOrCompanyInput.Text = outsourcedPart.CompanyName.ToString();
            }
        }
        private void PartSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.PartNameInput.Text))
            {
                MessageBox.Show("Please fill out the Part name");
                return;
            }
            bool isValid = InputValidator.ValidateNumFields(
            (PartInventoryInput.Text, "Inventory"),
            (PartPriceInput.Text, "Price"),
            (PartMaxInput.Text, "Max"),
            (PartMinInput.Text, "Min"));
            if (!isValid) return;

    
            string name = PartNameInput.Text;
            int inventory = int.Parse(PartInventoryInput.Text); //instock
            decimal price = decimal.Parse(PartPriceInput.Text);
            int max = int.Parse(PartMaxInput.Text);
            int min = int.Parse(PartMinInput.Text);

            if (min > max)
            {
                MessageBox.Show("Min value cannot be greater than Max value");
                return;
            }
            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max values.");
                return;
            }

            Part updatedPart = null;  // This will hold the new or modified part

            if (PartInhouse.Checked)
            {
                bool machineIdValid = int.TryParse(PartMachineIdOrCompanyInput.Text, out int machineId);
                if (!machineIdValid)
                {
                    MessageBox.Show("Please enter a valid Machine Id");
                    return;
                }

                if (selectedPart is InHousePart inHousePart)
                {
                    // Modify existing in-house part
                    inHousePart.Name = name;
                    inHousePart.InStock = inventory;
                    inHousePart.Price = price;
                    inHousePart.Max = max;
                    inHousePart.Min = min;
                    inHousePart.MachineId = machineId;
                    updatedPart = inHousePart;
                }
                else
                {
                    // Create a new InHousePart and replace the existing OutsourcedPart
                    updatedPart = new InHousePart(
                        selectedPart.PartID,
                        name,
                        price,
                        inventory,
                        min,
                        max,
                        machineId
                    );
                }
            }
            else if (PartOutsourced.Checked)
            {
                string companyName = PartMachineIdOrCompanyInput.Text;

                if (selectedPart is OutsourcedPart outsourcedPart)
                {
                    // Modify existing outsourced part
                    outsourcedPart.Name = name;
                    outsourcedPart.InStock = inventory;
                    outsourcedPart.Price = price;
                    outsourcedPart.Max = max;
                    outsourcedPart.Min = min;
                    outsourcedPart.CompanyName = companyName;
                    updatedPart = outsourcedPart;
                }
                else
                {
                    // Create a new OutsourcedPart and replace the existing InHousePart
                    updatedPart = new OutsourcedPart(
                        selectedPart.PartID,
                        name,
                        price,
                        inventory,
                        min,
                        max,
                        companyName
                    );
                }
            }

            // Replace the selected part in the inventory with the updated part
            Inventory.Instance.updatePart(selectedPart.PartID, updatedPart);

            this.Close();

        }
        private void PartCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PartInhouse_CheckedChanged(object sender, EventArgs e)
        {
            PartMachineOrCompanyLabel.Text = "Machine ID";
            PartMachineIdOrCompanyInput.Text = "";
        }

        private void PartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            PartMachineOrCompanyLabel.Text = "Company Name";
            PartMachineIdOrCompanyInput.Text = "";
        }
    }
}
