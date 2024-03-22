namespace Class_Management
{
    public partial class Form1 : Form
    {
        public Form1()
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
