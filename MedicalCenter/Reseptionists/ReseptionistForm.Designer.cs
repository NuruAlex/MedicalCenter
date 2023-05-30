namespace MedicalCenter.Reseptionists
{
    partial class ReseptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReseptionistForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeniedPicture = new System.Windows.Forms.PictureBox();
            this.SuccessPicture = new System.Windows.Forms.PictureBox();
            this.Birth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unlockPicture = new System.Windows.Forms.PictureBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegistraeButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.aSecondPassword = new System.Windows.Forms.Label();
            this.aPassword = new System.Windows.Forms.Label();
            this.aName = new System.Windows.Forms.Label();
            this.aEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.PagesImageList;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.RegistraeButton);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация пациента";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(18, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 384);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные пациента";
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
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(230, 264);
            this.Birth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(218, 20);
            this.Birth.TabIndex = 4;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(230, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // RegistraeButton
            // 
            this.RegistraeButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistraeButton.Location = new System.Drawing.Point(187, 438);
            this.RegistraeButton.Name = "RegistraeButton";
            this.RegistraeButton.Size = new System.Drawing.Size(235, 33);
            this.RegistraeButton.TabIndex = 37;
            this.RegistraeButton.Text = "Зарегистрировать";
            this.RegistraeButton.UseVisualStyleBackColor = true;
            this.RegistraeButton.Click += new System.EventHandler(this.RegistraeButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оплата услуг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ExitButton);
            this.tabPage3.Controls.Add(this.aSecondPassword);
            this.tabPage3.Controls.Add(this.aPassword);
            this.tabPage3.Controls.Add(this.aName);
            this.tabPage3.Controls.Add(this.aEmail);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(647, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мой аккаунт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(39, 315);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 23);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Выйти из аккаунта";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // aSecondPassword
            // 
            this.aSecondPassword.AutoSize = true;
            this.aSecondPassword.Location = new System.Drawing.Point(36, 252);
            this.aSecondPassword.Name = "aSecondPassword";
            this.aSecondPassword.Size = new System.Drawing.Size(95, 13);
            this.aSecondPassword.TabIndex = 19;
            this.aSecondPassword.Text = "Second password:";
            // 
            // aPassword
            // 
            this.aPassword.AutoSize = true;
            this.aPassword.Location = new System.Drawing.Point(36, 209);
            this.aPassword.Name = "aPassword";
            this.aPassword.Size = new System.Drawing.Size(55, 13);
            this.aPassword.TabIndex = 18;
            this.aPassword.Text = "password:";
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Location = new System.Drawing.Point(36, 167);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(36, 13);
            this.aName.TabIndex = 17;
            this.aName.Text = "name:";
            // 
            // aEmail
            // 
            this.aEmail.AutoSize = true;
            this.aEmail.Location = new System.Drawing.Point(36, 131);
            this.aEmail.Name = "aEmail";
            this.aEmail.Size = new System.Drawing.Size(34, 13);
            this.aEmail.TabIndex = 16;
            this.aEmail.Text = "email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PagesImageList
            // 
            this.PagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PagesImageList.ImageStream")));
            this.PagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PagesImageList.Images.SetKeyName(0, "user-add.png");
            this.PagesImageList.Images.SetKeyName(1, "Success.png");
            this.PagesImageList.Images.SetKeyName(2, "MyAccount.png");
            // 
            // ReseptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReseptionistForm";
            this.Text = "ReseptionistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReseptionistForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RegistraeButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label aSecondPassword;
        private System.Windows.Forms.Label aPassword;
        private System.Windows.Forms.Label aName;
        private System.Windows.Forms.Label aEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox DeniedPicture;
        private System.Windows.Forms.PictureBox SuccessPicture;
        private System.Windows.Forms.DateTimePicker Birth;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox unlockPicture;
        private System.Windows.Forms.PictureBox lockPicture;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList PagesImageList;
    }
}