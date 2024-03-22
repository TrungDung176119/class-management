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
    public partial class frmAttendance : Form
    {
        private readonly ClassManagementContext _context;
        private List<Class> _classes;
        private List<Student> _students;
        public frmAttendance()
        {
            InitializeComponent();
            _context = new ClassManagementContext();
            LoadClassComboBox();
            LoadStudentComboBox();
            cboSearchStatus.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void LoadClassComboBox()
        {
            _classes = _context.Classes.ToList();
            cboClassName.DisplayMember = "ClassName";
            cboClassName.DataSource = _classes;
        }

        private void LoadStudentComboBox()
        {
            _students = _context.Students.ToList();
            cboStudentName.DisplayMember = "FullName";
            cboStudentName.DataSource = _students;
        }

        private void LoadAttendanceData()
        {
            try
            {
                // Define the initial query without filters
                var attendanceQuery = _context.Attendances.Include(a => a.Student).Include(a => a.Class).Select(a => new
                {
                    AttendanceId = a.AttendanceId,
                    ClassName = a.Class.ClassName,
                    StudentName = a.Student.FullName,
                    AttendanceDate = a.AttendanceDate,
                    Status = a.AttendanceStatus == 1 ? "Present" : "Absent"
                });

                // Apply filters based on ComboBox and TextBox values
                int selectedStatus = cboSearchStatus.SelectedIndex;
                if (selectedStatus == 1) // Filter by Present
                {
                    attendanceQuery = attendanceQuery.Where(a => a.Status == "Present");
                }
                else if (selectedStatus == 2) // Filter by Absent
                {
                    attendanceQuery = attendanceQuery.Where(a => a.Status == "Absent");
                }

                string classNameFilter = txtSearchClassName.Text.Trim();
                if (!string.IsNullOrEmpty(classNameFilter))
                {
                    attendanceQuery = attendanceQuery.Where(a => a.ClassName.Contains(classNameFilter));
                }

                string studentNameFilter = txtSearchStudentName.Text.Trim();
                if (!string.IsNullOrEmpty(studentNameFilter))
                {
                    attendanceQuery = attendanceQuery.Where(a => a.StudentName.Contains(studentNameFilter));
                }

                // Execute the query to fetch the filtered attendance data
                var filteredAttendanceData = attendanceQuery.ToList();

                // Bind the filtered and formatted data to the DataGridView
                dgvAttendance.DataSource = filteredAttendanceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void frmAttendance_Load(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void txtSearchClassName_TextChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void cboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected class and student
                Class selectedClass = cboClassName.SelectedItem as Class;
                Student selectedStudent = cboStudentName.SelectedItem as Student;

                // Validate selected items
                if (selectedClass == null || selectedStudent == null)
                {
                    MessageBox.Show("Please select a class and a student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get selected date
                DateTime attendanceDate = dtpAttendanceDate.Value.Date; // Ensure only date without time

                // Get selected status
                int selectedStatusIndex = cboStatus.SelectedIndex;
                int attendanceStatus = selectedStatusIndex == 0 ? 1 : 0; // Present: 1, Absent: 0

                // Create new attendance record
                Attendance newAttendance = new Attendance
                {
                    ClassId = selectedClass.ClassId,
                    StudentId = selectedStudent.StudentId,
                    AttendanceDate = attendanceDate,
                    AttendanceStatus = attendanceStatus
                };

                // Add new attendance record to database
                _context.Attendances.Add(newAttendance);
                _context.SaveChanges();

                MessageBox.Show("Attendance added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView to display the newly added record
                LoadAttendanceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAttendance_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there's a selected row
            if (dgvAttendance.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvAttendance.SelectedRows[0];

                // Retrieve the data from the selected row and populate the controls
                int attendanceId = Convert.ToInt32(selectedRow.Cells["AttendanceId"].Value);
                string className = selectedRow.Cells["ClassName"].Value?.ToString() ?? "";
                string studentName = selectedRow.Cells["StudentName"].Value?.ToString() ?? "";
                DateTime attendanceDate = Convert.ToDateTime(selectedRow.Cells["AttendanceDate"].Value);
                string status = Convert.ToString(selectedRow.Cells["Status"].Value);

                // Set the values to the respective ComboBoxes
                Class selectedClass = _classes.FirstOrDefault(c => c.ClassName == className);
                Student selectedStudent = _students.FirstOrDefault(s => s.FullName == studentName);
                cboClassName.SelectedItem = selectedClass;
                cboStudentName.SelectedItem = selectedStudent;
                dtpAttendanceDate.Value = attendanceDate;
                cboStatus.SelectedItem = status == "Present" ? "Present" : "Absent";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there's a selected row in the DataGridView
                if (dgvAttendance.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvAttendance.SelectedRows[0];

                    // Retrieve the data from the selected row
                    int attendanceId = Convert.ToInt32(selectedRow.Cells["AttendanceId"].Value);
                    string className = Convert.ToString(selectedRow.Cells["ClassName"].Value);
                    string studentName = Convert.ToString(selectedRow.Cells["StudentName"].Value);
                    DateTime attendanceDate = Convert.ToDateTime(selectedRow.Cells["AttendanceDate"].Value);
                    string status = Convert.ToString(selectedRow.Cells["Status"].Value);

                    // Get the updated values from the controls
                    string updatedClassName = cboClassName.SelectedItem.ToString();
                    string updatedStudentName = cboStudentName.SelectedItem.ToString();
                    DateTime updatedAttendanceDate = dtpAttendanceDate.Value;
                    string updatedStatus = cboStatus.SelectedItem.ToString();

                    // Validate the selected class and student
                    if (string.IsNullOrEmpty(updatedClassName) || string.IsNullOrEmpty(updatedStudentName))
                    {
                        MessageBox.Show("Please select a class and a student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Find the corresponding attendance record in the database
                    Attendance attendanceToUpdate = _context.Attendances.Find(attendanceId);
                    if (attendanceToUpdate != null)
                    {
                        // Update the attendance record with the updated values
                        attendanceToUpdate.ClassId = ((Class)cboClassName.SelectedItem)?.ClassId;
                        attendanceToUpdate.StudentId = ((Student)cboStudentName.SelectedItem)?.StudentId;
                        attendanceToUpdate.AttendanceDate = updatedAttendanceDate;
                        attendanceToUpdate.AttendanceStatus = updatedStatus == "Present" ? 1 : 0;

                        // Save changes to the database
                        _context.SaveChanges();

                        // Display a success message
                        MessageBox.Show("Attendance updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the changes
                        LoadAttendanceData();
                    }
                    else
                    {
                        MessageBox.Show("Attendance record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if there's a selected row
            if (dgvAttendance.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvAttendance.SelectedRows[0];

                    // Retrieve the attendance ID from the selected row
                    int attendanceId = Convert.ToInt32(selectedRow.Cells["AttendanceId"].Value);

                    // Get the corresponding Attendance object from the database
                    Attendance attendanceToDelete = _context.Attendances.Find(attendanceId);

                    // Remove the Attendance object from the database
                    _context.Attendances.Remove(attendanceToDelete);

                    // Save changes to the database
                    _context.SaveChanges();

                    // Display success message
                    MessageBox.Show("Attendance deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView to reflect the changes
                    LoadAttendanceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboClassName.SelectedIndex = 0; // Clear selected item in cboClassName
            cboStudentName.SelectedIndex = 0; // Clear selected item in cboStudentName
            cboStatus.SelectedIndex = 0; // Clear selected item in cboStatus
            dtpAttendanceDate.Value = DateTime.Today; // Reset dtpAttendanceDate to today's date
        }
    }
}
