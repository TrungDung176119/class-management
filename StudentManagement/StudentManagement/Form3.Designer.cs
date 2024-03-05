namespace StudentManagement
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
            label1 = new Label();
            label2 = new Label();
            txtClassID = new TextBox();
            txtClassName = new TextBox();
            label3 = new Label();
            txtInstructor = new TextBox();
            label4 = new Label();
            txtSchedule = new TextBox();
            label5 = new Label();
            txtRoomnumber = new TextBox();
            dgvClass = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            Xóa = new Button();
            btnSave = new Button();
            btnSkip = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 81);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên Lớp Học";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(320, 29);
            txtClassID.Margin = new Padding(5);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(487, 38);
            txtClassID.TabIndex = 2;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(320, 81);
            txtClassName.Margin = new Padding(5);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(487, 38);
            txtClassName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 138);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 4;
            label3.Text = "Người dạy";
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(320, 138);
            txtInstructor.Margin = new Padding(5);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(487, 38);
            txtInstructor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 189);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 31);
            label4.TabIndex = 6;
            label4.Text = "Lịch Học";
            // 
            // txtSchedule
            // 
            txtSchedule.Location = new Point(320, 189);
            txtSchedule.Margin = new Padding(5);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(487, 38);
            txtSchedule.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 246);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 31);
            label5.TabIndex = 8;
            label5.Text = "Số Phòng";
            // 
            // txtRoomnumber
            // 
            txtRoomnumber.Location = new Point(320, 246);
            txtRoomnumber.Margin = new Padding(5);
            txtRoomnumber.Name = "txtRoomnumber";
            txtRoomnumber.Size = new Size(487, 38);
            txtRoomnumber.TabIndex = 9;
            // 
            // dgvClass
            // 
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(20, 294);
            dgvClass.Margin = new Padding(5);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 29;
            dgvClass.Size = new Size(1146, 387);
            dgvClass.TabIndex = 10;
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
            // frmClass
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
            Controls.Add(dgvClass);
            Controls.Add(txtRoomnumber);
            Controls.Add(label5);
            Controls.Add(txtSchedule);
            Controls.Add(label4);
            Controls.Add(txtInstructor);
            Controls.Add(label3);
            Controls.Add(txtClassName);
            Controls.Add(txtClassID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp học";
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtClassID;
        private TextBox txtClassName;
        private Label label3;
        private TextBox txtInstructor;
        private Label label4;
        private TextBox txtSchedule;
        private Label label5;
        private TextBox txtRoomnumber;
        private DataGridView dgvClass;
        private Button btnAdd;
        private Button btnUpdate;
        private Button Xóa;
        private Button btnSave;
        private Button btnSkip;
        private Button btnExit;
    }
}