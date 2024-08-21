namespace InventoryMgmt
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
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
        }
    }
}
