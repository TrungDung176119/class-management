﻿namespace Class_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuManager = new ToolStripMenuItem();
            mnuClass = new ToolStripMenuItem();
            mnuStudent = new ToolStripMenuItem();
            mnuMark = new ToolStripMenuItem();
            mnuPayment = new ToolStripMenuItem();
            mnuAttendance = new ToolStripMenuItem();
            mnuClassAndStudent = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuManager, mnuAttendance, mnuClassAndStudent });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuManager
            // 
            mnuManager.DropDownItems.AddRange(new ToolStripItem[] { mnuClass, mnuStudent, mnuMark, mnuPayment });
            mnuManager.Name = "mnuManager";
            mnuManager.Size = new Size(111, 24);
            mnuManager.Text = "Management";
            // 
            // mnuClass
            // 
            mnuClass.Name = "mnuClass";
            mnuClass.Size = new Size(148, 26);
            mnuClass.Text = "Class";
            mnuClass.Click += mnuClass_Click;
            // 
            // mnuStudent
            // 
            mnuStudent.Name = "mnuStudent";
            mnuStudent.Size = new Size(148, 26);
            mnuStudent.Text = "Student";
            mnuStudent.Click += mnuStudent_Click;
            // 
            // mnuMark
            // 
            mnuMark.Name = "mnuMark";
            mnuMark.Size = new Size(148, 26);
            mnuMark.Text = "Mark";
            mnuMark.Click += mnuMark_Click;
            // 
            // mnuPayment
            // 
            mnuPayment.Name = "mnuPayment";
            mnuPayment.Size = new Size(148, 26);
            mnuPayment.Text = "Payment";
            mnuPayment.Click += mnuPayment_Click;
            // 
            // mnuAttendance
            // 
            mnuAttendance.Name = "mnuAttendance";
            mnuAttendance.Size = new Size(99, 24);
            mnuAttendance.Text = "Attendance";
            mnuAttendance.Click += mnuAttendance_Click;
            // 
            // mnuClassAndStudent
            // 
            mnuClassAndStudent.Name = "mnuClassAndStudent";
            mnuClassAndStudent.Size = new Size(140, 24);
            mnuClassAndStudent.Text = "Class and Student";
            mnuClassAndStudent.Click += mnuClassAndStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Home Page";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuManager;
        private ToolStripMenuItem mnuClass;
        private ToolStripMenuItem mnuStudent;
        private ToolStripMenuItem mnuMark;
        private ToolStripMenuItem mnuPayment;
        private ToolStripMenuItem mnuAttendance;
        private ToolStripMenuItem mnuClassAndStudent;
    }
}
