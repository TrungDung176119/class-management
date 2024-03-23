namespace Class_Management
{
    partial class frmClassStudent
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
            txtSearchClassName = new TextBox();
            txtSearchStudentName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cboSchedule = new ComboBox();
            btnRemove = new Button();
            btnChange = new Button();
            btnJoin = new Button();
            txtContactInfo = new TextBox();
            label7 = new Label();
            cboClassName = new ComboBox();
            cboStudentName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvClassStudent = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassStudent).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSearchGender);
            groupBox1.Controls.Add(txtSearchClassName);
            groupBox1.Controls.Add(txtSearchStudentName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(998, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // cboSearchGender
            // 
            cboSearchGender.FormattingEnabled = true;
            cboSearchGender.Items.AddRange(new object[] { "All", "Male", "Female" });
            cboSearchGender.Location = new Point(747, 49);
            cboSearchGender.Name = "cboSearchGender";
            cboSearchGender.Size = new Size(151, 28);
            cboSearchGender.TabIndex = 5;
            cboSearchGender.SelectedIndexChanged += cboSearchGender_SelectedIndexChanged;
            // 
            // txtSearchClassName
            // 
            txtSearchClassName.Location = new Point(496, 46);
            txtSearchClassName.Name = "txtSearchClassName";
            txtSearchClassName.Size = new Size(161, 27);
            txtSearchClassName.TabIndex = 4;
            txtSearchClassName.TextChanged += txtSearchClassName_TextChanged;
            // 
            // txtSearchStudentName
            // 
            txtSearchStudentName.Location = new Point(181, 46);
            txtSearchStudentName.Name = "txtSearchStudentName";
            txtSearchStudentName.Size = new Size(203, 27);
            txtSearchStudentName.TabIndex = 3;
            txtSearchStudentName.TextChanged += txtSearchStudentName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(669, 49);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 49);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Class Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboSchedule);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(btnChange);
            groupBox2.Controls.Add(btnJoin);
            groupBox2.Controls.Add(txtContactInfo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboClassName);
            groupBox2.Controls.Add(cboStudentName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 403);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Join Student";
            // 
            // cboSchedule
            // 
            cboSchedule.FormattingEnabled = true;
            cboSchedule.Location = new Point(116, 214);
            cboSchedule.Name = "cboSchedule";
            cboSchedule.Size = new Size(246, 28);
            cboSchedule.TabIndex = 16;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(119, 349);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 29);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove Class";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(201, 296);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(120, 29);
            btnChange.TabIndex = 14;
            btnChange.Text = "Change Class";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(60, 296);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(94, 29);
            btnJoin.TabIndex = 13;
            btnJoin.Text = "Join Class";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Enabled = false;
            txtContactInfo.Location = new Point(117, 100);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(251, 27);
            txtContactInfo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 107);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 11;
            label7.Text = "Contact Info";
            // 
            // cboClassName
            // 
            cboClassName.FormattingEnabled = true;
            cboClassName.Location = new Point(119, 157);
            cboClassName.Name = "cboClassName";
            cboClassName.Size = new Size(249, 28);
            cboClassName.TabIndex = 9;
            cboClassName.SelectedIndexChanged += cboClassName_SelectedIndexChanged;
            // 
            // cboStudentName
            // 
            cboStudentName.FormattingEnabled = true;
            cboStudentName.Location = new Point(116, 43);
            cboStudentName.Name = "cboStudentName";
            cboStudentName.Size = new Size(249, 28);
            cboStudentName.TabIndex = 8;
            cboStudentName.SelectedIndexChanged += cboStudentName_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 214);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 7;
            label6.Text = "Schedule";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 165);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 6;
            label5.Text = "Class Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 46);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Student Name";
            // 
            // dgvClassStudent
            // 
            dgvClassStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassStudent.Location = new Point(404, 153);
            dgvClassStudent.Name = "dgvClassStudent";
            dgvClassStudent.RowHeadersWidth = 51;
            dgvClassStudent.RowTemplate.Height = 29;
            dgvClassStudent.Size = new Size(606, 403);
            dgvClassStudent.TabIndex = 2;
            dgvClassStudent.SelectionChanged += dgvClassStudent_SelectionChanged;
            // 
            // frmClassStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 568);
            Controls.Add(dgvClassStudent);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmClassStudent";
            Text = "Class And Student";
            Load += frmClassStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearchClassName;
        private TextBox txtSearchStudentName;
        private ComboBox cboSearchGender;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private ComboBox cboClassName;
        private ComboBox cboStudentName;
        private Button btnJoin;
        private TextBox txtContactInfo;
        private Button btnChange;
        private DataGridView dgvClassStudent;
        private Button btnRemove;
        private ComboBox cboSchedule;
    }
}