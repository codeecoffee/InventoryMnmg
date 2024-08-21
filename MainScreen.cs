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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PartsBttBox_Enter(object sender, EventArgs e)
        {

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
                Part selectedPart = (Part) PartsGridView.SelectedRows[0].DataBoundItem;
                ModifyPart modifyPartForm = new ModifyPart(selectedPart);
                modifyPartForm.ShowDialog();

                PartsGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a part to modify");
            }
        }
    }
}
