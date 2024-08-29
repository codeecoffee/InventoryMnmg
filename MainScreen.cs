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
                Part selectedPart = (Part)PartsGridView.SelectedRows[0].DataBoundItem;
                Inventory.Instance.DeletePart(selectedPart);

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
                Product selectedProd = (Product)ProductsGridView.SelectedRows[0].DataBoundItem;
                Inventory.Instance.DeleteProduct(selectedProd);
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
    }
}
