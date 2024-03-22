namespace Class_Management
{
    partial class frmPayment
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
            cboSearchStatus = new ComboBox();
            label3 = new Label();
            cboSearchMethod = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRefresh = new Button();
            btnEdit = new Button();
            txtMethod = new TextBox();
            cboStatus = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtAmount = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dtpPaymentDate = new DateTimePicker();
            txtStudentName = new TextBox();
            label4 = new Label();
            dgvPayment = new DataGridView();
            btnLoad = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchStudentName);
            groupBox1.Controls.Add(cboSearchStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboSearchMethod);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1196, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // txtSearchStudentName
            // 
            txtSearchStudentName.Location = new Point(197, 54);
            txtSearchStudentName.Name = "txtSearchStudentName";
            txtSearchStudentName.Size = new Size(125, 27);
            txtSearchStudentName.TabIndex = 5;
            txtSearchStudentName.TextChanged += txtSearchStudentName_TextChanged;
            // 
            // cboSearchStatus
            // 
            cboSearchStatus.FormattingEnabled = true;
            cboSearchStatus.Items.AddRange(new object[] { "All", "Pending", "Payed" });
            cboSearchStatus.Location = new Point(838, 55);
            cboSearchStatus.Name = "cboSearchStatus";
            cboSearchStatus.Size = new Size(151, 28);
            cboSearchStatus.TabIndex = 4;
            cboSearchStatus.SelectedIndexChanged += cboSearchStatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(734, 53);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // cboSearchMethod
            // 
            cboSearchMethod.FormattingEnabled = true;
            cboSearchMethod.Location = new Point(463, 52);
            cboSearchMethod.Name = "cboSearchMethod";
            cboSearchMethod.Size = new Size(151, 28);
            cboSearchMethod.TabIndex = 2;
            cboSearchMethod.SelectedIndexChanged += cboSearchMethod_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Method";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 53);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(txtMethod);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtpPaymentDate);
            groupBox2.Controls.Add(txtStudentName);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(39, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 498);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Management";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(246, 427);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(78, 427);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtMethod
            // 
            txtMethod.Location = new Point(150, 287);
            txtMethod.Name = "txtMethod";
            txtMethod.Size = new Size(250, 27);
            txtMethod.TabIndex = 14;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Pending", "Payed" });
            cboStatus.Location = new Point(150, 355);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(249, 28);
            cboStatus.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 358);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 13;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 294);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 12;
            label7.Text = "Payment Method";
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Location = new Point(149, 216);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 27);
            txtAmount.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 216);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 9;
            label6.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 140);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Enabled = false;
            dtpPaymentDate.Location = new Point(149, 135);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(250, 27);
            dtpPaymentDate.TabIndex = 7;
            // 
            // txtStudentName
            // 
            txtStudentName.Enabled = false;
            txtStudentName.Location = new Point(149, 75);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(250, 27);
            txtStudentName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 78);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Student Name";
            // 
            // dgvPayment
            // 
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(464, 239);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.RowTemplate.Height = 29;
            dgvPayment.Size = new Size(765, 433);
            dgvPayment.TabIndex = 2;
            dgvPayment.SelectionChanged += dgvPayment_SelectionChanged;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(464, 204);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 684);
            Controls.Add(btnLoad);
            Controls.Add(dgvPayment);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPayment";
            Text = "Payment Management";
            Load += frmPayment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvPayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboSearchMethod;
        private ComboBox cboSearchStatus;
        private TextBox txtSearchStudentName;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpPaymentDate;
        private Label label6;
        private TextBox txtAmount;
        private Label label7;
        private Label label8;
        private ComboBox cboStatus;
        private TextBox txtMethod;
        private Button btnRefresh;
        private Button btnEdit;
        private TextBox txtStudentName;
        private Button btnLoad;
    }
}