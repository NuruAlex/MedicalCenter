namespace MedicalCenter.Patients
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.appointmentState = new System.Windows.Forms.ToolStripStatusLabel();
            this.appointmentsAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctors = new System.Windows.Forms.ComboBox();
            this.procedures = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateOfprocedure = new System.Windows.Forms.ComboBox();
            this.times = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MyAppointmentsPage = new System.Windows.Forms.TabPage();
            this.MyAppointmentsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.получитьСегодняшниеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьПодробнуюИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьТекущуюВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.myAppointments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.messageLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.HasSeen = new System.Windows.Forms.CheckBox();
            this.GetAppointments = new System.Windows.Forms.Button();
            this.startTime = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endTime = new MedicalCenter.CustomControls.CustomDateTimePicker();
            this.MyAccount = new System.Windows.Forms.TabPage();
            this.MyAccountMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьПодробнуюИнформациюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetDarkTheme = new System.Windows.Forms.PictureBox();
            this.SetLightTheme = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.myReports = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNubmer = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MyAppointmentsPage.SuspendLayout();
            this.MyAppointmentsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MyAccount.SuspendLayout();
            this.MyAccountMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetDarkTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLightTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.MyAppointmentsPage);
            this.tabControl1.Controls.Add(this.MyAccount);
            this.tabControl1.ImageList = this.pagesImageList;
            this.tabControl1.Location = new System.Drawing.Point(-9, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.DeleteAll);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(851, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Записаться ко врачу";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentState,
            this.appointmentsAmount});
            this.statusStrip1.Location = new System.Drawing.Point(4, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(843, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // appointmentState
            // 
            this.appointmentState.Name = "appointmentState";
            this.appointmentState.Size = new System.Drawing.Size(0, 17);
            // 
            // appointmentsAmount
            // 
            this.appointmentsAmount.Name = "appointmentsAmount";
            this.appointmentsAmount.Size = new System.Drawing.Size(0, 17);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(575, 198);
            this.DeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(180, 27);
            this.DeleteAll.TabIndex = 34;
            this.DeleteAll.Text = "Сбросить ";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.doctors);
            this.groupBox1.Controls.Add(this.procedures);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateOfprocedure);
            this.groupBox1.Controls.Add(this.times);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(50, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(449, 397);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для записи";
            // 
            // doctors
            // 
            this.doctors.FormattingEnabled = true;
            this.doctors.Location = new System.Drawing.Point(37, 159);
            this.doctors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doctors.Name = "doctors";
            this.doctors.Size = new System.Drawing.Size(276, 23);
            this.doctors.TabIndex = 26;
            this.doctors.SelectedIndexChanged += new System.EventHandler(this.doctors_SelectedIndexChanged);
            // 
            // procedures
            // 
            this.procedures.FormattingEnabled = true;
            this.procedures.Location = new System.Drawing.Point(37, 74);
            this.procedures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.procedures.Name = "procedures";
            this.procedures.Size = new System.Drawing.Size(209, 23);
            this.procedures.TabIndex = 20;
            this.procedures.SelectedIndexChanged += new System.EventHandler(this.procedures_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 286);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Выберите время:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Выберите процедуру:";
            // 
            // dateOfprocedure
            // 
            this.dateOfprocedure.FormattingEnabled = true;
            this.dateOfprocedure.Location = new System.Drawing.Point(41, 237);
            this.dateOfprocedure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateOfprocedure.Name = "dateOfprocedure";
            this.dateOfprocedure.Size = new System.Drawing.Size(209, 23);
            this.dateOfprocedure.TabIndex = 29;
            this.dateOfprocedure.SelectedIndexChanged += new System.EventHandler(this.dateOfProcedure_SelectedIndexChanged);
            // 
            // times
            // 
            this.times.FormattingEnabled = true;
            this.times.Location = new System.Drawing.Point(37, 320);
            this.times.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(233, 23);
            this.times.TabIndex = 22;
            this.times.SelectedIndexChanged += new System.EventHandler(this.times_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 201);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Выберите число:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 123);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 25;
            this.label16.Text = "Почта врача:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Записаться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeAnAppointment_Click);
            // 
            // MyAppointmentsPage
            // 
            this.MyAppointmentsPage.ContextMenuStrip = this.MyAppointmentsMenuStrip;
            this.MyAppointmentsPage.Controls.Add(this.splitContainer1);
            this.MyAppointmentsPage.ImageIndex = 1;
            this.MyAppointmentsPage.Location = new System.Drawing.Point(4, 24);
            this.MyAppointmentsPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MyAppointmentsPage.Name = "MyAppointmentsPage";
            this.MyAppointmentsPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MyAppointmentsPage.Size = new System.Drawing.Size(851, 563);
            this.MyAppointmentsPage.TabIndex = 1;
            this.MyAppointmentsPage.Text = "Мои записи";
            this.MyAppointmentsPage.UseVisualStyleBackColor = true;
            // 
            // MyAppointmentsMenuStrip
            // 
            this.MyAppointmentsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьСегодняшниеЗаписиToolStripMenuItem,
            this.показатьПодробнуюИнформациюToolStripMenuItem,
            this.очиститьТекущуюВкладкуToolStripMenuItem});
            this.MyAppointmentsMenuStrip.Name = "MyAppointmentsMenuStrip";
            this.MyAppointmentsMenuStrip.Size = new System.Drawing.Size(271, 70);
            // 
            // получитьСегодняшниеЗаписиToolStripMenuItem
            // 
            this.получитьСегодняшниеЗаписиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("получитьСегодняшниеЗаписиToolStripMenuItem.Image")));
            this.получитьСегодняшниеЗаписиToolStripMenuItem.Name = "получитьСегодняшниеЗаписиToolStripMenuItem";
            this.получитьСегодняшниеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.получитьСегодняшниеЗаписиToolStripMenuItem.Text = "Получить сегодняшние записи";
            // 
            // показатьПодробнуюИнформациюToolStripMenuItem
            // 
            this.показатьПодробнуюИнформациюToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("показатьПодробнуюИнформациюToolStripMenuItem.Image")));
            this.показатьПодробнуюИнформациюToolStripMenuItem.Name = "показатьПодробнуюИнформациюToolStripMenuItem";
            this.показатьПодробнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.показатьПодробнуюИнформациюToolStripMenuItem.Text = "Показать подробную информацию";
            this.показатьПодробнуюИнформациюToolStripMenuItem.Click += new System.EventHandler(this.GetAppointmentInfo_Click);
            // 
            // очиститьТекущуюВкладкуToolStripMenuItem
            // 
            this.очиститьТекущуюВкладкуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьТекущуюВкладкуToolStripMenuItem.Image")));
            this.очиститьТекущуюВкладкуToolStripMenuItem.Name = "очиститьТекущуюВкладкуToolStripMenuItem";
            this.очиститьТекущуюВкладкуToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.очиститьТекущуюВкладкуToolStripMenuItem.Text = "Очистить текущую вкладку";
            this.очиститьТекущуюВкладкуToolStripMenuItem.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(843, 557);
            this.splitContainer1.SplitterDistance = 583;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.myAppointments);
            this.groupBox3.Location = new System.Drawing.Point(14, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(516, 459);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ваши записи";
            // 
            // myAppointments
            // 
            this.myAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.myAppointments.FullRowSelect = true;
            this.myAppointments.GridLines = true;
            this.myAppointments.HideSelection = false;
            this.myAppointments.Location = new System.Drawing.Point(7, 30);
            this.myAppointments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.myAppointments.Name = "myAppointments";
            this.myAppointments.Size = new System.Drawing.Size(502, 344);
            this.myAppointments.TabIndex = 5;
            this.myAppointments.UseCompatibleStateImageBehavior = false;
            this.myAppointments.View = System.Windows.Forms.View.Details;
            this.myAppointments.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.myAppointments_ItemMouseHover);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id врача";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название процедуры";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата и время";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 169;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageLine});
            this.statusStrip2.Location = new System.Drawing.Point(0, 535);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip2.Size = new System.Drawing.Size(583, 22);
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // messageLine
            // 
            this.messageLine.Name = "messageLine";
            this.messageLine.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.HasSeen);
            this.groupBox2.Controls.Add(this.GetAppointments);
            this.groupBox2.Controls.Add(this.startTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.endTime);
            this.groupBox2.Location = new System.Drawing.Point(27, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(210, 352);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск записей";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(22, 262);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(164, 27);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // HasSeen
            // 
            this.HasSeen.AutoSize = true;
            this.HasSeen.Location = new System.Drawing.Point(22, 175);
            this.HasSeen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HasSeen.Name = "HasSeen";
            this.HasSeen.Size = new System.Drawing.Size(114, 19);
            this.HasSeen.TabIndex = 22;
            this.HasSeen.Text = "Просмотренные";
            this.HasSeen.UseVisualStyleBackColor = true;
            this.HasSeen.CheckedChanged += new System.EventHandler(this.HasSeen_CheckedChanged);
            // 
            // GetAppointments
            // 
            this.GetAppointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GetAppointments.Location = new System.Drawing.Point(22, 217);
            this.GetAppointments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetAppointments.Name = "GetAppointments";
            this.GetAppointments.Size = new System.Drawing.Size(164, 27);
            this.GetAppointments.TabIndex = 15;
            this.GetAppointments.Text = "Получить данные";
            this.GetAppointments.UseVisualStyleBackColor = true;
            this.GetAppointments.Click += new System.EventHandler(this.GetAppointments_Click);
            // 
            // startTime
            // 
            this.startTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startTime.BorderSize = 0;
            this.startTime.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("startTime.CalendarIcon")));
            this.startTime.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.startTime.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.startTime.Location = new System.Drawing.Point(22, 62);
            this.startTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(174, 22);
            this.startTime.SkinColor = System.Drawing.Color.White;
            this.startTime.TabIndex = 11;
            this.startTime.TextColor = System.Drawing.Color.Black;
            this.startTime.ValueChanged += new System.EventHandler(this.startEndTime_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Конечная дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Начальная дата:";
            // 
            // endTime
            // 
            this.endTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.endTime.BorderSize = 0;
            this.endTime.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("endTime.CalendarIcon")));
            this.endTime.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.endTime.Location = new System.Drawing.Point(22, 133);
            this.endTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(174, 22);
            this.endTime.SkinColor = System.Drawing.Color.White;
            this.endTime.TabIndex = 12;
            this.endTime.TextColor = System.Drawing.Color.Black;
            this.endTime.ValueChanged += new System.EventHandler(this.startEndTime_ValueChanged);
            // 
            // MyAccount
            // 
            this.MyAccount.BackColor = System.Drawing.Color.Transparent;
            this.MyAccount.ContextMenuStrip = this.MyAccountMenuStrip;
            this.MyAccount.Controls.Add(this.SetDarkTheme);
            this.MyAccount.Controls.Add(this.SetLightTheme);
            this.MyAccount.Controls.Add(this.ExitButton);
            this.MyAccount.Controls.Add(this.myReports);
            this.MyAccount.Controls.Add(this.phoneNubmer);
            this.MyAccount.Controls.Add(this.name);
            this.MyAccount.Controls.Add(this.email);
            this.MyAccount.Controls.Add(this.label4);
            this.MyAccount.ImageIndex = 2;
            this.MyAccount.Location = new System.Drawing.Point(4, 24);
            this.MyAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MyAccount.Name = "MyAccount";
            this.MyAccount.Size = new System.Drawing.Size(851, 563);
            this.MyAccount.TabIndex = 2;
            this.MyAccount.Text = "Мой аккаунт";
            // 
            // MyAccountMenuStrip
            // 
            this.MyAccountMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.показатьПодробнуюИнформациюToolStripMenuItem1});
            this.MyAccountMenuStrip.Name = "MyAccountMenuStrip";
            this.MyAccountMenuStrip.Size = new System.Drawing.Size(271, 48);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обновитьToolStripMenuItem.Image")));
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.Update_Click);
            // 
            // показатьПодробнуюИнформациюToolStripMenuItem1
            // 
            this.показатьПодробнуюИнформациюToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("показатьПодробнуюИнформациюToolStripMenuItem1.Image")));
            this.показатьПодробнуюИнформациюToolStripMenuItem1.Name = "показатьПодробнуюИнформациюToolStripMenuItem1";
            this.показатьПодробнуюИнформациюToolStripMenuItem1.Size = new System.Drawing.Size(270, 22);
            this.показатьПодробнуюИнформациюToolStripMenuItem1.Text = "Показать подробную информацию";
            this.показатьПодробнуюИнформациюToolStripMenuItem1.Click += new System.EventHandler(this.GetReportInformation_Click);
            // 
            // SetDarkTheme
            // 
            this.SetDarkTheme.Image = ((System.Drawing.Image)(resources.GetObject("SetDarkTheme.Image")));
            this.SetDarkTheme.Location = new System.Drawing.Point(43, 23);
            this.SetDarkTheme.Name = "SetDarkTheme";
            this.SetDarkTheme.Size = new System.Drawing.Size(36, 31);
            this.SetDarkTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SetDarkTheme.TabIndex = 15;
            this.SetDarkTheme.TabStop = false;
            this.SetDarkTheme.Click += new System.EventHandler(this.SetDarkTheme_Click);
            // 
            // SetLightTheme
            // 
            this.SetLightTheme.Image = global::MedicalCenter.Properties.Resources.DarkSwitch;
            this.SetLightTheme.Location = new System.Drawing.Point(43, 23);
            this.SetLightTheme.Name = "SetLightTheme";
            this.SetLightTheme.Size = new System.Drawing.Size(36, 31);
            this.SetLightTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SetLightTheme.TabIndex = 16;
            this.SetLightTheme.TabStop = false;
            this.SetLightTheme.Visible = false;
            this.SetLightTheme.Click += new System.EventHandler(this.SetLightTheme_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.Location = new System.Drawing.Point(43, 225);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(149, 27);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Выйти из аккаунта";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // myReports
            // 
            this.myReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.myReports.FullRowSelect = true;
            this.myReports.GridLines = true;
            this.myReports.HideSelection = false;
            this.myReports.Location = new System.Drawing.Point(280, 35);
            this.myReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.myReports.MultiSelect = false;
            this.myReports.Name = "myReports";
            this.myReports.Size = new System.Drawing.Size(553, 282);
            this.myReports.TabIndex = 12;
            this.myReports.UseCompatibleStateImageBehavior = false;
            this.myReports.View = System.Windows.Forms.View.Details;
            this.myReports.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.myReports_ItemMouseHover);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id врача";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Название процедуры";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата и время";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Рекомендации";
            this.columnHeader7.Width = 233;
            // 
            // phoneNubmer
            // 
            this.phoneNubmer.AutoSize = true;
            this.phoneNubmer.Location = new System.Drawing.Point(302, 475);
            this.phoneNubmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNubmer.Name = "phoneNubmer";
            this.phoneNubmer.Size = new System.Drawing.Size(40, 15);
            this.phoneNubmer.TabIndex = 4;
            this.phoneNubmer.Text = "phone:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(302, 427);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(36, 15);
            this.name.TabIndex = 3;
            this.name.Text = "name:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(302, 385);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(37, 15);
            this.email.TabIndex = 2;
            this.email.Text = "email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 1;
            // 
            // pagesImageList
            // 
            this.pagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pagesImageList.ImageStream")));
            this.pagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.pagesImageList.Images.SetKeyName(0, "MakeAnAppointment.png");
            this.pagesImageList.Images.SetKeyName(1, "myAppointments.png");
            this.pagesImageList.Images.SetKeyName(2, "MyAccount.png");
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 582);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(861, 625);
            this.MinimumSize = new System.Drawing.Size(861, 625);
            this.Name = "PatientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientForm_FormClosed);
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MyAppointmentsPage.ResumeLayout(false);
            this.MyAppointmentsMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MyAccount.ResumeLayout(false);
            this.MyAccount.PerformLayout();
            this.MyAccountMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SetDarkTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLightTheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage MyAppointmentsPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage MyAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phoneNubmer;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button GetAppointments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox doctors;
        private System.Windows.Forms.ComboBox procedures;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dateOfprocedure;
        private System.Windows.Forms.ComboBox times;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel appointmentState;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel messageLine;
        private System.Windows.Forms.ToolStripStatusLabel appointmentsAmount;
        private System.Windows.Forms.CheckBox HasSeen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip MyAppointmentsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem получитьСегодняшниеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьПодробнуюИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьТекущуюВкладкуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MyAccountMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьПодробнуюИнформациюToolStripMenuItem1;
        private System.Windows.Forms.ListView myAppointments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView myReports;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ImageList pagesImageList;
        private System.Windows.Forms.PictureBox SetDarkTheme;
        private System.Windows.Forms.PictureBox SetLightTheme;
        private CustomControls.CustomDateTimePicker startTime;
        private CustomControls.CustomDateTimePicker endTime;
    }
}