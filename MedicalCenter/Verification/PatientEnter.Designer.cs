namespace MedicalCenter
{
    partial class PatientEnter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientEnter));
            this.GoToRegistration = new System.Windows.Forms.LinkLabel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockPicture = new System.Windows.Forms.PictureBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.SuccessPicture = new System.Windows.Forms.PictureBox();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeniedPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToRegistration
            // 
            this.GoToRegistration.AutoSize = true;
            this.GoToRegistration.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToRegistration.LinkColor = System.Drawing.Color.Blue;
            this.GoToRegistration.Location = new System.Drawing.Point(381, 345);
            this.GoToRegistration.Name = "GoToRegistration";
            this.GoToRegistration.Size = new System.Drawing.Size(96, 19);
            this.GoToRegistration.TabIndex = 4;
            this.GoToRegistration.TabStop = true;
            this.GoToRegistration.Text = "Нет аккаунта?";
            this.GoToRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToRegistration_LinkClicked);
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(202, 338);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(159, 30);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(152, 198);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(159, 24);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Window;
            this.email.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(152, 139);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(159, 24);
            this.email.TabIndex = 1;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Почта:";
            // 
            // unlockPicture
            // 
            this.unlockPicture.Image = ((System.Drawing.Image)(resources.GetObject("unlockPicture.Image")));
            this.unlockPicture.Location = new System.Drawing.Point(321, 198);
            this.unlockPicture.Name = "unlockPicture";
            this.unlockPicture.Size = new System.Drawing.Size(31, 27);
            this.unlockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unlockPicture.TabIndex = 18;
            this.unlockPicture.TabStop = false;
            this.unlockPicture.Visible = false;
            this.unlockPicture.Click += new System.EventHandler(this.lockOrUnlockPicture_Click);
            // 
            // lockPicture
            // 
            this.lockPicture.Image = ((System.Drawing.Image)(resources.GetObject("lockPicture.Image")));
            this.lockPicture.Location = new System.Drawing.Point(321, 198);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(31, 27);
            this.lockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPicture.TabIndex = 17;
            this.lockPicture.TabStop = false;
            this.lockPicture.Click += new System.EventHandler(this.lockOrUnlockPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageLine
            // 
            this.MessageLine.Name = "MessageLine";
            this.MessageLine.Size = new System.Drawing.Size(0, 17);
            // 
            // SuccessPicture
            // 
            this.SuccessPicture.Image = ((System.Drawing.Image)(resources.GetObject("SuccessPicture.Image")));
            this.SuccessPicture.Location = new System.Drawing.Point(321, 132);
            this.SuccessPicture.Name = "SuccessPicture";
            this.SuccessPicture.Size = new System.Drawing.Size(31, 31);
            this.SuccessPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SuccessPicture.TabIndex = 41;
            this.SuccessPicture.TabStop = false;
            this.SuccessPicture.Visible = false;
            // 
            // HomePicture
            // 
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(12, 7);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(32, 32);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePicture.TabIndex = 42;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.Home_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeniedPicture);
            this.groupBox1.Controls.Add(this.SuccessPicture);
            this.groupBox1.Controls.Add(this.unlockPicture);
            this.groupBox1.Controls.Add(this.lockPicture);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(50, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваши данные";
            // 
            // DeniedPicture
            // 
            this.DeniedPicture.Image = ((System.Drawing.Image)(resources.GetObject("DeniedPicture.Image")));
            this.DeniedPicture.Location = new System.Drawing.Point(321, 132);
            this.DeniedPicture.Name = "DeniedPicture";
            this.DeniedPicture.Size = new System.Drawing.Size(31, 31);
            this.DeniedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeniedPicture.TabIndex = 42;
            this.DeniedPicture.TabStop = false;
            this.DeniedPicture.Visible = false;
            // 
            // PatientEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HomePicture);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GoToRegistration);
            this.Controls.Add(this.EnterButton);
            this.Name = "PatientEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterForm_FormClosed);
            this.Load += new System.EventHandler(this.PatientEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox unlockPicture;
        private System.Windows.Forms.PictureBox lockPicture;
        private System.Windows.Forms.LinkLabel GoToRegistration;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageLine;
        private System.Windows.Forms.PictureBox SuccessPicture;
        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox DeniedPicture;
    }
}

