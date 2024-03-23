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
        private readonly ClassManagement3Context _context;
        private List<Class> _classes;
        private List<Student> _students;
        public frmAttendance()
        {
            InitializeComponent();
            _context = new ClassManagement3Context();
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
            // Temporarily clear the data source to avoid errors
            cboStudentName.DataSource = null;

            // Get the selected class from cboClassName
            Class selectedClass = cboClassName.SelectedItem as Class;
            if (selectedClass != null)
            {
                // Retrieve the students enrolled in the selected class
                var studentsInClass = _context.ClassStudents
                    .Where(cs => cs.ClassId == selectedClass.ClassId)
                    .Select(cs => cs.Student)
                    .ToList();

                // Add the students to the combobox if there are any
                if (studentsInClass.Any())
                {
                    cboStudentName.DisplayMember = "FullName";
                    cboStudentName.DataSource = studentsInClass;
                }
                else
                {
                    // If there are no students enrolled in the class, display a message or handle it accordingly
                    cboStudentName.Items.Add("No students enrolled");
                }
            }
        }
        private void LoadAttendanceData()
        {
            try
            {
                // Define the initial query without filters
                var attendanceQuery = _context.Attendances
                    .Include(a => a.ClassStudent)
                    .ThenInclude(cs => cs.Class)
                    .Include(a => a.ClassStudent)
                    .ThenInclude(cs => cs.Student)
                    .Select(a => new
                    {
                        AttendanceId = a.AttendanceId,
                        ClassName = a.ClassStudent.Class.ClassName,
                        StudentName = a.ClassStudent.Student.FullName,
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

                // Check if the attendance record already exists for the selected class and student on the selected date
                bool attendanceExists = _context.Attendances
                    .Any(a => a.ClassStudent.ClassId == selectedClass.ClassId &&
                              a.ClassStudent.StudentId == selectedStudent.StudentId &&
                              a.AttendanceDate == attendanceDate);

                if (attendanceExists)
                {
                    MessageBox.Show("Attendance record already exists for the selected class, student, and date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create new attendance record
                Attendance newAttendance = new Attendance
                {
                    ClassStudentId = _context.ClassStudents
                        .FirstOrDefault(cs => cs.ClassId == selectedClass.ClassId && cs.StudentId == selectedStudent.StudentId)?.ClassStudentId,
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
                string className = selectedRow.Cells["ClassName"].Value?.ToString() ?? "";
                string studentName = selectedRow.Cells["StudentName"].Value?.ToString() ?? "";
                DateTime attendanceDate = Convert.ToDateTime(selectedRow.Cells["AttendanceDate"].Value);
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                dtpAttendanceDate.Value = attendanceDate;

                // Set the values to the respective ComboBoxes
                Class selectedClass = _classes?.FirstOrDefault(c => c.ClassName == className);

                // Set the selected class item of the ComboBox if it's not null
                if (selectedClass != null)
                {
                    cboClassName.SelectedItem = selectedClass;

                    // Retrieve the students enrolled in the selected class
                    var studentsInClass = _context.ClassStudents
                        .Include(cs => cs.Student)
                        .Where(cs => cs.ClassId == selectedClass.ClassId)
                        .Select(cs => cs.Student)
                        .ToList();

                    // Populate the student ComboBox
                    cboStudentName.DisplayMember = "FullName";
                    cboStudentName.DataSource = studentsInClass;

                    // Find the corresponding student object
                    Student selectedStudent = studentsInClass?.FirstOrDefault(s => s.FullName == studentName);

                    // Set the selected student item of the ComboBox if it's not null
                    if (selectedStudent != null)
                    {
                        cboStudentName.SelectedItem = selectedStudent;
                    }
                    else
                    {
                        cboStudentName.SelectedItem = null;
                    }
                }
                else
                {
                    cboClassName.SelectedItem = null;
                    cboClassName.DataSource = null; // Clear the ComboBox data source
                    cboStudentName.DataSource = null; // Clear the ComboBox data source
                    cboStudentName.SelectedItem = null;
                }

                if (status == "Present")
                {
                    cboStatus.SelectedItem = "Present";
                }
                else
                {
                    cboStatus.SelectedItem = "Absent";
                }
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

                    // Validate the selected class and student
                    if (cboClassName.SelectedItem == null || cboStudentName.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a class and a student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Get the updated values from the controls
                    Class updatedClass = cboClassName.SelectedItem as Class;
                    Student updatedStudent = cboStudentName.SelectedItem as Student;
                    DateTime updatedAttendanceDate = dtpAttendanceDate.Value.Date; // Ensure only date without time
                    int updatedStatusIndex = cboStatus.SelectedIndex;
                    int updatedStatus = updatedStatusIndex == 0 ? 1 : 0; // Present: 1, Absent: 0

                    // Find the corresponding attendance record in the database
                    Attendance attendanceToUpdate = _context.Attendances.Find(attendanceId);

                    if (attendanceToUpdate != null)
                    {
                        // Update the attendance record with the updated values
                        attendanceToUpdate.ClassStudentId = _context.ClassStudents
                            .FirstOrDefault(cs => cs.ClassId == updatedClass.ClassId && cs.StudentId == updatedStudent.StudentId)?.ClassStudentId;
                        attendanceToUpdate.AttendanceDate = updatedAttendanceDate;
                        attendanceToUpdate.AttendanceStatus = updatedStatus;

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

        private void cboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentComboBox();
        }
    }
}
