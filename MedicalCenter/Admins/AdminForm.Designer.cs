namespace MedicalCenter.Admins
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Registration = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.RegistrationState = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.licence = new System.Windows.Forms.TextBox();
            this.posts = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.states = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeniedPicture = new System.Windows.Forms.PictureBox();
            this.SuccessPicture = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.secondPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MyAccount = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.aSecondPassword = new System.Windows.Forms.Label();
            this.aPassword = new System.Windows.Forms.Label();
            this.aName = new System.Windows.Forms.Label();
            this.aEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.Registration.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MyAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.goBackToolStripMenuItem.Text = "Go Back";
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.statusStrip1);
            this.Registration.Controls.Add(this.groupBox2);
            this.Registration.Controls.Add(this.groupBox1);
            this.Registration.Controls.Add(this.RegistrationButton);
            this.Registration.ImageIndex = 0;
            this.Registration.Location = new System.Drawing.Point(4, 24);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Registration.Size = new System.Drawing.Size(829, 587);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Регистрация сотрудников";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrationState});
            this.statusStrip1.Location = new System.Drawing.Point(4, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // RegistrationState
            // 
            this.RegistrationState.Name = "RegistrationState";
            this.RegistrationState.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.licence);
            this.groupBox2.Controls.Add(this.posts);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.states);
            this.groupBox2.Location = new System.Drawing.Point(21, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(503, 195);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные сотрудника";
            // 
            // licence
            // 
            this.licence.Location = new System.Drawing.Point(196, 90);
            this.licence.Name = "licence";
            this.licence.Size = new System.Drawing.Size(166, 23);
            this.licence.TabIndex = 15;
            this.licence.TextChanged += new System.EventHandler(this.licence_TextChanged);
            // 
            // posts
            // 
            this.posts.FormattingEnabled = true;
            this.posts.Location = new System.Drawing.Point(196, 138);
            this.posts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(166, 23);
            this.posts.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Должность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Лицензия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кого зарегистриовать:";
            // 
            // states
            // 
            this.states.FormattingEnabled = true;
            this.states.Location = new System.Drawing.Point(196, 32);
            this.states.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(166, 23);
            this.states.TabIndex = 0;
            this.states.SelectedIndexChanged += new System.EventHandler(this.states_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeniedPicture);
            this.groupBox1.Controls.Add(this.SuccessPicture);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.secondPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.KeyWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Location = new System.Drawing.Point(21, 264);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(569, 265);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // DeniedPicture
            // 
            this.DeniedPicture.Image = ((System.Drawing.Image)(resources.GetObject("DeniedPicture.Image")));
            this.DeniedPicture.Location = new System.Drawing.Point(472, 22);
            this.DeniedPicture.Name = "DeniedPicture";
            this.DeniedPicture.Size = new System.Drawing.Size(31, 31);
            this.DeniedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeniedPicture.TabIndex = 71;
            this.DeniedPicture.TabStop = false;
            this.DeniedPicture.Visible = false;
            // 
            // SuccessPicture
            // 
            this.SuccessPicture.Image = ((System.Drawing.Image)(resources.GetObject("SuccessPicture.Image")));
            this.SuccessPicture.Location = new System.Drawing.Point(472, 22);
            this.SuccessPicture.Name = "SuccessPicture";
            this.SuccessPicture.Size = new System.Drawing.Size(31, 31);
            this.SuccessPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SuccessPicture.TabIndex = 70;
            this.SuccessPicture.TabStop = false;
            this.SuccessPicture.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Его имя:";
            // 
            // secondPassword
            // 
            this.secondPassword.Location = new System.Drawing.Point(240, 160);
            this.secondPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.Size = new System.Drawing.Size(221, 23);
            this.secondPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Его электронная почта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-59, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Его имя:";
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(239, 209);
            this.KeyWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(222, 23);
            this.KeyWord.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Его пароль:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ключевое слово:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Его второй пароль:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(240, 32);
            this.email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(221, 23);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(240, 75);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(221, 23);
            this.name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(240, 117);
            this.password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(221, 23);
            this.password.TabIndex = 3;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(620, 473);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(155, 47);
            this.RegistrationButton.TabIndex = 8;
            this.RegistrationButton.Text = "Зарегистрировать";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Registration);
            this.tabControl1.Controls.Add(this.MyAccount);
            this.tabControl1.ImageList = this.PagesImageList;
            this.tabControl1.Location = new System.Drawing.Point(-8, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 615);
            this.tabControl1.TabIndex = 0;
            // 
            // MyAccount
            // 
            this.MyAccount.Controls.Add(this.ExitButton);
            this.MyAccount.Controls.Add(this.aSecondPassword);
            this.MyAccount.Controls.Add(this.aPassword);
            this.MyAccount.Controls.Add(this.aName);
            this.MyAccount.Controls.Add(this.aEmail);
            this.MyAccount.Controls.Add(this.pictureBox1);
            this.MyAccount.ImageIndex = 1;
            this.MyAccount.Location = new System.Drawing.Point(4, 24);
            this.MyAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MyAccount.Name = "MyAccount";
            this.MyAccount.Size = new System.Drawing.Size(829, 587);
            this.MyAccount.TabIndex = 1;
            this.MyAccount.Text = "Мой аккаунт";
            this.MyAccount.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(27, 404);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 27);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // aSecondPassword
            // 
            this.aSecondPassword.AutoSize = true;
            this.aSecondPassword.Location = new System.Drawing.Point(23, 297);
            this.aSecondPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aSecondPassword.Name = "aSecondPassword";
            this.aSecondPassword.Size = new System.Drawing.Size(98, 15);
            this.aSecondPassword.TabIndex = 9;
            this.aSecondPassword.Text = "Second password:";
            // 
            // aPassword
            // 
            this.aPassword.AutoSize = true;
            this.aPassword.Location = new System.Drawing.Point(23, 247);
            this.aPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aPassword.Name = "aPassword";
            this.aPassword.Size = new System.Drawing.Size(57, 15);
            this.aPassword.TabIndex = 8;
            this.aPassword.Text = "password:";
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Location = new System.Drawing.Point(23, 198);
            this.aName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(36, 15);
            this.aName.TabIndex = 7;
            this.aName.Text = "name:";
            // 
            // aEmail
            // 
            this.aEmail.AutoSize = true;
            this.aEmail.Location = new System.Drawing.Point(23, 157);
            this.aEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aEmail.Name = "aEmail";
            this.aEmail.Size = new System.Drawing.Size(37, 15);
            this.aEmail.TabIndex = 6;
            this.aEmail.Text = "email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PagesImageList
            // 
            this.PagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PagesImageList.ImageStream")));
            this.PagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PagesImageList.Images.SetKeyName(0, "MakeAnAppointment.png");
            this.PagesImageList.Images.SetKeyName(1, "MyAccount.png");
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 606);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(837, 645);
            this.MinimumSize = new System.Drawing.Size(837, 645);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MyAccount.ResumeLayout(false);
            this.MyAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox states;
        private System.Windows.Forms.TextBox secondPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TabPage MyAccount;
        private System.Windows.Forms.Label aPassword;
        private System.Windows.Forms.Label aName;
        private System.Windows.Forms.Label aEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label aSecondPassword;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox posts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel RegistrationState;
        private System.Windows.Forms.TextBox licence;
        private System.Windows.Forms.PictureBox DeniedPicture;
        private System.Windows.Forms.PictureBox SuccessPicture;
        private System.Windows.Forms.ImageList PagesImageList;
    }
}