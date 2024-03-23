using Class_Management.Models;
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
    public partial class frmClassStudent : Form
    {
        private readonly ClassManagement3Context _context;
        public frmClassStudent()
        {
            InitializeComponent();
            _context = new ClassManagement3Context();
            cboSearchGender.SelectedIndex = 0;
        }
        private void LoadStudentNames()
        {
            var studentNames = _context.Students.Select(s => s.FullName).ToList();
            cboStudentName.DataSource = studentNames;
        }
        private void LoadClassNames()
        {
            var classNames = _context.Classes.Select(c => c.ClassName).ToList();
            cboClassName.DataSource = classNames;

        }
        private void AddStudentToClass(int classId, int studentId)
        {
            // Check if the student is already enrolled in the class
            bool alreadyEnrolled = _context.ClassStudents.Any(cs => cs.ClassId == classId && cs.StudentId == studentId);

            if (!alreadyEnrolled)
            {
                // Create a new ClassStudent instance
                ClassStudent newClassStudent = new ClassStudent
                {
                    ClassId = classId,
                    StudentId = studentId
                };

                // Add the new ClassStudent instance to the ClassStudents DbSet and save changes to the database
                _context.ClassStudents.Add(newClassStudent);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student is already enrolled in the class.");
            }
        }
        private void LoadClassStudentData()
        {
            var classStudents = from c in _context.ClassStudents
                                join c1 in _context.Classes on c.ClassId equals c1.ClassId
                                join c2 in _context.Students on c.StudentId equals c2.StudentId
                                join c3 in _context.ClassSchedules on c.ClassId equals c3.ClassId
                                join c4 in _context.TimeOfDays on c3.TimeOfDayId equals c4.TimeOfDayId
                                join c5 in _context.DayOfWeeks on c3.DayOfWeekId equals c5.DayOfWeekId
                                select new
                                {
                                    c.ClassStudentId,
                                    StudentName = c2.FullName,
                                    PhoneNumber = c2.ContactInfo,
                                    ClassName = c1.ClassName,
                                    Schedule = $"{c5.DayName}, {c4.TimeSlot}"
                                };

            DataTable dt = new DataTable();
            dt.Columns.Add("ClassStudentID");
            dt.Columns.Add("StudentName");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("ClassName");
            dt.Columns.Add("Schedule");

            foreach (var cs in classStudents)
            {
                dt.Rows.Add(cs.ClassStudentId, cs.StudentName, cs.PhoneNumber, cs.ClassName, cs.Schedule);
            }

            dgvClassStudent.DataSource = dt;
        }
        private void FilterData()
        {
            var classStudents = from c in _context.ClassStudents
                                join c1 in _context.Classes on c.ClassId equals c1.ClassId
                                join c2 in _context.Students on c.StudentId equals c2.StudentId
                                join c3 in _context.ClassSchedules on c.ClassId equals c3.ClassId
                                join c4 in _context.TimeOfDays on c3.TimeOfDayId equals c4.TimeOfDayId
                                join c5 in _context.DayOfWeeks on c3.DayOfWeekId equals c5.DayOfWeekId
                                where
                                    (string.IsNullOrEmpty(txtSearchClassName.Text) || c1.ClassName.Contains(txtSearchClassName.Text)) &&
                                    (string.IsNullOrEmpty(txtSearchStudentName.Text) || c2.FullName.Contains(txtSearchStudentName.Text)) &&
                                    (cboSearchGender.SelectedIndex == 0 || (cboSearchGender.SelectedIndex == 1 && c2.Gender == "Male") || (cboSearchGender.SelectedIndex == 2 && c2.Gender == "Female"))
                                select new
                                {
                                    c.ClassStudentId,
                                    StudentName = c2.FullName,
                                    PhoneNumber = c2.ContactInfo,
                                    ClassName = c1.ClassName,
                                    Schedule = $"{c5.DayName}, {c4.TimeSlot}"
                                };

            DataTable dt = new DataTable();
            dt.Columns.Add("ClassStudentID");
            dt.Columns.Add("StudentName");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("ClassName");
            dt.Columns.Add("Schedule");

            foreach (var cs in classStudents)
            {
                dt.Rows.Add(cs.ClassStudentId, cs.StudentName, cs.PhoneNumber, cs.ClassName, cs.Schedule);
            }

            dgvClassStudent.DataSource = dt;
        }


        private void frmClassStudent_Load(object sender, EventArgs e)
        {
            LoadClassStudentData();
            LoadStudentNames();
            LoadClassNames();
        }

        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtSearchClassName_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cboSearchGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dgvClassStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClassStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClassStudent.SelectedRows[0];

                // Update ComboBoxes and TextBox with the selected row data
                cboClassName.Text = selectedRow.Cells["ClassName"].Value?.ToString();
                cboStudentName.Text = selectedRow.Cells["StudentName"].Value?.ToString();
                txtContactInfo.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();

                // Extract schedule from the selected row data
                string schedule = selectedRow.Cells["Schedule"].Value?.ToString();

                // Clear and Load cboSchedule based on the extracted schedule
                cboSchedule.Items.Clear();
                if (!string.IsNullOrEmpty(schedule))
                {
                    cboSchedule.Items.Add(schedule);
                    cboSchedule.SelectedIndex = 0;
                }
            }
        }

        private void cboStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentName = cboStudentName.SelectedItem?.ToString();

            if (selectedStudentName != null)
            {
                // Query the student table to get the contact info based on the selected name
                var selectedStudent = _context.Students.FirstOrDefault(s => s.FullName == selectedStudentName);

                // Update the contact info textbox
                txtContactInfo.Text = selectedStudent?.ContactInfo ?? string.Empty;
            }
        }
        private void cboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected class name
            string selectedClassName = cboClassName.SelectedItem?.ToString();

            if (selectedClassName != null)
            {
                // Query the Class table to get the list of schedules based on the selected class name
                var classSchedules = _context.ClassSchedules
                    .Where(cs => cs.Class.ClassName == selectedClassName)
                    .Select(cs => $"{cs.DayOfWeek.DayName}, {cs.TimeOfDay.TimeSlot}")
                    .ToList();

                // Clear previous items in cboSchedule
                cboSchedule.Items.Clear();

                // Add the list of schedules to cboSchedule
                foreach (var schedule in classSchedules)
                {
                    cboSchedule.Items.Add(schedule);
                }
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            // Check if both class name and student name are selected
            if (cboClassName.SelectedItem == null || cboStudentName.SelectedItem == null)
            {
                MessageBox.Show("Please select both class and student.");
                return;
            }

            // Get the selected class and student names
            string selectedClassName = cboClassName.SelectedItem.ToString();
            string selectedStudentName = cboStudentName.SelectedItem.ToString();

            // Retrieve the class ID
            var selectedClass = _context.Classes.FirstOrDefault(c => c.ClassName == selectedClassName);
            if (selectedClass == null)
            {
                MessageBox.Show("Selected class not found.");
                return;
            }
            int selectedClassId = selectedClass.ClassId;

            // Retrieve the student ID
            var selectedStudent = _context.Students.FirstOrDefault(s => s.FullName == selectedStudentName);
            if (selectedStudent == null)
            {
                MessageBox.Show("Selected student not found.");
                return;
            }
            int selectedStudentId = selectedStudent.StudentId;

            // Add the student to the class
            AddStudentToClass(selectedClassId, selectedStudentId);

            // Reload the data after joining the class
            LoadClassStudentData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvClassStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            // Get the selected ClassStudentID
            int selectedClassStudentID = Convert.ToInt32(dgvClassStudent.SelectedRows[0].Cells["ClassStudentID"].Value);

            // Retrieve the corresponding ClassStudent record from the database
            var classStudentToUpdate = _context.ClassStudents.FirstOrDefault(cs => cs.ClassStudentId == selectedClassStudentID);

            if (classStudentToUpdate == null)
            {
                MessageBox.Show("Selected class student record not found.");
                return;
            }

            // Get the selected class and student names
            string selectedClassName = cboClassName.SelectedItem.ToString();
            string selectedStudentName = cboStudentName.SelectedItem.ToString();

            // Retrieve the class ID
            var selectedClass = _context.Classes.FirstOrDefault(c => c.ClassName == selectedClassName);
            if (selectedClass == null)
            {
                MessageBox.Show("Selected class not found.");
                return;
            }
            int selectedClassId = selectedClass.ClassId;

            // Retrieve the student ID
            var selectedStudent = _context.Students.FirstOrDefault(s => s.FullName == selectedStudentName);
            if (selectedStudent == null)
            {
                MessageBox.Show("Selected student not found.");
                return;
            }
            int selectedStudentId = selectedStudent.StudentId;

            // Check if the selected class and student are the same as the current ones
            if (classStudentToUpdate.ClassId == selectedClassId && classStudentToUpdate.StudentId == selectedStudentId)
            {
                MessageBox.Show("No changes detected.");
                return;
            }

            // Check if the student is already enrolled in the class
            bool alreadyEnrolled = _context.ClassStudents.Any(cs => cs.ClassId == selectedClassId && cs.StudentId == selectedStudentId && cs.ClassStudentId != selectedClassStudentID);

            if (alreadyEnrolled)
            {
                MessageBox.Show("Student is already enrolled in the class.");
                return;
            }

            // Update the ClassStudent record with the new class and student IDs
            classStudentToUpdate.ClassId = selectedClassId;
            classStudentToUpdate.StudentId = selectedStudentId;

            // Save changes to the database
            _context.SaveChanges();

            // Reload the data after updating
            LoadClassStudentData();

            MessageBox.Show("Class student record updated successfully.");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvClassStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to remove.");
                return;
            }

            
            int selectedClassStudentID = Convert.ToInt32(dgvClassStudent.SelectedRows[0].Cells["ClassStudentID"].Value);

            
            var classStudentToRemove = _context.ClassStudents.FirstOrDefault(cs => cs.ClassStudentId == selectedClassStudentID);

            if (classStudentToRemove == null)
            {
                MessageBox.Show("Selected class student record not found.");
                return;
            }
            bool hasAttendanceRecords = _context.Attendances.Any(a => a.ClassStudentId == selectedClassStudentID);
            bool hasMarkRecords = _context.Marks.Any(m => m.ClassStudentId == selectedClassStudentID);
            bool hasPaymentRecords = _context.Payments.Any(p => p.ClassStudentId == selectedClassStudentID);

            if (hasAttendanceRecords || hasMarkRecords || hasPaymentRecords)
            {
                MessageBox.Show("This student cannot be removed from the class because there are associated records in Attendance, Mark, or Payment tables.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to remove this student from the class?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Remove the ClassStudent record from the DbSet and save changes to the database
                _context.ClassStudents.Remove(classStudentToRemove);
                _context.SaveChanges();

                // Reload the data after removing
                LoadClassStudentData();

                MessageBox.Show("Student removed from the class successfully.");
            }
        }

    }
}
