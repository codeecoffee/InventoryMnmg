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
    public partial class ModifyProduct : Form
    {
        private Product selectedProduct;
        private BindingList<Part> associatedPartsList = new BindingList<Part>();
        public ModifyProduct(Product product)
        {
            InitializeComponent();
            selectedProduct = product;
            PopulateFields(selectedProduct);

        }
        private void PopulateFields(Product selectedProduct)
        {
            ProductId.Text = selectedProduct.ProductId.ToString();
            ProductNameInput.Text = selectedProduct.Name;
            ProductInventoryInput.Text = selectedProduct.InStock.ToString();
            ProductPriceInput.Text = selectedProduct.Price.ToString();
            ProductMinInput.Text = selectedProduct.Min.ToString();
            ProductMaxInput.Text = selectedProduct.Max.ToString();

            AllParts.DataSource = Inventory.GetAllParts();
            associatedPartsList = selectedProduct.AssociatedParts;
            //SelectedParts is the gridview 
            SelectedParts.DataSource = associatedPartsList;
            //SelectedParts.DataSource = selectedProduct.AssociatedParts;

        }

        private void ProductSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.ProductNameInput.Text))
            {
                MessageBox.Show("Please fill out the Part name");
                return;
            }
            bool isValid = InputValidator.ValidateNumFields(
                (ProductInventoryInput.Text, "Inventory"),
                (ProductMinInput.Text, "Min"),
                (ProductMaxInput.Text, "Max"),
                (ProductPriceInput.Text, "Price")
            );
            if (!isValid) return;

            string name = ProductNameInput.Text;
            int inventory = int.Parse(ProductInventoryInput.Text);
            decimal price = decimal.Parse(ProductPriceInput.Text);
            int min = int.Parse(ProductMinInput.Text);
            int max = int.Parse(ProductMaxInput.Text);

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
            if (!associatedPartsList.Any())
            {
                MessageBox.Show("You must have at least one part associate to this product");
                return;
            }
            //Product newProduct = new Product(associatedPartsList,newProduct);
            selectedProduct.Name = name;
            selectedProduct.Price = price;
            selectedProduct.Min = min;
            selectedProduct.Max = max;
            selectedProduct.InStock = inventory;
            selectedProduct.AssociatedParts= associatedPartsList;

            Inventory.Instance.updateProduct(selectedProduct.ProductId,selectedProduct);
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

        private void ProductCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
