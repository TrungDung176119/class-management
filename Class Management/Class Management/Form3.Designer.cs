namespace Class_Management
{
    partial class Form3
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSearchName = new TextBox();
            dtpSearchDOB = new DateTimePicker();
            cboSearchGender = new ComboBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            dtpDOB = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label6 = new Label();
            cboGender = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtContactInfo = new TextBox();
            label7 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSearchGender);
            groupBox1.Controls.Add(dtpSearchDOB);
            groupBox1.Controls.Add(txtSearchName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(470, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(804, 452);
            dataGridView1.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 48);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(816, 48);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(140, 41);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(189, 27);
            txtSearchName.TabIndex = 3;
            // 
            // dtpSearchDOB
            // 
            dtpSearchDOB.Location = new Point(500, 43);
            dtpSearchDOB.Name = "dtpSearchDOB";
            dtpSearchDOB.Size = new Size(250, 27);
            dtpSearchDOB.TabIndex = 4;
            // 
            // cboSearchGender
            // 
            cboSearchGender.FormattingEnabled = true;
            cboSearchGender.Items.AddRange(new object[] { "All", "Male", "Female" });
            cboSearchGender.Location = new Point(902, 44);
            cboSearchGender.Name = "cboSearchGender";
            cboSearchGender.Size = new Size(151, 28);
            cboSearchGender.TabIndex = 5;
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
            // txtName
            // 
            txtName.Location = new Point(163, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 6;
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
            // dtpDOB
            // 
            dtpDOB.Location = new Point(163, 119);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 6;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(163, 195);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 6;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(163, 267);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(250, 27);
            txtContactInfo.TabIndex = 7;
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
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(173, 341);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(307, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(173, 397);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 629);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchName;
        private DateTimePicker dtpSearchDOB;
        private ComboBox cboSearchGender;
        private TextBox txtName;
        private Label label4;
        private DateTimePicker dtpDOB;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtContactInfo;
        private ComboBox cboGender;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}