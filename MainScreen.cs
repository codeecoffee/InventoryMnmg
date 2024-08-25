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
                //need to check if part is associated with any product
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
                Part selectedPart = (Part)PartsGridView.SelectedRows[0].DataBoundItem;
                Inventory.Instance.DeletePart(selectedPart);
            }
        }
    }
}
