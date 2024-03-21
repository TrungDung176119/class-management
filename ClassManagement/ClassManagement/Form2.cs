using ClassManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagement
{
    public partial class frmClass : Form
    {
        private readonly ClassManagementContext _context;
        public frmClass()
        {
            InitializeComponent();
            _context = new ClassManagementContext();

        }
        private void LoadDataIntoDataGridView()
        {
            var statusMappings = new Dictionary<int, string> { { 0, "Inactive" }, { 1, "Active" } };

            var classes = _context.Classes
                .Where(c =>
                    (string.IsNullOrEmpty(txtSearchClassName.Text) || c.ClassName.Contains(txtSearchClassName.Text)) &&
                    (string.IsNullOrEmpty(txtSearchSchedule.Text) || c.Schedule.Contains(txtSearchSchedule.Text)) &&
                    (cboSearchStatus.SelectedIndex == 0 || c.ClassStatus == cboSearchStatus.SelectedIndex)
                )
                .Select(c => new
                {
                    ID = c.ClassId,
                    Name = c.ClassName,
                    StartDate = c.ClassStartDate,
                    EndDate = c.ClassEndDate,
                    c.Schedule,
                    Status = c.ClassStatus.HasValue ? statusMappings[c.ClassStatus.Value] : "Unknown"
                })
                .ToList();

            dgvClass.DataSource = classes;
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            cboSearchStatus.SelectedIndex = 0;
        }

        private void txtSearchClassName_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void txtSearchSchedule_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void cboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dgvClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClass.SelectedRows[0];

                // Extract data from the selected row
                int classId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string className = Convert.ToString(selectedRow.Cells["Name"].Value);
                DateTime startDate = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                DateTime endDate = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
                string schedule = Convert.ToString(selectedRow.Cells["Schedule"].Value);
                string status = Convert.ToString(selectedRow.Cells["Status"].Value);

                // Populate controls with the extracted data
                txtClassName.Text = className;
                dtpStartDate.Value = startDate;
                dtpEndDate.Value = endDate;
                txtSchedule.Text = schedule;
                cboStatus.SelectedItem = status;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtClassName.Clear();
            txtSchedule.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            string schedule = txtSchedule.Text;
            int status = cboStatus.SelectedIndex;

            // Validate input data
            if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(schedule))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("Start date must be earlier than end date.");
                return;
            }

            // Check for overlapping schedule
            bool isScheduleOverlap = _context.Classes.Any(c =>
                c.ClassStatus == 1 && // Active status
                c.ClassStartDate < endDate && c.ClassEndDate > startDate &&
                c.Schedule == schedule);

            if (isScheduleOverlap)
            {
                MessageBox.Show("There is already a class scheduled at this time.");
                return;
            }

            // All validations passed, add the new class
            Class newClass = new Class
            {
                ClassName = className,
                ClassStartDate = startDate,
                ClassEndDate = endDate,
                Schedule = schedule,
                ClassStatus = status
            };

            _context.Classes.Add(newClass);
            _context.SaveChanges();

            MessageBox.Show("Class added successfully.");

            // Refresh DataGridView
            LoadDataIntoDataGridView();
        }
    }

}
