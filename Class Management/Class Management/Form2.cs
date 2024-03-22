using Class_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Management
{
    public partial class frmClass : Form
    {
        private readonly ClassManagementContext _context;
        public frmClass()
        {
            InitializeComponent();
            _context = new ClassManagementContext();

        }
        private void LoadDayOfWeekValues()
        {
            var dayOfWeekValues = _context.DayOfWeeks.Select(dow => dow.DayName).ToList();
            cboDOW.DataSource = dayOfWeekValues;
        }

        private void LoadTimeOfDayValues()
        {
            var timeOfDayValues = _context.TimeOfDays.Select(tod => tod.TimeSlot).ToList();
            cboTOD.DataSource = timeOfDayValues;
        }
        private void LoadDataIntoDataGridView()
        {
            var statusMappings = new Dictionary<int, string> { { 0, "Inactive" }, { 1, "Active" } };

            var classes = _context.Classes
                .SelectMany(c => c.ClassSchedules.Select(cs => new
                {
                    ClassId = c.ClassId,
                    ClassName = c.ClassName,
                    ClassStartDate = c.ClassStartDate,
                    ClassEndDate = c.ClassEndDate,
                    DayOfWeekName = cs.DayOfWeek.DayName,
                    TimeOfDaySlot = cs.TimeOfDay.TimeSlot,
                    ClassStatus = c.ClassStatus
                })).Where(c =>
            (string.IsNullOrEmpty(txtSearchClassName.Text) || c.ClassName.Contains(txtSearchClassName.Text)) &&
            (string.IsNullOrEmpty(txtSearchSchedule.Text) ||
                c.DayOfWeekName.Contains(txtSearchSchedule.Text) ||
                c.TimeOfDaySlot.Contains(txtSearchSchedule.Text)) &&
            (cboSearchStatus.SelectedIndex == 0 ||
        (cboSearchStatus.SelectedIndex == 1 && c.ClassStatus == 1) ||
        (cboSearchStatus.SelectedIndex == 2 && c.ClassStatus == 0)))
                .ToList()
                .Select(c => new
                {
                    ID = c.ClassId,
                    Name = c.ClassName,
                    StartDate = c.ClassStartDate,
                    EndDate = c.ClassEndDate,
                    DayOfWeek = c.DayOfWeekName,
                    TimeOfDay = c.TimeOfDaySlot,
                    Status = c.ClassStatus.HasValue ? statusMappings[c.ClassStatus.Value] : "Unknown"
                })
                .ToList();

            dgvClass.DataSource = classes;
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            cboSearchStatus.SelectedIndex = 0;
            // Load values for cboDOW (Day of Week)
            LoadDayOfWeekValues();

            // Load values for cboTOD (Time of Day)
            LoadTimeOfDayValues();
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
                string dayOfWeek = Convert.ToString(selectedRow.Cells["DayOfWeek"].Value);
                string timeOfDay = Convert.ToString(selectedRow.Cells["TimeOfDay"].Value);
                string status = Convert.ToString(selectedRow.Cells["Status"].Value);

                // Populate controls with the extracted data
                txtClassName.Text = className;
                dtpStartDate.Value = startDate;
                dtpEndDate.Value = endDate;
                cboStatus.SelectedItem = status;

                // Set the selected values for cboDOF and cboTOD
                cboDOW.SelectedItem = dayOfWeek;
                cboTOD.SelectedItem = timeOfDay;
            }
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtClassName.Clear();
            cboDOW.SelectedIndex = 0;
            cboTOD.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            string dayOfWeek = cboDOW.SelectedItem?.ToString(); // Selected Day of Week
            string timeOfDay = cboTOD.SelectedItem?.ToString(); // Selected Time of Day
            int status = cboStatus.SelectedIndex == 1 ? 0 : 1; // Map selected index to status value

            // Validate input data
            if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(dayOfWeek) || string.IsNullOrWhiteSpace(timeOfDay))
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
                c.ClassSchedules.Any(cs => cs.DayOfWeek.DayName == dayOfWeek && cs.TimeOfDay.TimeSlot == timeOfDay));

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
                ClassStatus = status
            };

            // Create new ClassSchedule entry for the new class
            newClass.ClassSchedules.Add(new ClassSchedule
            {
                DayOfWeek = _context.DayOfWeeks.FirstOrDefault(dow => dow.DayName == dayOfWeek),
                TimeOfDay = _context.TimeOfDays.FirstOrDefault(tod => tod.TimeSlot == timeOfDay)
            });

            _context.Classes.Add(newClass);
            _context.SaveChanges();

            MessageBox.Show("Class added successfully.");

            // Refresh DataGridView
            LoadDataIntoDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to edit.");
                return;
            }

            // Get the selected class ID from the DataGridView
            int classId = Convert.ToInt32(dgvClass.SelectedRows[0].Cells["ID"].Value);

            string className = txtClassName.Text;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            string dayOfWeek = cboDOW.SelectedItem?.ToString(); // Selected Day of Week
            string timeOfDay = cboTOD.SelectedItem?.ToString(); // Selected Time of Day
            int status = cboStatus.SelectedIndex == 1 ? 0 : 1; // Map selected index to status value

            // Validate input data
            if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(dayOfWeek) || string.IsNullOrWhiteSpace(timeOfDay))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("Start date must be earlier than end date.");
                return;
            }

            // Find the class to edit
            Class classToEdit = _context.Classes.Include(c => c.ClassSchedules).FirstOrDefault(c => c.ClassId == classId);
            if (classToEdit == null)
            {
                MessageBox.Show("Class not found.");
                return;
            }

            // Update class information
            classToEdit.ClassName = className;
            classToEdit.ClassStartDate = startDate;
            classToEdit.ClassEndDate = endDate;
            classToEdit.ClassStatus = status;

            // Clear existing class schedules
            classToEdit.ClassSchedules.Clear();

            // Create new ClassSchedule entry for the class
            ClassSchedule newClassSchedule = new ClassSchedule
            {
                DayOfWeek = _context.DayOfWeeks.FirstOrDefault(dow => dow.DayName == dayOfWeek),
                TimeOfDay = _context.TimeOfDays.FirstOrDefault(tod => tod.TimeSlot == timeOfDay)
            };

            // Set the reference to the Class entity
            newClassSchedule.Class = classToEdit;

            // Add the new ClassSchedule entry to the class
            classToEdit.ClassSchedules.Add(newClassSchedule);

            // Save changes
            _context.SaveChanges();

            MessageBox.Show("Class information updated successfully.");

            // Refresh DataGridView
            LoadDataIntoDataGridView();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to delete.");
                return;
            }

            // Get the selected class ID from the DataGridView
            int classId = Convert.ToInt32(dgvClass.SelectedRows[0].Cells["ID"].Value);

            // Find the class to delete
            Class classToDelete = _context.Classes.Include("ClassSchedules").FirstOrDefault(c => c.ClassId == classId);
            if (classToDelete == null)
            {
                MessageBox.Show("Class not found.");
                return;
            }

            // Confirm deletion with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            // Remove class schedules associated with the class
            _context.ClassSchedules.RemoveRange(classToDelete.ClassSchedules);

            // Remove the class
            _context.Classes.Remove(classToDelete);

            // Save changes
            _context.SaveChanges();

            MessageBox.Show("Class deleted successfully.");

            // Refresh DataGridView
            LoadDataIntoDataGridView();
        }
    }
}
