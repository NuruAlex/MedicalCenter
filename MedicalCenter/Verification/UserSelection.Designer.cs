namespace MedicalCenter
{
    partial class UserSelection
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
            this.IamPatient = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.UserChoiceGroup = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.SetDarkTheme = new System.Windows.Forms.PictureBox();
            this.SetLightTheme = new System.Windows.Forms.PictureBox();
            this.ShowProgramInformation = new System.Windows.Forms.LinkLabel();
            this.UserChoiceGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetDarkTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLightTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // IamPatient
            // 
            this.IamPatient.Location = new System.Drawing.Point(35, 61);
            this.IamPatient.Name = "IamPatient";
            this.IamPatient.Size = new System.Drawing.Size(130, 23);
            this.IamPatient.TabIndex = 5;
            this.IamPatient.Text = "Я пациент";
            this.IamPatient.UseVisualStyleBackColor = true;
            this.IamPatient.Click += new System.EventHandler(this.IamPatient_Click);
            // 
            // StaffButton
            // 
            this.StaffButton.Location = new System.Drawing.Point(35, 125);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(130, 23);
            this.StaffButton.TabIndex = 6;
            this.StaffButton.Text = "Я сотрудник";
            this.StaffButton.UseVisualStyleBackColor = true;
            this.StaffButton.Click += new System.EventHandler(this.IamStaff_Click);
            // 
            // UserChoiceGroup
            // 
            this.UserChoiceGroup.Controls.Add(this.IamPatient);
            this.UserChoiceGroup.Controls.Add(this.StaffButton);
            this.UserChoiceGroup.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserChoiceGroup.Location = new System.Drawing.Point(56, 58);
            this.UserChoiceGroup.Name = "UserChoiceGroup";
            this.UserChoiceGroup.Size = new System.Drawing.Size(206, 199);
            this.UserChoiceGroup.TabIndex = 7;
            this.UserChoiceGroup.TabStop = false;
            this.UserChoiceGroup.Text = "Выберите тип пользователя";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(345, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageLine
            // 
            this.MessageLine.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLine.Name = "MessageLine";
            this.MessageLine.Size = new System.Drawing.Size(250, 17);
            this.MessageLine.Text = "Нажмите Escape, чтобы выйти из программы";
            // 
            // SetDarkTheme
            // 
            this.SetDarkTheme.Image = global::MedicalCenter.Properties.Resources.LightSwitch;
            this.SetDarkTheme.Location = new System.Drawing.Point(-3, 1);
            this.SetDarkTheme.Name = "SetDarkTheme";
            this.SetDarkTheme.Size = new System.Drawing.Size(41, 32);
            this.SetDarkTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SetDarkTheme.TabIndex = 10;
            this.SetDarkTheme.TabStop = false;
            this.SetDarkTheme.Click += new System.EventHandler(this.SetDarkTheme_Click);
            // 
            // SetLightTheme
            // 
            this.SetLightTheme.Image = global::MedicalCenter.Properties.Resources.DarkSwitch;
            this.SetLightTheme.Location = new System.Drawing.Point(-3, 1);
            this.SetLightTheme.Name = "SetLightTheme";
            this.SetLightTheme.Size = new System.Drawing.Size(41, 32);
            this.SetLightTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SetLightTheme.TabIndex = 11;
            this.SetLightTheme.TabStop = false;
            this.SetLightTheme.Click += new System.EventHandler(this.SetLightTheme_Click);
            // 
            // ShowProgramInformation
            // 
            this.ShowProgramInformation.AutoSize = true;
            this.ShowProgramInformation.Location = new System.Drawing.Point(249, 20);
            this.ShowProgramInformation.Name = "ShowProgramInformation";
            this.ShowProgramInformation.Size = new System.Drawing.Size(75, 13);
            this.ShowProgramInformation.TabIndex = 12;
            this.ShowProgramInformation.TabStop = true;
            this.ShowProgramInformation.Text = "О программе";
            this.ShowProgramInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowProgramInformation_LinkClicked);
            // 
            // UserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(345, 322);
            this.Controls.Add(this.ShowProgramInformation);
            this.Controls.Add(this.SetLightTheme);
            this.Controls.Add(this.SetDarkTheme);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.UserChoiceGroup);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 361);
            this.MinimumSize = new System.Drawing.Size(361, 361);
            this.Name = "UserSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор Пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserSelection_FormClosed);
            this.Load += new System.EventHandler(this.UserSelection_Load);
            this.UserChoiceGroup.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetDarkTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLightTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IamPatient;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.GroupBox UserChoiceGroup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageLine;
        private System.Windows.Forms.PictureBox SetDarkTheme;
        private System.Windows.Forms.PictureBox SetLightTheme;
        private System.Windows.Forms.LinkLabel ShowProgramInformation;
    }
}