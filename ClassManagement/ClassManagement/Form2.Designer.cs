namespace ClassManagement
{
    partial class frmClass
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cboSearchStatus = new ComboBox();
            txtSearchSchedule = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtSearchClassName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            cboStatus = new ComboBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            txtSchedule = new TextBox();
            txtClassName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvClass = new DataGridView();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSearchStatus);
            groupBox1.Controls.Add(txtSearchSchedule);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearchClassName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1276, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // cboSearchStatus
            // 
            cboSearchStatus.FormattingEnabled = true;
            cboSearchStatus.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            cboSearchStatus.Location = new Point(824, 35);
            cboSearchStatus.Name = "cboSearchStatus";
            cboSearchStatus.Size = new Size(151, 28);
            cboSearchStatus.TabIndex = 5;
            cboSearchStatus.SelectedIndexChanged += cboSearchStatus_SelectedIndexChanged;
            // 
            // txtSearchSchedule
            // 
            txtSearchSchedule.Location = new Point(483, 36);
            txtSearchSchedule.Name = "txtSearchSchedule";
            txtSearchSchedule.Size = new Size(205, 27);
            txtSearchSchedule.TabIndex = 4;
            txtSearchSchedule.TextChanged += txtSearchSchedule_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(745, 39);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 39);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Schedule";
            // 
            // txtSearchClassName
            // 
            txtSearchClassName.Location = new Point(144, 36);
            txtSearchClassName.Name = "txtSearchClassName";
            txtSearchClassName.Size = new Size(205, 27);
            txtSearchClassName.TabIndex = 1;
            txtSearchClassName.TextChanged += txtSearchClassName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Class Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(dtpEndDate);
            groupBox2.Controls.Add(dtpStartDate);
            groupBox2.Controls.Add(txtSchedule);
            groupBox2.Controls.Add(txtClassName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 537);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Class Management ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(134, 474);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(255, 407);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(134, 407);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(16, 407);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cboStatus.Location = new Point(108, 324);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(250, 28);
            cboStatus.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(108, 188);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(108, 124);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 6;
            // 
            // txtSchedule
            // 
            txtSchedule.Location = new Point(108, 255);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(250, 27);
            txtSchedule.TabIndex = 11;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(108, 52);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(250, 27);
            txtClassName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 124);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 8;
            label8.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 195);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 7;
            label7.Text = "End Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 327);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 258);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Schedule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 52);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Class Name";
            // 
            // dgvClass
            // 
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(406, 121);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 29;
            dgvClass.Size = new Size(882, 537);
            dgvClass.TabIndex = 2;
            dgvClass.SelectionChanged += dgvClass_SelectionChanged;
            // 
            // frmClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 670);
            Controls.Add(dgvClass);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmClass";
            Text = "Class Management";
            Load += frmClass_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvClass;
        private Label label3;
        private Label label2;
        private TextBox txtSearchClassName;
        private BindingSource bindingSource1;
        private TextBox txtSearchSchedule;
        private ComboBox cboSearchStatus;
        private DateTimePicker dtpStartDate;
        private TextBox txtSchedule;
        private TextBox txtClassName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private BindingSource bindingSource2;
        private ComboBox cboStatus;
        private DateTimePicker dtpEndDate;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
        private Button btnDelete;
    }
}