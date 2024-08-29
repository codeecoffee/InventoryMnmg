using System.ComponentModel;

namespace InventoryMgmt
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Load += MainScreen_Load;
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            PartsGridView.DataSource = Inventory.GetAllParts();
            ProductsGridView.DataSource = Inventory.GetAllProducts();
        }
        private void PartAdd_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
            PartsGridView.Refresh();
        }
        private void ExitBtt_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void outsourcedPartBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void inHousePartBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void PartModify_Click(object sender, EventArgs e)
        {
            if (PartsGridView.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)PartsGridView.SelectedRows[0].DataBoundItem;
                ModifyPart modifyPartForm = new ModifyPart(selectedPart);
                modifyPartForm.ShowDialog();

                PartsGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a part to modify");
            }
        }
        private void PartDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int selectedPartId = (int)PartsGridView.SelectedRows[0].Cells[0].Value;
                Part? selectedPart = Inventory.SearchPartsById(selectedPartId);
                if (selectedPart != null)
                {
                    bool deleted = Inventory.Instance.DeletePart(selectedPart);
                    if (deleted) MessageBox.Show("Part deleted successfully.");
                    else MessageBox.Show("Failed to delete the part");
                }
                else MessageBox.Show("Please select a part to delete");

                //Inventory.Instance.DeletePart(selectedPart);

            }
        }
        private void ProductAdd_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new AddProduct();
            addproduct.ShowDialog();
            ProductsGridView.Refresh();
        }
        private void ProductDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this Product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (ProductsGridView.SelectedRows.Count > 0)
                {
                    Product selectedProd = (Product)ProductsGridView.SelectedRows[0].DataBoundItem;
                    bool deleteSuccess = Inventory.Instance.DeleteProduct(selectedProd);
                    if (deleteSuccess)
                    {
                        PartsGridView.DataSource = null;
                        PartsGridView.DataSource = Inventory.GetAllParts();
                        ProductsGridView.DataSource = null;
                        ProductsGridView.DataSource = Inventory.GetAllProducts();
                    
                        PartsGridView.Refresh();
                        ProductsGridView.Refresh();
                    }
                    else MessageBox.Show("Failed to delete the product");
                }
                else MessageBox.Show("Please select a product to delete");
                //check to see if the are any prod selected
                //if ()
            }
        }
        private void ProductModify_Click(object sender, EventArgs e)
        {
            if (ProductsGridView.SelectedRows.Count > 0)
            {
                Product selectedProduct = (Product)ProductsGridView.SelectedRows[0].DataBoundItem;
                ModifyProduct modifyproductForm = new ModifyProduct(selectedProduct);
                modifyproductForm.ShowDialog();

                ProductsGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a product to modify");
            }
        }
        private void PartsSearchInput_TextChanged(object sender, EventArgs e)
        {
            // if (SearchBoxInput.Text == "") AllParts.DataSource = Inventory.GetAllParts();
            if (PartsSearchInput.Text == "") PartsGridView.DataSource = Inventory.GetAllParts();
        }
        private void PartsSearchBtt_Click(object sender, EventArgs e)
        {
            string name = PartsSearchInput.Text;
            int.TryParse(PartsSearchInput.Text, out int id);
            decimal.TryParse(PartsSearchInput.Text, out decimal price);

            BindingList<Part> partResults = new BindingList<Part>();

            if (!string.IsNullOrEmpty(name)) partResults = Inventory.SearchPartsByName(name);
            else if (price > 0) partResults = Inventory.SearchPartsByPrice(price);
            else if (id > 0)
            {
                var part = Inventory.SearchPartsById(id);
                if (part != null) partResults.Add(part);
            }

            if (partResults.Count > 0) PartsGridView.DataSource = partResults;
            else if (partResults.Count == 0) MessageBox.Show("No results found.");

        }
        private void ProductsSearchInput_TextChanged(object sender, EventArgs e)
        {
            if (ProductsSearchInput.Text == "") ProductsGridView.DataSource = Inventory.GetAllProducts();
        }
        private void ProductsSearchBtt_Click(object sender, EventArgs e)
        {
            string name = ProductsSearchInput.Text;
            int.TryParse(ProductsSearchInput.Text, out int id);
            decimal.TryParse(ProductsSearchInput.Text, out decimal price);

            BindingList<Product> productResults = new BindingList<Product>();

            if (!string.IsNullOrEmpty(name)) productResults = Inventory.SearchProductByName(name);
            else if (price > 0) productResults = Inventory.SearchProductsByPrice(price);

            else if (id > 0)
            {
                var product = Inventory.SearchProductsById(id);
                if (product != null) productResults.Add(product);
            }
            if (productResults.Count > 0) ProductsGridView.DataSource = productResults;
            else if (productResults.Count == 0) MessageBox.Show("No results found.");
        }
    }
}
