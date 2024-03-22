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
    public partial class frmMark : Form
    {
        private readonly ClassManagementContext _context;
        private DbSet<Mark> _marks;
        private List<Class> _classes;
        private List<Student> _students;
        public frmMark()
        {
            InitializeComponent();
            _context = new ClassManagementContext();
            _marks = _context.Marks;
        }

        private void frmMark_Load(object sender, EventArgs e)
        {
            LoadMarkTable();
            LoadClassComboBox();
            LoadStudentComboBox();
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
        private void LoadMarkTable()
        {
            try
            {
                // Include related entities (Class and Student) in the query
                decimal? markFilter = null;
                if (!string.IsNullOrEmpty(txtSearchMark.Text) && decimal.TryParse(txtSearchMark.Text, out decimal markValue))
                {
                    markFilter = markValue;
                }

                var marksWithDetails = _marks.Include(m => m.Class).Include(m => m.Student).Where(m =>
                    m.Subject.Contains(txtSearchSubject.Text) &&
                    m.Class.ClassName.Contains(txtSearchClassName.Text) &&
                    m.Student.FullName.Contains(txtSearchStudentName.Text) &&
                    (!markFilter.HasValue || m.Mark1 == markFilter)
                );

                // Select the required properties and bind the DataGridView to the result
                dgvMark.DataSource = marksWithDetails.Select(m => new
                {
                    m.MarkId,
                    m.Class.ClassName,
                    StudentName = m.Student.FullName,
                    Mark = m.Mark1,
                    m.MarkDate,
                    m.Subject
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtSearchMark_TextChanged(object sender, EventArgs e)
        {
            LoadMarkTable();
        }

        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            LoadMarkTable();
        }

        private void txtSearchClassName_TextChanged(object sender, EventArgs e)
        {
            LoadMarkTable();
        }

        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {
            LoadMarkTable();
        }

        private void dgvMark_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there's a selected row
            if (dgvMark.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvMark.SelectedRows[0];

                // Retrieve the data from the selected row and populate the ComboBoxes
                string className = selectedRow.Cells["ClassName"].Value?.ToString() ?? "";
                string studentName = selectedRow.Cells["StudentName"].Value?.ToString() ?? "";
                txtSubject.Text = selectedRow.Cells["Subject"].Value.ToString();

                // Find the corresponding class and student objects
                Class selectedClass = _classes.FirstOrDefault(c => c.ClassName == className);
                Student selectedStudent = _students.FirstOrDefault(s => s.FullName == studentName);

                // Set the selected items of the ComboBoxes
                cboClassName.SelectedItem = selectedClass;
                cboStudentName.SelectedItem = selectedStudent;

                // Check if MarkDate value is not null, then assign it to the DateTimePicker
                if (selectedRow.Cells["MarkDate"].Value != DBNull.Value)
                {
                    dtpMarkDate.Value = (DateTime)selectedRow.Cells["MarkDate"].Value;
                }
                else
                {
                    // If MarkDate value is null, set DateTimePicker value to today's date
                    dtpMarkDate.Value = DateTime.Today;
                }

                // Check if Mark value is not null, then assign it to the NumericUpDown control
                if (selectedRow.Cells["Mark"].Value != DBNull.Value)
                {
                    nudMark.Value = Convert.ToDecimal(selectedRow.Cells["Mark"].Value);
                }
                else
                {
                    // If Mark value is null, set NumericUpDown value to 0
                    nudMark.Value = 0;
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Mark object and populate its properties
                Mark newMark = new Mark
                {
                    // Retrieve ClassId and StudentId based on the text entered in the text boxes
                    ClassId = ((Class)cboClassName.SelectedItem)?.ClassId,
                    StudentId = ((Student)cboStudentName.SelectedItem)?.StudentId,
                    MarkDate = dtpMarkDate.Value,
                    Subject = txtSubject.Text,
                    Mark1 = nudMark.Value
                };

                // Add the new Mark object to the DbContext
                _context.Marks.Add(newMark);
                // Save changes to the database
                _context.SaveChanges();

                // Refresh the DataGridView to display the newly added record
                LoadMarkTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if there's a selected row in the DataGridView
            if (dgvMark.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvMark.SelectedRows[0];

                    // Retrieve the MarkId of the selected row
                    int markId = Convert.ToInt32(selectedRow.Cells["MarkId"].Value);

                    // Find the corresponding Mark object in the DbContext
                    Mark markToUpdate = _context.Marks.Find(markId);

                    // Update the properties of the Mark object with the new values from the text boxes and controls
                    markToUpdate.ClassId = ((Class)cboClassName.SelectedItem)?.ClassId;
                    markToUpdate.StudentId = ((Student)cboStudentName.SelectedItem)?.StudentId;
                    markToUpdate.MarkDate = dtpMarkDate.Value;
                    markToUpdate.Subject = txtSubject.Text;
                    markToUpdate.Mark1 = nudMark.Value;

                    // Save changes to the database
                    _context.SaveChanges();

                    // Refresh the DataGridView to reflect the changes
                    LoadMarkTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if there's a selected row in the DataGridView
            if (dgvMark.SelectedRows.Count > 0)
            {
                // Display a confirmation dialog to confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get the MarkId of the selected row
                        int markId = Convert.ToInt32(dgvMark.SelectedRows[0].Cells["MarkId"].Value);

                        // Find the corresponding Mark object in the DbContext
                        Mark markToDelete = _context.Marks.Find(markId);

                        // Remove the Mark object from the DbContext
                        _context.Marks.Remove(markToDelete);

                        // Save changes to the database
                        _context.SaveChanges();

                        // Refresh the DataGridView to reflect the changes
                        LoadMarkTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboClassName.SelectedIndex = -1;
            cboStudentName.SelectedIndex = -1;
            txtSubject.Text = string.Empty;
            dtpMarkDate.Value = DateTime.Today; // Set DateTimePicker value to today's date
            nudMark.Value = 0; // Set NumericUpDown value to 0
        }
    }
}
