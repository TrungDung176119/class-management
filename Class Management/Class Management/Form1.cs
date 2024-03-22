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

        private void mnuStudent_Click(object sender, EventArgs e)
        {
            frmStudent StudentManagement = new frmStudent();
            StudentManagement.Show();
        }

        private void mnuMark_Click(object sender, EventArgs e)
        {
            frmMark MarkManagement = new frmMark();
            MarkManagement.Show();
        }

        private void mnuAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance Attendance = new frmAttendance();
            Attendance.Show();
        }

        private void mnuPayment_Click(object sender, EventArgs e)
        {
            frmPayment Payment = new frmPayment();
            Payment.Show();
        }
    }
}
