namespace MedicalCenter.Accountants
{
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.CreateReportPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetData = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.SendReport = new System.Windows.Forms.Button();
            this.SalesTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MyReports = new System.Windows.Forms.TabPage();
            this.searchReportPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.GetFullInformation = new System.Windows.Forms.Button();
            this.GetReports = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountantReports = new System.Windows.Forms.ListView();
            this.startDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneySum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.submitionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.secondPassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.startTime = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.endTime = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.startD = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.endD = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.CreateReportPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MyReports.SuspendLayout();
            this.searchReportPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateReportPage
            // 
            this.CreateReportPage.Controls.Add(this.panel1);
            this.CreateReportPage.Controls.Add(this.SalesTable);
            this.CreateReportPage.ImageIndex = 0;
            this.CreateReportPage.Location = new System.Drawing.Point(4, 24);
            this.CreateReportPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateReportPage.Name = "CreateReportPage";
            this.CreateReportPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateReportPage.Size = new System.Drawing.Size(892, 475);
            this.CreateReportPage.TabIndex = 0;
            this.CreateReportPage.Text = "Оформить отчет";
            this.CreateReportPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.GetData);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.sum);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.SendReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(547, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 469);
            this.panel1.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(97, 390);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(180, 27);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.startTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endTime, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 65);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Начальная дата:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Конечная дата:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(97, 115);
            this.GetData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(180, 27);
            this.GetData.TabIndex = 11;
            this.GetData.Text = "Получить данные";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(42, 306);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 15);
            this.amount.TabIndex = 8;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(42, 262);
            this.sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(0, 15);
            this.sum.TabIndex = 7;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(42, 215);
            this.end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(0, 15);
            this.end.TabIndex = 6;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(42, 164);
            this.start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(0, 15);
            this.start.TabIndex = 5;
            // 
            // SendReport
            // 
            this.SendReport.Location = new System.Drawing.Point(97, 357);
            this.SendReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendReport.Name = "SendReport";
            this.SendReport.Size = new System.Drawing.Size(180, 27);
            this.SendReport.TabIndex = 4;
            this.SendReport.Text = "Отправить отчет";
            this.SendReport.UseVisualStyleBackColor = true;
            this.SendReport.Visible = false;
            this.SendReport.Click += new System.EventHandler(this.SendReport_Click);
            // 
            // SalesTable
            // 
            this.SalesTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.SalesTable.Enabled = false;
            this.SalesTable.Location = new System.Drawing.Point(4, 3);
            this.SalesTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SalesTable.Name = "SalesTable";
            this.SalesTable.Size = new System.Drawing.Size(523, 469);
            this.SalesTable.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateReportPage);
            this.tabControl1.Controls.Add(this.MyReports);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.PagesImageList;
            this.tabControl1.Location = new System.Drawing.Point(-6, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // MyReports
            // 
            this.MyReports.Controls.Add(this.searchReportPanel);
            this.MyReports.Controls.Add(this.AccountantReports);
            this.MyReports.ImageIndex = 1;
            this.MyReports.Location = new System.Drawing.Point(4, 24);
            this.MyReports.Name = "MyReports";
            this.MyReports.Padding = new System.Windows.Forms.Padding(3);
            this.MyReports.Size = new System.Drawing.Size(892, 475);
            this.MyReports.TabIndex = 2;
            this.MyReports.Text = "Мои отчеты";
            this.MyReports.UseVisualStyleBackColor = true;
            // 
            // searchReportPanel
            // 
            this.searchReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchReportPanel.Controls.Add(this.endD);
            this.searchReportPanel.Controls.Add(this.startD);
            this.searchReportPanel.Controls.Add(this.groupBox1);
            this.searchReportPanel.Controls.Add(this.label3);
            this.searchReportPanel.Controls.Add(this.label4);
            this.searchReportPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchReportPanel.Location = new System.Drawing.Point(596, 3);
            this.searchReportPanel.Name = "searchReportPanel";
            this.searchReportPanel.Size = new System.Drawing.Size(293, 469);
            this.searchReportPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.GetFullInformation);
            this.groupBox1.Controls.Add(this.GetReports);
            this.groupBox1.Location = new System.Drawing.Point(40, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 194);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(30, 140);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(158, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Посмотреть подробнее";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // GetFullInformation
            // 
            this.GetFullInformation.Location = new System.Drawing.Point(30, 90);
            this.GetFullInformation.Name = "GetFullInformation";
            this.GetFullInformation.Size = new System.Drawing.Size(158, 23);
            this.GetFullInformation.TabIndex = 15;
            this.GetFullInformation.Text = "Посмотреть подробнее";
            this.GetFullInformation.UseVisualStyleBackColor = true;
            this.GetFullInformation.Click += new System.EventHandler(this.GetFullInformation_Click);
            // 
            // GetReports
            // 
            this.GetReports.Location = new System.Drawing.Point(30, 41);
            this.GetReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetReports.Name = "GetReports";
            this.GetReports.Size = new System.Drawing.Size(158, 23);
            this.GetReports.TabIndex = 14;
            this.GetReports.Text = "Получить данные";
            this.GetReports.UseVisualStyleBackColor = true;
            this.GetReports.Click += new System.EventHandler(this.GetReports_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Конечная дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Начальная дата:";
            // 
            // AccountantReports
            // 
            this.AccountantReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.startDate,
            this.endDate,
            this.moneySum,
            this.submitionTime});
            this.AccountantReports.FullRowSelect = true;
            this.AccountantReports.GridLines = true;
            this.AccountantReports.HideSelection = false;
            this.AccountantReports.Location = new System.Drawing.Point(8, 17);
            this.AccountantReports.Name = "AccountantReports";
            this.AccountantReports.Size = new System.Drawing.Size(450, 385);
            this.AccountantReports.TabIndex = 0;
            this.AccountantReports.UseCompatibleStateImageBehavior = false;
            this.AccountantReports.View = System.Windows.Forms.View.Details;
            // 
            // startDate
            // 
            this.startDate.Text = "Начальная дата";
            this.startDate.Width = 111;
            // 
            // endDate
            // 
            this.endDate.Text = "Конечная дата";
            this.endDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endDate.Width = 125;
            // 
            // moneySum
            // 
            this.moneySum.Text = "Сумма";
            this.moneySum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moneySum.Width = 103;
            // 
            // submitionTime
            // 
            this.submitionTime.Text = "Дата отправки";
            this.submitionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submitionTime.Width = 105;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.secondPassword);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.email);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.ExitButton);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(892, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мой Аккаунт";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // secondPassword
            // 
            this.secondPassword.AutoSize = true;
            this.secondPassword.Location = new System.Drawing.Point(52, 291);
            this.secondPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.Size = new System.Drawing.Size(98, 15);
            this.secondPassword.TabIndex = 14;
            this.secondPassword.Text = "Second password:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(52, 247);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 15);
            this.password.TabIndex = 13;
            this.password.Text = "password:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(52, 207);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(36, 15);
            this.name.TabIndex = 12;
            this.name.Text = "name:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(52, 165);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(37, 15);
            this.email.TabIndex = 11;
            this.email.Text = "email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(49, 339);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(147, 27);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выйти из аккаунта";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PagesImageList
            // 
            this.PagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PagesImageList.ImageStream")));
            this.PagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PagesImageList.Images.SetKeyName(0, "MakeAnAppointment.png");
            this.PagesImageList.Images.SetKeyName(1, "myAppointments.png");
            this.PagesImageList.Images.SetKeyName(2, "MyAccount.png");
            // 
            // startTime
            // 
            this.startTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startTime.BorderSize = 0;
            this.startTime.CalendarIcon = global::MedicalCenter.Properties.Resources.CalendarLight;
            this.startTime.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.startTime.Location = new System.Drawing.Point(150, 3);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(142, 22);
            this.startTime.SkinColor = System.Drawing.Color.White;
            this.startTime.TabIndex = 14;
            this.startTime.TextColor = System.Drawing.Color.Black;
            // 
            // endTime
            // 
            this.endTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.endTime.BorderSize = 0;
            this.endTime.CalendarIcon = global::MedicalCenter.Properties.Resources.CalendarLight;
            this.endTime.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.endTime.Location = new System.Drawing.Point(150, 35);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(142, 22);
            this.endTime.SkinColor = System.Drawing.Color.White;
            this.endTime.TabIndex = 15;
            this.endTime.TextColor = System.Drawing.Color.Black;
            // 
            // startD
            // 
            this.startD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startD.BorderSize = 0;
            this.startD.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("startD.CalendarIcon")));
            this.startD.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.startD.Location = new System.Drawing.Point(136, 20);
            this.startD.Name = "startD";
            this.startD.Size = new System.Drawing.Size(137, 22);
            this.startD.SkinColor = System.Drawing.Color.White;
            this.startD.TabIndex = 18;
            this.startD.TextColor = System.Drawing.Color.Black;
            this.startD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // endD
            // 
            this.endD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.endD.BorderSize = 0;
            this.endD.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("endD.CalendarIcon")));
            this.endD.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.endD.Location = new System.Drawing.Point(136, 57);
            this.endD.Name = "endD";
            this.endD.Size = new System.Drawing.Size(137, 22);
            this.endD.SkinColor = System.Drawing.Color.White;
            this.endD.TabIndex = 19;
            this.endD.TextColor = System.Drawing.Color.Black;
            this.endD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 496);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(903, 535);
            this.MinimumSize = new System.Drawing.Size(903, 535);
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountantForm_FormClosed);
            this.Load += new System.EventHandler(this.AccountantForm_Load);
            this.CreateReportPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MyReports.ResumeLayout(false);
            this.searchReportPanel.ResumeLayout(false);
            this.searchReportPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CreateReportPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView SalesTable;
        private System.Windows.Forms.Button SendReport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label secondPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TabPage MyReports;
        private System.Windows.Forms.ListView AccountantReports;
        private System.Windows.Forms.ColumnHeader startDate;
        private System.Windows.Forms.ColumnHeader endDate;
        private System.Windows.Forms.ColumnHeader moneySum;
        private System.Windows.Forms.ColumnHeader submitionTime;
        private System.Windows.Forms.Panel searchReportPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetReports;
        private System.Windows.Forms.Button GetFullInformation;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList PagesImageList;
        private CustomControls.CustomDateTimePicker startTime;
        private CustomControls.CustomDateTimePicker endTime;
        private CustomControls.CustomDateTimePicker startD;
        private CustomControls.CustomDateTimePicker endD;
    }
}