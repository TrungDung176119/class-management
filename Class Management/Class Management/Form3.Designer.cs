namespace Class_Management
{
    partial class frmStudent
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
            cboSearchGender = new ComboBox();
            txtSearchName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label7 = new Label();
            txtContactInfo = new TextBox();
            cboGender = new ComboBox();
            label6 = new Label();
            dtpDOB = new DateTimePicker();
            label5 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            dgvStudent = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSearchGender);
            groupBox1.Controls.Add(txtSearchName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1155, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // cboSearchGender
            // 
            cboSearchGender.FormattingEnabled = true;
            cboSearchGender.Items.AddRange(new object[] { "All", "Male", "Female" });
            cboSearchGender.Location = new Point(502, 40);
            cboSearchGender.Name = "cboSearchGender";
            cboSearchGender.Size = new Size(151, 28);
            cboSearchGender.TabIndex = 5;
            cboSearchGender.SelectedIndexChanged += cboSearchGender_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(140, 41);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(189, 27);
            txtSearchName.TabIndex = 3;
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 52);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtContactInfo);
            groupBox2.Controls.Add(cboGender);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpDOB);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 462);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Management";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(173, 397);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(307, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(173, 341);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 274);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 8;
            label7.Text = "Contact info";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(163, 267);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(250, 27);
            txtContactInfo.TabIndex = 7;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(163, 195);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 203);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 6;
            label6.Text = "Gender";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(163, 119);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 124);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 6;
            label5.Text = "Date of birth";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 48);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(470, 164);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(697, 452);
            dgvStudent.TabIndex = 2;
            dgvStudent.SelectionChanged += dgvStudent_SelectionChanged;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 629);
            Controls.Add(dgvStudent);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmStudent";
            Text = "Student Management";
            Load += frmStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvStudent;
        private Label label1;
        private Label label3;
        private TextBox txtSearchName;
        private ComboBox cboSearchGender;
        private TextBox txtName;
        private Label label4;
        private DateTimePicker dtpDOB;
        private Label label5;
        private TextBox txtContactInfo;
        private ComboBox cboGender;
        private Label label6;
        private Label label7;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}