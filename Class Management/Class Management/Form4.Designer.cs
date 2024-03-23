namespace Class_Management
{
    partial class frmMark
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
            txtSearchStudentName = new TextBox();
            txtSearchClassName = new TextBox();
            txtSearchSubject = new TextBox();
            txtSearchMark = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cboStudentName = new ComboBox();
            cboClassName = new ComboBox();
            dtpMarkDate = new DateTimePicker();
            nudMark = new NumericUpDown();
            txtSubject = new TextBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            dgvMark = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMark).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchStudentName);
            groupBox1.Controls.Add(txtSearchClassName);
            groupBox1.Controls.Add(txtSearchSubject);
            groupBox1.Controls.Add(txtSearchMark);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1093, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // txtSearchStudentName
            // 
            txtSearchStudentName.Location = new Point(506, 76);
            txtSearchStudentName.Name = "txtSearchStudentName";
            txtSearchStudentName.Size = new Size(125, 27);
            txtSearchStudentName.TabIndex = 7;
            txtSearchStudentName.TextChanged += txtSearchStudentName_TextChanged;
            // 
            // txtSearchClassName
            // 
            txtSearchClassName.Location = new Point(506, 29);
            txtSearchClassName.Name = "txtSearchClassName";
            txtSearchClassName.Size = new Size(125, 27);
            txtSearchClassName.TabIndex = 6;
            txtSearchClassName.TextChanged += txtSearchClassName_TextChanged;
            // 
            // txtSearchSubject
            // 
            txtSearchSubject.Location = new Point(132, 76);
            txtSearchSubject.Name = "txtSearchSubject";
            txtSearchSubject.Size = new Size(125, 27);
            txtSearchSubject.TabIndex = 5;
            txtSearchSubject.TextChanged += txtSearchSubject_TextChanged;
            // 
            // txtSearchMark
            // 
            txtSearchMark.Location = new Point(132, 30);
            txtSearchMark.Name = "txtSearchMark";
            txtSearchMark.Size = new Size(125, 27);
            txtSearchMark.TabIndex = 4;
            txtSearchMark.TextChanged += txtSearchMark_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 76);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 32);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Class Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Mark";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboStudentName);
            groupBox2.Controls.Add(cboClassName);
            groupBox2.Controls.Add(dtpMarkDate);
            groupBox2.Controls.Add(nudMark);
            groupBox2.Controls.Add(txtSubject);
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mark Management";
            // 
            // cboStudentName
            // 
            cboStudentName.FormattingEnabled = true;
            cboStudentName.Location = new Point(147, 104);
            cboStudentName.Name = "cboStudentName";
            cboStudentName.Size = new Size(151, 28);
            cboStudentName.TabIndex = 19;
            // 
            // cboClassName
            // 
            cboClassName.FormattingEnabled = true;
            cboClassName.Location = new Point(145, 54);
            cboClassName.Name = "cboClassName";
            cboClassName.Size = new Size(151, 28);
            cboClassName.TabIndex = 18;
            cboClassName.SelectedIndexChanged += cboClassName_SelectedIndexChanged;
            // 
            // dtpMarkDate
            // 
            dtpMarkDate.Location = new Point(132, 156);
            dtpMarkDate.Name = "dtpMarkDate";
            dtpMarkDate.Size = new Size(250, 27);
            dtpMarkDate.TabIndex = 17;
            // 
            // nudMark
            // 
            nudMark.DecimalPlaces = 2;
            nudMark.Location = new Point(132, 267);
            nudMark.Name = "nudMark";
            nudMark.Size = new Size(150, 27);
            nudMark.TabIndex = 16;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(132, 213);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(125, 27);
            txtSubject.TabIndex = 15;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(142, 360);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(250, 316);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(142, 316);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 269);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 8;
            label9.Text = "Mark";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 107);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Student Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 216);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 7;
            label8.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 53);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 4;
            label5.Text = "Class Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 161);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "Mark Date";
            // 
            // dgvMark
            // 
            dgvMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMark.Location = new Point(462, 175);
            dgvMark.Name = "dgvMark";
            dgvMark.RowHeadersWidth = 51;
            dgvMark.RowTemplate.Height = 29;
            dgvMark.Size = new Size(643, 426);
            dgvMark.TabIndex = 2;
            dgvMark.SelectionChanged += dgvMark_SelectionChanged;
            // 
            // frmMark
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 626);
            Controls.Add(dgvMark);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmMark";
            Text = "Mark Management";
            Load += frmMark_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMark).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearchStudentName;
        private TextBox txtSearchClassName;
        private TextBox txtSearchSubject;
        private TextBox txtSearchMark;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label7;
        private DataGridView dgvMark;
        private DateTimePicker dtpMarkDate;
        private NumericUpDown nudMark;
        private TextBox txtSubject;
        private ComboBox cboClassName;
        private ComboBox cboStudentName;
    }
}