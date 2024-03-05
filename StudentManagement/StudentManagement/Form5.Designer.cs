namespace StudentManagement
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
            label1 = new Label();
            label2 = new Label();
            txtPaymentID = new TextBox();
            txtStudentID = new TextBox();
            label3 = new Label();
            txtAmount = new TextBox();
            label4 = new Label();
            txtPaymentDate = new TextBox();
            label5 = new Label();
            txtPaymentStatus = new TextBox();
            dgvPayment = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            Xóa = new Button();
            btnSave = new Button();
            btnSkip = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã học phí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 81);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 1;
            label2.Text = "Mã Học Sinh";
            // 
            // txtPaymentID
            // 
            txtPaymentID.Location = new Point(320, 29);
            txtPaymentID.Margin = new Padding(5);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(487, 38);
            txtPaymentID.TabIndex = 2;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(320, 81);
            txtStudentID.Margin = new Padding(5);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(487, 38);
            txtStudentID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 138);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 4;
            label3.Text = "Số tiền";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(320, 138);
            txtAmount.Margin = new Padding(5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(487, 38);
            txtAmount.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 189);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 31);
            label4.TabIndex = 6;
            label4.Text = "Ngày";
            // 
            // txtPaymentDate
            // 
            txtPaymentDate.Location = new Point(320, 189);
            txtPaymentDate.Margin = new Padding(5);
            txtPaymentDate.Name = "txtPaymentDate";
            txtPaymentDate.Size = new Size(487, 38);
            txtPaymentDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 246);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 31);
            label5.TabIndex = 8;
            label5.Text = "Trạng thái";
            // 
            // txtPaymentStatus
            // 
            txtPaymentStatus.Location = new Point(320, 246);
            txtPaymentStatus.Margin = new Padding(5);
            txtPaymentStatus.Name = "txtPaymentStatus";
            txtPaymentStatus.Size = new Size(487, 38);
            txtPaymentStatus.TabIndex = 9;
            // 
            // dgvPayment
            // 
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(20, 294);
            dgvPayment.Margin = new Padding(5);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.RowTemplate.Height = 29;
            dgvPayment.Size = new Size(1146, 387);
            dgvPayment.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 701);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(212, 701);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(185, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Xóa
            // 
            Xóa.Location = new Point(403, 701);
            Xóa.Name = "Xóa";
            Xóa.Size = new Size(185, 40);
            Xóa.TabIndex = 13;
            Xóa.Text = "Xóa";
            Xóa.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(594, 701);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 40);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(785, 701);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(185, 40);
            btnSkip.TabIndex = 15;
            btnSkip.Text = "Bỏ qua";
            btnSkip.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(976, 701);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(185, 40);
            btnExit.TabIndex = 16;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(btnExit);
            Controls.Add(btnSkip);
            Controls.Add(btnSave);
            Controls.Add(Xóa);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvPayment);
            Controls.Add(txtPaymentStatus);
            Controls.Add(label5);
            Controls.Add(txtPaymentDate);
            Controls.Add(label4);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(txtPaymentID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý học phí";
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPaymentID;
        private TextBox txtStudentID;
        private Label label3;
        private TextBox txtAmount;
        private Label label4;
        private TextBox txtPaymentDate;
        private Label label5;
        private TextBox txtPaymentStatus;
        private DataGridView dgvPayment;
        private Button btnAdd;
        private Button btnUpdate;
        private Button Xóa;
        private Button btnSave;
        private Button btnSkip;
        private Button btnExit;
    }
}