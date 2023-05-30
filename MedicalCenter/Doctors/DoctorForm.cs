using System;
using System.Drawing;
using MedicalCenter.Users;
using System.Windows.Forms;
using MedicalCenter.Staffs;
using MedicalCenter.Verification;
using System.Collections.Generic;

namespace MedicalCenter.Doctors
{
    public partial class DoctorForm : Form
    {
        //Общие поля и методы
        private List<Doctor> _doctorsList;
      
        public DoctorForm() => InitializeComponent();
        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            UIHelper.Show.StaffData(aEmail, aName, aPassword, aSecondPassword);
            UIHelper.Show.DoctorAppointments(myAppointments, StaffManager.CurrentStaff.id.ToString());
            UIHelper.FillCombobox(procedures, DataBase.Get.Procedures());
            Theme.Set.FormStyle(this);
        }
       
        //Мои записи

        private void myAppointments_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);
        private void GetAppointmentInfo_Click(object sender, EventArgs e)
        {
            if(myAppointments.Items.Count == 0)
            {
                MessageBox.Show("загрузите записи");
                return;
            }
            if (myAppointments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись");
                return;
            }
            ListViewItem item = myAppointments.SelectedItems[0];
            int staffId = StaffManager.CurrentStaff.id;
            string pEmail = item.SubItems[0].Text;
            string procedureTitle = item.SubItems[1].Text;
            string procedureTime = item.SubItems[2].Text;
            AppointmentHelper.ShowFullInformation(staffId, procedureTitle, procedureTime, pEmail);
        }
        private void openSeachAppointmentPanel_Click(object sender, EventArgs e)
        {
            openSeachAppointmentPanel.Visible = false;
            while(searchAppointmentsPanel.Width < 240)
            {
                System.Threading.Thread.Sleep(15);
                searchAppointmentsPanel.Width += 20;
            }
        }
        private void closeSearchAppointmentPanel_Click(object sender, EventArgs e)
        {
            openSeachAppointmentPanel.Visible = true;
            while (searchAppointmentsPanel.Width > 0)
            {
                System.Threading.Thread.Sleep(15);
                searchAppointmentsPanel.Width -= 20;
            }
        }
        private void LoadAppointments()
        {
            if (startTime.Value >= endTime.Value)
            {
                MessageBox.Show("Выберите даты корректно!");
                messageLine.Text = "Записи не были загружены!";
                appointmentsAmount.Text = "";
                return;
            }

            string staffId = StaffManager.CurrentStaff.id.ToString();
            string startDate = startTime.Value.ToString("d");
            string endDate = endTime.Value.ToString("d");
            bool hasSeen = HasSeen.Checked;

            UIHelper.Show.DoctorAppointments(myAppointments, staffId, startDate, endDate, hasSeen);

            messageLine.Text = "Записи были успешно загружены!";
            appointmentsAmount.Text = myAppointments.Items.Count.ToString() + " записей";
        }
        private void GetTodayAppointments_Click(object sender, EventArgs e)
        {
            UIHelper.Show.DoctorAppointments(myAppointments, StaffManager.CurrentStaff.id.ToString());
           
            messageLine.Text = "Записи были успешно загружены!";
            appointmentsAmount.Text = myAppointments.Items.Count.ToString() + " записей на сегодня";
        }

        private void GetAppointments_Click(object sender, EventArgs e) => LoadAppointments();
        private void HasSeen_CheckedChanged(object sender, EventArgs e) => LoadAppointments();
        private void startEndTime_ValueChanged(object sender, EventArgs e) => LoadAppointments();
        private void CreateReport_Click(object sender, EventArgs e)
        {
            if (myAppointments.Items.Count == 0 && patientAppointments.Items.Count == 0)
            {
                MessageBox.Show("Загрузите записи");
                return;
            }
            ListViewItem item = null;
            
            if (myAppointments.SelectedItems.Count == 0 && patientAppointments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись");
                return;
            }

            if(myAppointments.SelectedItems.Count != 0)
                item = myAppointments.SelectedItems[0];

            if (patientAppointments.SelectedItems.Count != 0)
                item = patientAppointments.SelectedItems[0];

            if(item == null)
            {
                MessageBox.Show("К сожалению произошла ошибка");
                return;
            }

            string pEmail = item.SubItems[0].Text;
            string procedureTitle = item.SubItems[1].Text;
            string procedureTime = item.SubItems[2].Text;

            if (AppointmentHelper.GetAppointment(StaffManager.CurrentStaff.id, procedureTitle, procedureTime, pEmail).HasSeen)
            {
                MessageBox.Show("Выбранная вами запись уже имеет отчет!");
                return;
            }

            AddNewPage(pEmail,procedureTitle,procedureTime);
            myAppointments.Items.RemoveAt(item.Index);
        }
        private void AddNewPage(string pEmail,string procedureTitle,string procedureTime)
        {
            TabPage newPage = new TabPage(pEmail + ',' + procedureTitle + ',' + procedureTime);
            Button sendReport = new Button()
            {
                Location = new Point(255, 437),
                Name = "SendReportButton",
                Size = new Size(156, 23),
                TabIndex = 12,
                Text = "Отправить отчет",
                UseVisualStyleBackColor = true,
            };
            sendReport.Click += new EventHandler(SendReport_Click);

            newPage.Controls.AddRange(new Control[]
            {
                new Label() { Location = new Point(40, 19),  AutoSize = true, TabIndex = 1,  Text = "Жалобы:"                   },
                new Label() { Location = new Point(40, 181), AutoSize = true, TabIndex = 2,  Text = "Общий осмотр:"             },
                new Label() { Location = new Point(40, 242), AutoSize = true, TabIndex = 4,  Text = "Основной диагноз"          },
                new Label() { Location = new Point(40, 291), AutoSize = true, TabIndex = 5,  Text = "Лекарственные назначния:" },
                new Label() { Location = new Point(40, 336), AutoSize = true, TabIndex = 6,  Text = "Рекомендации:"             },
                new Label() { Location = new Point(40, 378), AutoSize = true, TabIndex = 7, Text = "Вывод:"                   },

                new Label(){  Location = new Point(600,200), AutoSize = true,   Name = "pEmail",Text = pEmail},
                new Label(){  Location = new Point(600,300), AutoSize = true,   Name = "procedureTitle",Text = procedureTitle},
                new Label(){  Location = new Point(600,400), AutoSize = true,   Name = "procedureTime",Text = procedureTime},
                new RichTextBox(){ Location = new Point(196, 19),  Name = $"complaints",     Size = new Size(292, 140), TabIndex = 0  },
                new RichTextBox(){ Location = new Point(196, 181), Name = $"inspection",     Size = new Size(292, 28),  TabIndex = 3  },
                new RichTextBox(){ Location = new Point(196, 242), Name = $"diagnosis",      Size = new Size(292, 22),  TabIndex = 8  },
                new RichTextBox(){ Location = new Point(196, 282), Name = $"drugs",          Size = new Size(292, 22),  TabIndex = 9  },
                new RichTextBox(){ Location = new Point(196, 327), Name = $"recomendations", Size = new Size(292, 22),  TabIndex = 10 },
                new RichTextBox(){ Location = new Point(196, 369), Name = $"conclusion",     Size = new Size(292, 22),  TabIndex = 11 },
                sendReport
            });
            tabControl1.TabPages.Add(newPage);
        }
        private void SendReport_Click(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;


            string pEmail = tabPage.Controls["pEmail"].Text;
            string procedureTitle = tabPage.Controls["procedureTitle"].Text;
            DateTime procedureTime = Convert.ToDateTime(tabPage.Controls["procedureTime"].Text);

            string complaints = tabPage.Controls[$"complaints"].Text;
            string inspection = tabPage.Controls[$"inspection"].Text;
            string diagnosis = tabPage.Controls[$"diagnosis"].Text;
            string drugs = tabPage.Controls[$"drugs"].Text;
            string recomendations = tabPage.Controls[$"recomendations"].Text;
            string conclusion = tabPage.Controls[$"conclusion"].Text;

            if (Validator.IsEmptyStrings(complaints, inspection, diagnosis, drugs, recomendations, conclusion))
            {
                MessageBox.Show("Все поля обязательно для заполнения!");
                return;
            }

            _ = DataBase.Add.Report(new DoctorReport
            {
                pEmail = pEmail,
                stuffId = StaffManager.CurrentStaff.id,
                procedureTitle = procedureTitle,
                submitionTime = DateTime.Now,
                procedureTime = procedureTime,
                complaints = complaints,
                inspection = inspection,
                diagnosis = diagnosis,
                drugs = drugs,
                recomendations = recomendations,
                conclusion = conclusion
            });
            AppointmentHelper.MarkAsSeen(StaffManager.CurrentStaff.id, procedureTitle, procedureTime.ToString("G"), pEmail);

            tabControl1.Controls.Remove(tabPage);
            MessageBox.Show("Отчет успешно отправлен!");

            EmailManager.SendMessage(pEmail,
                $"отчет о \"{procedureTitle}\" за {DateTime.Now}",
                $"Результаты общего осмотра: {inspection}\n" +
                $"Диагноз: {diagnosis}\n" +
                $"Рекомендации: {recomendations}\n" +
                $"Заключения врача: {conclusion}\n" +
                $"--- С уважением {StaffManager.CurrentStaff.sName} --- "
                );
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            myAppointments.Items.Clear();
            messageLine.Text = "Мы все почистили:)";
            appointmentsAmount.Text = "";
        }

        //поиск

        private void SearhPatientName_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (SearhPatientName.Text == "")
            {
                PatientFindMessages.Text = "Ожидаем ввода имени..";
                return;
            }
           
            List<Patient> patientList = UserManager.GetPatientsLike(SearhPatientName.Text);

            if (patientList.Count == 0)
            {
                PatientFindMessages.Text = "Ничего не найдено...";
                return;
            }
            foreach (Patient p in patientList)
                listView1.Items.Add(new ListViewItem(new string[] { p.pName}));
        }
        private void patientAppointments_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);
        private void patientReports_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);
        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);

        private void LoadPatientData()
        {
            if (startDate.Value >= endDate.Value)
            {
                MessageBox.Show("Выберите даты корректно!");
                messageLine.Text = "Записи не были загружены!";
                appointmentsAmount.Text = "0 записей";
                return;
            }
            if (listView1.SelectedItems.Count == 0)
                return;
           
            Patient patient = UserManager.GetPatientsLike(listView1.SelectedItems[0].SubItems[0].Text)[0];

            patientEmail.Text = "Почта: " + patient.pEmail;
            patientPhoneNumber.Text = "Номер телефона: " + patient.pPhoneNumber;
            patientBirth.Text = "Дата рождения: " + patient.pBirth.ToString("d");

            string start = startDate.Value.ToString("d");
            string end = endDate.Value.ToString("d");

            UIHelper.Show.PatientAppointments(patientAppointments, patient.pEmail, start, end);
            UIHelper.Show.PatientReports(patientReports, patient.pEmail, start, end);

            PatientFindMessages.Text = "Данные были Загружены";
            PatientData.Text = $"Количество записей: {patientAppointments.Items.Count}, отчетов врачей: {patientReports.Items.Count}";
        }
        private void ClearPatientData_Click(object sender, EventArgs e)
        {
            patientEmail.Text = "Имя: ";
            patientPhoneNumber.Text = "Номер телефона: ";
            patientBirth.Text = "Дата рождения: ";
            SearhPatientName.Text = "";
            patientAppointments.Items.Clear();
            patientReports.Items.Clear();
            PatientFindMessages.Text = "Данные были очищены";
            PatientData.Text = "";
        }
        private void FindPatientButton_Click(object sender, EventArgs e) => LoadPatientData();
        private void startEndDate_ValueChanged(object sender, EventArgs e) => LoadPatientData();
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) => LoadPatientData();
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(patientAppointments.Items.Count == 0)
            {
                MessageBox.Show("Загрузите записи!");
                return;
            }
            if (patientAppointments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись");
                return;
            }
            ListViewItem item = patientAppointments.SelectedItems[0];
            int staffId = StaffManager.CurrentStaff.id;
            string pEmail = item.SubItems[0].Text;
            string procedureTitle = item.SubItems[1].Text;
            string procedureTime = item.SubItems[2].Text;
            AppointmentHelper.ShowFullInformation(staffId, procedureTitle, procedureTime, pEmail);
        }

        
        //Направление

        private void patientName_TextChanged(object sender, EventArgs e)
        {
            variants.Items.Clear();
            
            if(name.Text == "")
            {
                AppointmentState.Text = "Ожидаем ввода имени..";
                return;
            }

            List<Patient> patientList = UserManager.GetPatientsLike(name.Text);

            if(patientList.Count == 0)
            {
                AppointmentState.Text = "Ничего не найдено...";
                return;
            }
            foreach (Patient p in patientList)
                variants.Items.Add(new ListViewItem(new string[] { p.pName, p.pEmail }));
        }
        private void variants_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);
       
        private void procedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (procedures.SelectedItem == null) return;

            UIHelper.Clear.Comboboxes(doctors, times, dateOfProcedure);
            AppointmentHelper.ProcedureTitle = procedures.SelectedItem.ToString();

            _doctorsList = AppointmentHelper.DoctorWhoDoProcedures();
            UIHelper.FillCombobox(doctors, _doctorsList);
        }
        private void doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctors.SelectedItem == null) return;

            UIHelper.Clear.Comboboxes(times, dateOfProcedure);
            AppointmentHelper.CurrentStuffId = _doctorsList[doctors.SelectedIndex].id;
            dateOfProcedure.Items.AddRange(AppointmentHelper.DoctorFreeDays());
        }
        private void dateOfProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateOfProcedure.SelectedItem == null) return;

            AppointmentHelper.dayOfProcedure = dateOfProcedure.SelectedItem.ToString();
            times.Items.AddRange(AppointmentHelper.FreeTimes().ToArray());

            if (times.Items.Count == 0)
            {
                times.Visible = false;
                MessageBox.Show("К сожалению произошла ошибка:(", "У этого врача нет свободного времени для записи на это число", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            times.Visible = true;
        }
        private void times_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (times.SelectedItem != null)
                AppointmentHelper.time = times.SelectedItem.ToString();
        }
        private void MakeAnAppointment_Click(object sender, EventArgs e)
        {
            if (Validator.IsNulls(procedures.SelectedItem, doctors.SelectedItem, dateOfProcedure.SelectedItem, times.SelectedItem))
            {
                MessageBox.Show("заполните все данные!");
                return;
            }
            if(variants.SelectedItems.Count == 0)
            {
                MessageBox.Show("выберите почту пациента");
                return;
            }

            string pEmail = variants.SelectedItems[0].SubItems[1].Text;
            AppointmentHelper.MakeAnAppointment(pEmail);

            EmailManager.SendMessage(pEmail, "Внимание!", $"Напрвление на прием {dateOfProcedure.SelectedItem} числа, \"{procedures.SelectedItem}\" к {doctors.SelectedItem} на {times.SelectedItem}");
            EmailManager.SendMessage(_doctorsList.Find(i => i.id == AppointmentHelper.CurrentStuffId).sEmail, "Добрый день", $"К вам записались на прием  \"{procedures.SelectedItem}\" на {dateOfProcedure.SelectedItem} числа в {times.SelectedItem}");
            name.Text = "";
            DeleteAppointmentData("Вы Записали пациента!");
        }
        private void DeleteAll_Click(object sender, EventArgs e) => DeleteAppointmentData("Данные были очищены...");
        private void DeleteAppointmentData(string AppointmentStateMessage)
        {
            UIHelper.Clear.Comboboxes(times, doctors, dateOfProcedure);
            procedures.Text = "";
            procedures.SelectedItem = null;
            AppointmentState.Text = AppointmentStateMessage;
        }


        //Мой аккаунт
        private void ExitButton_Click(object sender, EventArgs e) => VerificationManager.ExitFrom(this);

    }
}
