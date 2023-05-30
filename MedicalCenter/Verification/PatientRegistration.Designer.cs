namespace MedicalCenter
{
    partial class PatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistration));
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GoToEnter = new System.Windows.Forms.LinkLabel();
            this.RegistraeButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockPicture = new System.Windows.Forms.PictureBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.DateTimePicker();
            this.SuccessPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeniedPicture = new System.Windows.Forms.PictureBox();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageLine = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(230, 159);
            this.email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(218, 24);
            this.email.TabIndex = 1;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(230, 229);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 24);
            this.name.TabIndex = 3;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(128, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Почта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Имя:";
            // 
            // GoToEnter
            // 
            this.GoToEnter.AutoSize = true;
            this.GoToEnter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToEnter.Location = new System.Drawing.Point(505, 472);
            this.GoToEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToEnter.Name = "GoToEnter";
            this.GoToEnter.Size = new System.Drawing.Size(120, 19);
            this.GoToEnter.TabIndex = 8;
            this.GoToEnter.TabStop = true;
            this.GoToEnter.Text = "Уже есть аккаунт?";
            this.GoToEnter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToEnter_LinkClicked);
            // 
            // RegistraeButton
            // 
            this.RegistraeButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistraeButton.Location = new System.Drawing.Point(209, 462);
            this.RegistraeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegistraeButton.Name = "RegistraeButton";
            this.RegistraeButton.Size = new System.Drawing.Size(240, 37);
            this.RegistraeButton.TabIndex = 7;
            this.RegistraeButton.Text = "Зарегистрироваться";
            this.RegistraeButton.UseVisualStyleBackColor = true;
            this.RegistraeButton.Click += new System.EventHandler(this.RegistrateButton_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(230, 195);
            this.password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 24);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(230, 302);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneNumber.MaxLength = 50;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(218, 24);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Номер телефона:";
            // 
            // unlockPicture
            // 
            this.unlockPicture.Image = ((System.Drawing.Image)(resources.GetObject("unlockPicture.Image")));
            this.unlockPicture.Location = new System.Drawing.Point(465, 195);
            this.unlockPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unlockPicture.Name = "unlockPicture";
            this.unlockPicture.Size = new System.Drawing.Size(31, 31);
            this.unlockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unlockPicture.TabIndex = 32;
            this.unlockPicture.TabStop = false;
            this.unlockPicture.Visible = false;
            this.unlockPicture.Click += new System.EventHandler(this.LockOrUnlockPicture_Click);
            // 
            // lockPicture
            // 
            this.lockPicture.Image = ((System.Drawing.Image)(resources.GetObject("lockPicture.Image")));
            this.lockPicture.Location = new System.Drawing.Point(465, 195);
            this.lockPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(31, 31);
            this.lockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPicture.TabIndex = 31;
            this.lockPicture.TabStop = false;
            this.lockPicture.Click += new System.EventHandler(this.LockOrUnlockPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // KeyWord
            // 
            this.KeyWord.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyWord.Location = new System.Drawing.Point(230, 331);
            this.KeyWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KeyWord.MaxLength = 50;
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(218, 24);
            this.KeyWord.TabIndex = 6;
            this.KeyWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(50, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Kлючевое слово:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(62, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Дата рождения:";
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(230, 264);
            this.Birth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(218, 23);
            this.Birth.TabIndex = 4;
            // 
            // SuccessPicture
            // 
            this.SuccessPicture.Image = ((System.Drawing.Image)(resources.GetObject("SuccessPicture.Image")));
            this.SuccessPicture.Location = new System.Drawing.Point(465, 152);
            this.SuccessPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SuccessPicture.Name = "SuccessPicture";
            this.SuccessPicture.Size = new System.Drawing.Size(31, 31);
            this.SuccessPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SuccessPicture.TabIndex = 42;
            this.SuccessPicture.TabStop = false;
            this.SuccessPicture.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeniedPicture);
            this.groupBox1.Controls.Add(this.SuccessPicture);
            this.groupBox1.Controls.Add(this.Birth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.KeyWord);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.unlockPicture);
            this.groupBox1.Controls.Add(this.lockPicture);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(55, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваши данные";
            // 
            // DeniedPicture
            // 
            this.DeniedPicture.Image = ((System.Drawing.Image)(resources.GetObject("DeniedPicture.Image")));
            this.DeniedPicture.Location = new System.Drawing.Point(465, 152);
            this.DeniedPicture.Name = "DeniedPicture";
            this.DeniedPicture.Size = new System.Drawing.Size(31, 31);
            this.DeniedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeniedPicture.TabIndex = 43;
            this.DeniedPicture.TabStop = false;
            this.DeniedPicture.Visible = false;
            // 
            // HomePicture
            // 
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(12, 12);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(32, 32);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePicture.TabIndex = 43;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.HomePicture_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageLine
            // 
            this.MessageLine.Name = "MessageLine";
            this.MessageLine.Size = new System.Drawing.Size(0, 17);
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.HomePicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GoToEnter);
            this.Controls.Add(this.RegistraeButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PatientRegistration";
            this.Text = "RegistrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.Load += new System.EventHandler(this.PatientRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox unlockPicture;
        private System.Windows.Forms.PictureBox lockPicture;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel GoToEnter;
        private System.Windows.Forms.Button RegistraeButton;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Birth;
        private System.Windows.Forms.PictureBox SuccessPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.PictureBox DeniedPicture;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageLine;
    }
}