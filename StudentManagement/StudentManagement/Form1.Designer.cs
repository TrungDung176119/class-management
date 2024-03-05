namespace StudentManagement
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuManager = new ToolStripMenuItem();
            mnuClass = new ToolStripMenuItem();
            mnuStudent = new ToolStripMenuItem();
            mnuMark = new ToolStripMenuItem();
            mnuPayment = new ToolStripMenuItem();
            mnuAttendance = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            mnuFindStudent = new ToolStripMenuItem();
            mnuFindAttendance = new ToolStripMenuItem();
            mnuFindPayment = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAppearHelp = new ToolStripMenuItem();
            mnuAboutUs = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuManager, mnuAttendance, mnuSearch, mnuReport, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1182, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(72, 24);
            mnuFile.Text = "Tệp Tin";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(130, 26);
            mnuExit.Text = "Thoát";
            // 
            // mnuManager
            // 
            mnuManager.DropDownItems.AddRange(new ToolStripItem[] { mnuClass, mnuStudent, mnuMark, mnuPayment });
            mnuManager.Name = "mnuManager";
            mnuManager.Size = new Size(73, 24);
            mnuManager.Text = "Quản lý";
            // 
            // mnuClass
            // 
            mnuClass.Name = "mnuClass";
            mnuClass.Size = new Size(151, 26);
            mnuClass.Text = "Lớp Học";
            // 
            // mnuStudent
            // 
            mnuStudent.Name = "mnuStudent";
            mnuStudent.Size = new Size(151, 26);
            mnuStudent.Text = "Học Sinh";
            // 
            // mnuMark
            // 
            mnuMark.Name = "mnuMark";
            mnuMark.Size = new Size(151, 26);
            mnuMark.Text = "Điểm số";
            // 
            // mnuPayment
            // 
            mnuPayment.Name = "mnuPayment";
            mnuPayment.Size = new Size(151, 26);
            mnuPayment.Text = "Học Phí";
            // 
            // mnuAttendance
            // 
            mnuAttendance.Name = "mnuAttendance";
            mnuAttendance.Size = new Size(96, 24);
            mnuAttendance.Text = "Điểm danh";
            // 
            // mnuSearch
            // 
            mnuSearch.DropDownItems.AddRange(new ToolStripItem[] { mnuFindStudent, mnuFindAttendance, mnuFindPayment });
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(84, 24);
            mnuSearch.Text = "Tìm kiếm";
            // 
            // mnuFindStudent
            // 
            mnuFindStudent.Name = "mnuFindStudent";
            mnuFindStudent.Size = new Size(228, 26);
            mnuFindStudent.Text = "Tìm kiếm học sinh";
            // 
            // mnuFindAttendance
            // 
            mnuFindAttendance.Name = "mnuFindAttendance";
            mnuFindAttendance.Size = new Size(228, 26);
            mnuFindAttendance.Text = "Tìm kiếm điểm danh";
            // 
            // mnuFindPayment
            // 
            mnuFindPayment.Name = "mnuFindPayment";
            mnuFindPayment.Size = new Size(228, 26);
            mnuFindPayment.Text = "Tìm kiếm học phí";
            // 
            // mnuReport
            // 
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(77, 24);
            mnuReport.Text = "Báo cáo";
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAppearHelp, mnuAboutUs });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(78, 24);
            mnuHelp.Text = "Trợ giúp";
            // 
            // mnuAppearHelp
            // 
            mnuAppearHelp.Name = "mnuAppearHelp";
            mnuAppearHelp.Size = new Size(175, 26);
            mnuAppearHelp.Text = "Trợ Giúp";
            // 
            // mnuAboutUs
            // 
            mnuAboutUs.Name = "mnuAboutUs";
            mnuAboutUs.Size = new Size(175, 26);
            mnuAboutUs.Text = "Về chúng tôi";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuManager;
        private ToolStripMenuItem mnuClass;
        private ToolStripMenuItem mnuStudent;
        private ToolStripMenuItem mnuMark;
        private ToolStripMenuItem mnuPayment;
        private ToolStripMenuItem mnuAttendance;
        private ToolStripMenuItem mnuSearch;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAppearHelp;
        private ToolStripMenuItem mnuAboutUs;
        private ToolStripMenuItem mnuFindStudent;
        private ToolStripMenuItem mnuFindAttendance;
        private ToolStripMenuItem mnuFindPayment;
    }
}