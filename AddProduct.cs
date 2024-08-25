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
        private int newProductId;
        public AddProduct()
        {
            InitializeComponent();
            SelectedParts.DataSource = associatedPartsList;
            AllParts.DataSource = Inventory.GetAllParts();
            this.Load += AddProduct_Load;
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            newProductId = Inventory.GenerateProductId();
            ProductId.Text = newProductId.ToString();
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

        private void PartCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {

            if (SelectedParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SelectedParts.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                associatedPartsList.Remove(selectedPart);

            }
        }

        private void PartSave_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrEmpty(this.ProductNameInput.Text)||
                string.IsNullOrEmpty(this.ProductInventoryInput.Text)||
                string.IsNullOrEmpty(this.ProductPriceInput.Text)||
                string.IsNullOrEmpty(this.ProductMaxInput.Text)||
                string.IsNullOrEmpty(this.ProductMinInput.Text)
                )
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            else if (SelectedParts.SelectedRows.Count < 0) 
            {
                MessageBox.Show("You must have at least one part associate to this product");
                return;
            }
            bool isValid = InputValidator.ValidateNumFields(
                (ProductInventoryInput.Text,"Inventory"),
                (ProductPriceInput.Text, "Price"),
                (ProductMinInput.Text, "Min"),
                (ProductMaxInput.Text, "Max"));
            if (!isValid) return;
            if (int.Parse(ProductMinInput.Text) > int.Parse(ProductMaxInput.Text))
            {
                MessageBox.Show("Min value must not be greater than Max value");
                return;
            }
            if (int.Parse(ProductInventoryInput.Text) < int.Parse(ProductMaxInput.Text) 
                || int.Parse(ProductMaxInput.Text) > int.Parse(ProductInventoryInput.Text))
            {
                MessageBox.Show("Inventory myst be between Min and Max values.");
                return;
            }

            string name = ProductNameInput.Text;
            int inventory = int.Parse(ProductInventoryInput.Text); //instock
            decimal price = decimal.Parse(ProductPriceInput.Text);
            int max = int.Parse(ProductMaxInput.Text);
            int min = int.Parse(ProductMinInput.Text);
            
            //make part part of a product setting the bool to true to prevent deletion
            //foreach (piece in SelectedParts)
            //{ 
            //}
            //var SelectedPartBind = new BindingList<Part>(SelectedParts);
            //Product newProduct = new Product(SelectedParts,name, inventory, price, max, min, );

            //if(newProduct !=null)
            //{
            //  Inventory.Instance.AddProduct(newProduct);
            //  this.Close();
            //}
        }
    }
}
