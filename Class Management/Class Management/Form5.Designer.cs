namespace Class_Management
{
    partial class frmAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboSearchStatus = new ComboBox();
            txtSearchClassName = new TextBox();
            txtSearchStudentName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            cboStatus = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            cboStudentName = new ComboBox();
            cboClassName = new ComboBox();
            dtpAttendanceDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            dgvAttendance = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSearchStatus);
            groupBox1.Controls.Add(txtSearchClassName);
            groupBox1.Controls.Add(txtSearchStudentName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1207, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // cboSearchStatus
            // 
            cboSearchStatus.FormattingEnabled = true;
            cboSearchStatus.Items.AddRange(new object[] { "All", "Present", "Absent" });
            cboSearchStatus.Location = new Point(838, 48);
            cboSearchStatus.Name = "cboSearchStatus";
            cboSearchStatus.Size = new Size(151, 28);
            cboSearchStatus.TabIndex = 5;
            cboSearchStatus.SelectedIndexChanged += cboSearchStatus_SelectedIndexChanged;
            // 
            // txtSearchClassName
            // 
            txtSearchClassName.Location = new Point(541, 44);
            txtSearchClassName.Name = "txtSearchClassName";
            txtSearchClassName.Size = new Size(125, 27);
            txtSearchClassName.TabIndex = 4;
            txtSearchClassName.TextChanged += txtSearchClassName_TextChanged;
            // 
            // txtSearchStudentName
            // 
            txtSearchStudentName.Location = new Point(176, 44);
            txtSearchStudentName.Name = "txtSearchStudentName";
            txtSearchStudentName.Size = new Size(125, 27);
            txtSearchStudentName.TabIndex = 3;
            txtSearchStudentName.TextChanged += txtSearchStudentName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(749, 51);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 51);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Class Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cboStudentName);
            groupBox2.Controls.Add(cboClassName);
            groupBox2.Controls.Add(dtpAttendanceDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 504);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Attendance";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(165, 378);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(302, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(165, 307);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Present", "Absent" });
            cboStatus.Location = new Point(156, 229);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 171);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 11;
            label7.Text = "Attendance Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 232);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "Status";
            // 
            // cboStudentName
            // 
            cboStudentName.FormattingEnabled = true;
            cboStudentName.Location = new Point(156, 113);
            cboStudentName.Name = "cboStudentName";
            cboStudentName.Size = new Size(151, 28);
            cboStudentName.TabIndex = 9;
            // 
            // cboClassName
            // 
            cboClassName.FormattingEnabled = true;
            cboClassName.Location = new Point(156, 68);
            cboClassName.Name = "cboClassName";
            cboClassName.Size = new Size(151, 28);
            cboClassName.TabIndex = 8;
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(156, 164);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(250, 27);
            dtpAttendanceDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 6;
            label5.Text = "Class Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 113);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Student Name";
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(477, 155);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 29;
            dgvAttendance.Size = new Size(742, 504);
            dgvAttendance.TabIndex = 2;
            dgvAttendance.SelectionChanged += dgvAttendance_SelectionChanged;
            // 
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 671);
            Controls.Add(dgvAttendance);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmAttendance";
            Text = "Attendance";
            Load += frmAttendance_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvAttendance;
        private ComboBox cboSearchStatus;
        private TextBox txtSearchClassName;
        private TextBox txtSearchStudentName;
        private ComboBox cboStatus;
        private Label label7;
        private Label label6;
        private ComboBox cboStudentName;
        private ComboBox cboClassName;
        private DateTimePicker dtpAttendanceDate;
        private Label label5;
        private Label label4;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}