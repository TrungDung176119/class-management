﻿using Class_Management.Models;
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
    public partial class frmStudent : Form
    {
        private readonly ClassManagementContext _context;
        public frmStudent()
        {
            InitializeComponent();
            _context = new ClassManagementContext();
            cboSearchGender.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
        }

        private void LoadStudents()
        {
            // Get search criteria from UI controls
            string searchName = txtSearchName.Text.Trim();
            string searchGender = cboSearchGender.SelectedIndex == 0 ? "" : cboSearchGender.SelectedItem.ToString();

            // Query to fetch students with optional filtering
            var query = _context.Students
                        .Select(s => new
                        {
                            s.StudentId,
                            s.FullName,
                            s.DateOfBirth,
                            s.Gender,
                            s.ContactInfo
                        });

            // Apply filtering based on search criteria
            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(s => s.FullName.Contains(searchName));
            }

            if (!string.IsNullOrEmpty(searchGender))
            {
                query = query.Where(s => s.Gender == searchGender);
            }

            // Execute the query and retrieve results
            var students = query.ToList();

            // Bind the filtered student data to the DataGridView
            dgvStudent.DataSource = students;
        }


        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Retrieve data from input controls
            string fullName = txtName.Text.Trim();
            DateTime dateOfBirth = dtpDOB.Value;
            string gender = cboGender.SelectedItem.ToString();
            string contactInfo = txtContactInfo.Text.Trim();

            // Validate input data (optional)
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please enter valid student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create a new Student object
                Student newStudent = new Student
                {
                    FullName = fullName,
                    DateOfBirth = dateOfBirth,
                    Gender = gender,
                    ContactInfo = contactInfo
                };

                // Add the new student to the database context
                _context.Students.Add(newStudent);
                // Save changes to the database
                _context.SaveChanges();

                // Refresh the DataGridView to display the new student
                LoadStudents();

                MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }
            int studentID = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["ID"].Value);

            string name = txtName.Text;
            DateTime dateOfBirth = dtpDOB.Value.Date;
            string gender = cboGender.SelectedIndex == 0 ? "Male": "Female"; // Selected Day of Week
            string contactInfo = txtContactInfo.Text;

            // Validate input data
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactInfo))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtpDOB.Value = DateTime.Now;
            cboGender.SelectedIndex = 0;
            txtContactInfo.Text = "";
        }

        private void cboSearchGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudent.SelectedRows[0];

                // Retrieve student information from the selected row
                int studentId = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);
                string fullName = Convert.ToString(selectedRow.Cells["FullName"].Value);
                DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                string gender = Convert.ToString(selectedRow.Cells["Gender"].Value);
                string contactInfo = Convert.ToString(selectedRow.Cells["ContactInfo"].Value);

                // Update information displayed in groupBox2 controls
                txtName.Text = fullName;
                dtpDOB.Value = dateOfBirth;
                cboGender.SelectedItem = gender;
                txtContactInfo.Text = contactInfo;
            }
        }
    }
}
