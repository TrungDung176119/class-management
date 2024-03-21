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
                .Select(c => new
                {
                    ID = c.ClassId,
                    Name = c.ClassName,
                    StartDate = c.ClassStartDate,
                    EndDate = c.ClassEndDate,
                    c.Schedule,
                    Status = c.ClassStatus.HasValue ? statusMappings[c.ClassStatus.Value] : "Unknown"
                }).ToList();

            dgvClass.DataSource = classes;
        }
        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            cboSearchStatus.SelectedIndex = cboStatus.SelectedIndex = 0;
        }
        private void cboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
