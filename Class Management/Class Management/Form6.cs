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
    public partial class frmPayment : Form
    {
        private readonly ClassManagementContext _context;
        private List<Payment> payments;
        private List<Student> _students;
        public frmPayment()
        {
            InitializeComponent();
            _context = new ClassManagementContext();
            cboSearchStatus.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            LoadMethodComboBox();
        }

        private void LoadMethodComboBox()
        {
            try
            {
                // Retrieve distinct payment methods from the Payment table
                var paymentMethods = _context.Payments
                    .Select(p => p.PaymentMethod)
                    .Distinct()
                    .ToList();

                // Add "All" as the first item in the payment methods list
                paymentMethods.Insert(0, "All");

                // Set up the ComboBox cboSearchMethod
                cboSearchMethod.DataSource = paymentMethods;
                cboSearchMethod.SelectedIndex = 0; // Select "All" by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void LoadDataPayment()
        {
            try
            {
                // Get the selected values from the filter controls
                string searchMethod = cboSearchMethod.Text;
                int searchStatusIndex = cboSearchStatus.SelectedIndex;
                string searchStudentName = txtSearchStudentName.Text;

                // Query to filter payments based on the selected criteria
                var filteredPayments = _context.Payments.AsQueryable();

                // Filter by payment method if selected
                if (!string.IsNullOrEmpty(searchMethod) && searchMethod != "All")
                {
                    filteredPayments = filteredPayments.Where(p => p.PaymentMethod == searchMethod);
                }

                // Filter by payment status if selected
                if (searchStatusIndex == 1)
                {
                    // Filter for "Pending"
                    filteredPayments = filteredPayments.Where(p => p.PaymentStatus == 0);
                }
                else if (searchStatusIndex == 2)
                {
                    // Filter for "Payed"
                    filteredPayments = filteredPayments.Where(p => p.PaymentStatus == 1);
                }

                // Filter by student name if provided
                if (!string.IsNullOrEmpty(searchStudentName))
                {
                    filteredPayments = filteredPayments.Where(p => p.Student.FullName.Contains(searchStudentName));
                }

                // Load the filtered payments into the DataGridView
                dgvPayment.DataSource = filteredPayments.Select(p => new
                {
                    p.PaymentId,
                    StudentName = p.Student.FullName,
                    p.PaymentDate,
                    p.Amount,
                    p.PaymentMethod,
                    Status = p.PaymentStatus == 1 ? "Payed" : "Pending",
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadDataPayment();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Query to find students with attendance counts divisible by 10
                var studentsWithDivisibleAttendance = _context.Attendances
                    .GroupBy(a => a.StudentId)
                    .Select(g => new
                    {
                        StudentID = g.Key,
                        AttendanceCount = g.Count()
                    })
                    .Where(s => s.AttendanceCount >= 10 && s.AttendanceCount % 10 == 0)
                    .ToList();

                foreach (var student in studentsWithDivisibleAttendance)
                {
                    // Get the last attendance date for the student
                    var lastAttendanceDate = _context.Attendances
                        .Where(a => a.StudentId == student.StudentID)
                        .OrderByDescending(a => a.AttendanceDate)
                        .Select(a => a.AttendanceDate)
                        .FirstOrDefault();

                    // Determine the number of payment records to add
                    int numberOfPayments = student.AttendanceCount / 10;

                    // Add payment records for the student
                    for (int i = 0; i < numberOfPayments; i++)
                    {
                        _context.Payments.Add(new Payment
                        {
                            StudentId = student.StudentID,
                            PaymentDate = lastAttendanceDate,
                            Amount = 500,
                            PaymentMethod = "None",
                            PaymentStatus = 0
                        });
                    }
                }

                // Save changes to the database
                _context.SaveChanges();

                MessageBox.Show($"Added payment records for {studentsWithDivisibleAttendance.Count} students.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {
            LoadDataPayment();
        }

        private void cboSearchMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataPayment();
        }

        private void cboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataPayment();
        }

        private void dgvPayment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPayment.SelectedRows[0];


                string studentName = selectedRow.Cells["StudentName"].Value?.ToString() ?? "";
                string status = Convert.ToString(selectedRow.Cells["Status"].Value);
                string paymentMethod = selectedRow.Cells["PaymentMethod"].Value?.ToString() ?? "";

                if (selectedRow.Cells["PaymentDate"].Value != DBNull.Value)
                {
                    dtpPaymentDate.Value = (DateTime)selectedRow.Cells["PaymentDate"].Value;
                }
                else
                {
                    // If MarkDate value is null, set DateTimePicker value to today's date
                    dtpPaymentDate.Value = DateTime.Today;
                }
                txtMethod.Text = paymentMethod;
                txtStudentName.Text = studentName;
                cboStatus.SelectedItem = status;

                if (selectedRow.Cells["Amount"].Value != DBNull.Value)
                {
                    txtAmount.Text = Convert.ToDecimal(selectedRow.Cells["Amount"].Value).ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected payment record
                if (dgvPayment.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPayment.SelectedRows[0];
                    int paymentId = Convert.ToInt32(selectedRow.Cells["PaymentId"].Value);

                    // Find the payment record in the context
                    var payment = _context.Payments.FirstOrDefault(p => p.PaymentId == paymentId);
                    if (payment != null)
                    {
                        // Update the payment record with the new values
                        payment.PaymentMethod = txtMethod.Text;
                        payment.PaymentStatus = cboStatus.SelectedIndex;

                        // Save changes to the database
                        _context.SaveChanges();
                        LoadDataPayment();

                        MessageBox.Show("Payment record updated successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a payment record to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMethod.Text = "";
            txtAmount.Text = "";
            txtStudentName.Text = "";

            dtpPaymentDate.Value = DateTime.Now;

            cboStatus.SelectedIndex = 0; 
        }
    }
}
