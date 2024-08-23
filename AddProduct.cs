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
    public partial class AddProduct : Form
    {
        private BindingList<Part> associatedPartsList = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();
            SelectedParts.DataSource = associatedPartsList;
            AllParts.DataSource = Inventory.GetAllParts();
        }

        private void AddedPartsLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            if (AllParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AllParts.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                if (!associatedPartsList.Contains(selectedPart))
                {
                    associatedPartsList.Add(selectedPart);
                }
                else
                {
                    MessageBox.Show("This part is already associated with the product");
                }
            }
        }


    }
}
