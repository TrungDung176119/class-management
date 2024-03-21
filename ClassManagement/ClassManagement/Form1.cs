namespace ClassManagement
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void mnuClass_Click(object sender, EventArgs e)
        {
            frmClass ClassManagement = new frmClass();
            ClassManagement.Show();
        }
    }
}
