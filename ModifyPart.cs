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
            PartMaxInput.Text = selectedPart.Max.ToString();
            PartMinInput.Text = selectedPart.Min.ToString();

            if (selectedPart is InHousePart inHousePart)
            {
                PartInhouse.Checked = true;
                PartMachineIdOrCompanyInput.Text = inHousePart.MachineId.ToString();
            }
            else if (selectedPart is OutsourcedPart outsourcedPart)
            {
                PartOutsourced.Checked = true;
                PartMachineIdOrCompanyInput.Text = outsourcedPart.CompanyName;
            }
        }

        private void PartSave_Click(object sender, EventArgs e)
        {
            
        }

        private void PartCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
