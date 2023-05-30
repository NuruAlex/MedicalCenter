namespace MedicalCenter.Doctors
{
    partial class AppointmentReportInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentReportInformation));
            this.ReposrtInfo = new System.Windows.Forms.GroupBox();
            this.ReportInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppointmentInfo = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SaveFileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечататьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReposrtInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SaveFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReposrtInfo
            // 
            this.ReposrtInfo.Controls.Add(this.ReportInfo);
            this.ReposrtInfo.Location = new System.Drawing.Point(421, 68);
            this.ReposrtInfo.Name = "ReposrtInfo";
            this.ReposrtInfo.Size = new System.Drawing.Size(341, 394);
            this.ReposrtInfo.TabIndex = 3;
            this.ReposrtInfo.TabStop = false;
            this.ReposrtInfo.Text = "Информация об отчете";
            // 
            // ReportInfo
            // 
            this.ReportInfo.AutoSize = true;
            this.ReportInfo.Location = new System.Drawing.Point(30, 34);
            this.ReportInfo.Name = "ReportInfo";
            this.ReportInfo.Size = new System.Drawing.Size(0, 13);
            this.ReportInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AppointmentInfo);
            this.groupBox1.Location = new System.Drawing.Point(34, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о записи";
            // 
            // AppointmentInfo
            // 
            this.AppointmentInfo.AutoSize = true;
            this.AppointmentInfo.Location = new System.Drawing.Point(19, 64);
            this.AppointmentInfo.Name = "AppointmentInfo";
            this.AppointmentInfo.Size = new System.Drawing.Size(0, 13);
            this.AppointmentInfo.TabIndex = 0;
            // 
            // SaveFileMenu
            // 
            this.SaveFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.распечататьToolStripMenuItem});
            this.SaveFileMenu.Name = "SaveFileMenu";
            this.SaveFileMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как..";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // распечататьToolStripMenuItem
            // 
            this.распечататьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("распечататьToolStripMenuItem.Image")));
            this.распечататьToolStripMenuItem.Name = "распечататьToolStripMenuItem";
            this.распечататьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.распечататьToolStripMenuItem.Text = "Распечатать";
            this.распечататьToolStripMenuItem.Click += new System.EventHandler(this.распечататьToolStripMenuItem_Click);
            // 
            // AppointmentReportInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 508);
            this.ContextMenuStrip = this.SaveFileMenu;
            this.Controls.Add(this.ReposrtInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppointmentReportInformation";
            this.Text = "AppointmentReportInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentReportInformation_FormClosed);
            this.Load += new System.EventHandler(this.AppointmentReportInformation_Load);
            this.ReposrtInfo.ResumeLayout(false);
            this.ReposrtInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SaveFileMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReposrtInfo;
        private System.Windows.Forms.Label ReportInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AppointmentInfo;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ContextMenuStrip SaveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распечататьToolStripMenuItem;
    }
}