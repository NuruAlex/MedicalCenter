namespace MedicalCenter.HeadPhysicians
{
    partial class HeadPhysicianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadPhysicianForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.GetWorkSchedule = new System.Windows.Forms.Button();
            this.CreateTimeTable = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.InputChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.DataGridView();
            this.stuffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearGrugTable = new System.Windows.Forms.Button();
            this.AddDrug = new System.Windows.Forms.Button();
            this.UpdateDrug = new System.Windows.Forms.Button();
            this.GetDrugsInfo = new System.Windows.Forms.Button();
            this.DrugTable = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aSecondPassword = new System.Windows.Forms.Label();
            this.aPassword = new System.Windows.Forms.Label();
            this.aName = new System.Windows.Forms.Label();
            this.aEmail = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.endDate = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.startDate = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrugTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.PagesImageList;
            this.tabControl1.Location = new System.Drawing.Point(-7, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.timeTable);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(888, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(606, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 427);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.GetWorkSchedule);
            this.groupBox1.Controls.Add(this.CreateTimeTable);
            this.groupBox1.Controls.Add(this.Generate);
            this.groupBox1.Controls.Add(this.InputChanges);
            this.groupBox1.Location = new System.Drawing.Point(35, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(212, 281);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(28, 234);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(158, 27);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GetWorkSchedule
            // 
            this.GetWorkSchedule.Location = new System.Drawing.Point(28, 31);
            this.GetWorkSchedule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetWorkSchedule.Name = "GetWorkSchedule";
            this.GetWorkSchedule.Size = new System.Drawing.Size(158, 27);
            this.GetWorkSchedule.TabIndex = 3;
            this.GetWorkSchedule.Text = "Получить расписание ";
            this.GetWorkSchedule.UseVisualStyleBackColor = true;
            this.GetWorkSchedule.Click += new System.EventHandler(this.GetWorkSchedule_Click);
            // 
            // CreateTimeTable
            // 
            this.CreateTimeTable.Location = new System.Drawing.Point(28, 185);
            this.CreateTimeTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateTimeTable.Name = "CreateTimeTable";
            this.CreateTimeTable.Size = new System.Drawing.Size(158, 27);
            this.CreateTimeTable.TabIndex = 6;
            this.CreateTimeTable.Text = "Создать расписание";
            this.CreateTimeTable.UseVisualStyleBackColor = true;
            this.CreateTimeTable.Click += new System.EventHandler(this.CreateTimeTable_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(28, 81);
            this.Generate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(158, 27);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // InputChanges
            // 
            this.InputChanges.Location = new System.Drawing.Point(28, 133);
            this.InputChanges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputChanges.Name = "InputChanges";
            this.InputChanges.Size = new System.Drawing.Size(158, 27);
            this.InputChanges.TabIndex = 4;
            this.InputChanges.Text = "Внести расписание";
            this.InputChanges.UseVisualStyleBackColor = true;
            this.InputChanges.Click += new System.EventHandler(this.InputChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Конечная дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Начальная дата:";
            // 
            // timeTable
            // 
            this.timeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuffId,
            this.dayType,
            this.dayDate});
            this.timeTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.timeTable.Location = new System.Drawing.Point(4, 3);
            this.timeTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(580, 427);
            this.timeTable.TabIndex = 0;
            // 
            // stuffId
            // 
            this.stuffId.HeaderText = "Id врача";
            this.stuffId.Name = "stuffId";
            this.stuffId.ReadOnly = true;
            // 
            // dayType
            // 
            this.dayType.HeaderText = "Работает";
            this.dayType.Name = "dayType";
            // 
            // dayDate
            // 
            this.dayDate.HeaderText = "Число";
            this.dayDate.Name = "dayDate";
            this.dayDate.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.DrugTable);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(888, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Препараты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(625, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 428);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearGrugTable);
            this.groupBox2.Controls.Add(this.AddDrug);
            this.groupBox2.Controls.Add(this.UpdateDrug);
            this.groupBox2.Controls.Add(this.GetDrugsInfo);
            this.groupBox2.Location = new System.Drawing.Point(23, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(224, 266);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // ClearGrugTable
            // 
            this.ClearGrugTable.Location = new System.Drawing.Point(18, 216);
            this.ClearGrugTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearGrugTable.Name = "ClearGrugTable";
            this.ClearGrugTable.Size = new System.Drawing.Size(192, 27);
            this.ClearGrugTable.TabIndex = 4;
            this.ClearGrugTable.Text = "Очистить данные";
            this.ClearGrugTable.UseVisualStyleBackColor = true;
            this.ClearGrugTable.Click += new System.EventHandler(this.ClearGrugTable_Click);
            // 
            // AddDrug
            // 
            this.AddDrug.Location = new System.Drawing.Point(18, 98);
            this.AddDrug.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddDrug.Name = "AddDrug";
            this.AddDrug.Size = new System.Drawing.Size(192, 27);
            this.AddDrug.TabIndex = 2;
            this.AddDrug.Text = "Добавить лекарство";
            this.AddDrug.UseVisualStyleBackColor = true;
            this.AddDrug.Click += new System.EventHandler(this.AddDrug_Click);
            // 
            // UpdateDrug
            // 
            this.UpdateDrug.Location = new System.Drawing.Point(18, 160);
            this.UpdateDrug.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateDrug.Name = "UpdateDrug";
            this.UpdateDrug.Size = new System.Drawing.Size(192, 27);
            this.UpdateDrug.TabIndex = 3;
            this.UpdateDrug.Text = "Обновить информацию";
            this.UpdateDrug.UseVisualStyleBackColor = true;
            this.UpdateDrug.Click += new System.EventHandler(this.UpdateDrug_Click);
            // 
            // GetDrugsInfo
            // 
            this.GetDrugsInfo.Location = new System.Drawing.Point(18, 40);
            this.GetDrugsInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetDrugsInfo.Name = "GetDrugsInfo";
            this.GetDrugsInfo.Size = new System.Drawing.Size(192, 27);
            this.GetDrugsInfo.TabIndex = 1;
            this.GetDrugsInfo.Text = "Получить всю информацию";
            this.GetDrugsInfo.UseVisualStyleBackColor = true;
            this.GetDrugsInfo.Click += new System.EventHandler(this.GetDrugsInfo_Click);
            // 
            // DrugTable
            // 
            this.DrugTable.AllowUserToResizeColumns = false;
            this.DrugTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DrugTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DrugTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrugTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.dDescription,
            this.dProvider,
            this.remains,
            this.cost});
            this.DrugTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrugTable.Location = new System.Drawing.Point(4, 3);
            this.DrugTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrugTable.Name = "DrugTable";
            this.DrugTable.Size = new System.Drawing.Size(596, 428);
            this.DrugTable.TabIndex = 0;
            // 
            // title
            // 
            this.title.HeaderText = "Название";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // dDescription
            // 
            this.dDescription.HeaderText = "Описание";
            this.dDescription.Name = "dDescription";
            // 
            // dProvider
            // 
            this.dProvider.HeaderText = "Поставщик";
            this.dProvider.Name = "dProvider";
            // 
            // remains
            // 
            this.remains.HeaderText = "Остаток";
            this.remains.Name = "remains";
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.Name = "cost";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.aSecondPassword);
            this.tabPage3.Controls.Add(this.aPassword);
            this.tabPage3.Controls.Add(this.aName);
            this.tabPage3.Controls.Add(this.aEmail);
            this.tabPage3.Controls.Add(this.ExitButton);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(888, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мой Аккаунт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // aSecondPassword
            // 
            this.aSecondPassword.AutoSize = true;
            this.aSecondPassword.Location = new System.Drawing.Point(36, 278);
            this.aSecondPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aSecondPassword.Name = "aSecondPassword";
            this.aSecondPassword.Size = new System.Drawing.Size(98, 15);
            this.aSecondPassword.TabIndex = 19;
            this.aSecondPassword.Text = "Second password:";
            // 
            // aPassword
            // 
            this.aPassword.AutoSize = true;
            this.aPassword.Location = new System.Drawing.Point(36, 228);
            this.aPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aPassword.Name = "aPassword";
            this.aPassword.Size = new System.Drawing.Size(57, 15);
            this.aPassword.TabIndex = 18;
            this.aPassword.Text = "password:";
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Location = new System.Drawing.Point(36, 180);
            this.aName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(36, 15);
            this.aName.TabIndex = 17;
            this.aName.Text = "name:";
            // 
            // aEmail
            // 
            this.aEmail.AutoSize = true;
            this.aEmail.Location = new System.Drawing.Point(36, 138);
            this.aEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aEmail.Name = "aEmail";
            this.aEmail.Size = new System.Drawing.Size(37, 15);
            this.aEmail.TabIndex = 16;
            this.aEmail.Text = "email:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(40, 324);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(134, 27);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выйти из аккаунта";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PagesImageList
            // 
            this.PagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PagesImageList.ImageStream")));
            this.PagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PagesImageList.Images.SetKeyName(0, "myAppointments.png");
            this.PagesImageList.Images.SetKeyName(1, "Drugs.png");
            this.PagesImageList.Images.SetKeyName(2, "MyAccount.png");
            // 
            // endDate
            // 
            this.endDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.endDate.BorderSize = 0;
            this.endDate.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.endDate.Location = new System.Drawing.Point(121, 52);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(147, 22);
            this.endDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.endDate.TabIndex = 11;
            this.endDate.TextColor = System.Drawing.Color.White;
            // 
            // startDate
            // 
            this.startDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startDate.BorderSize = 0;
            this.startDate.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.startDate.Location = new System.Drawing.Point(121, 14);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(147, 22);
            this.startDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.startDate.TabIndex = 10;
            this.startDate.TextColor = System.Drawing.Color.White;
            // 
            // HeadPhysicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(898, 492);
            this.MinimumSize = new System.Drawing.Size(898, 492);
            this.Name = "HeadPhysicianForm";
            this.Text = "HeadPhysicianForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeadPhysicianForm_FormClosed);
            this.Load += new System.EventHandler(this.HeadPhysicianForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrugTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView timeTable;
        private System.Windows.Forms.Button GetWorkSchedule;
        private System.Windows.Forms.Button InputChanges;
        private System.Windows.Forms.DataGridView DrugTable;
        private System.Windows.Forms.Button GetDrugsInfo;
        private System.Windows.Forms.Button AddDrug;
        private System.Windows.Forms.Button UpdateDrug;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateTimeTable;
        private System.Windows.Forms.Label aSecondPassword;
        private System.Windows.Forms.Label aPassword;
        private System.Windows.Forms.Label aName;
        private System.Windows.Forms.Label aEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuffId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDate;
        private System.Windows.Forms.ImageList PagesImageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn remains;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Button ClearGrugTable;
        private CustomControls.CustomDateTimePicker startDate;
        private CustomControls.CustomDateTimePicker endDate;
    }
}