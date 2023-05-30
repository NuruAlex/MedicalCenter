using System;
using System.Windows.Forms;
using MedicalCenter.Staffs;
using MedicalCenter.Verification;
using System.Collections.Generic;


namespace MedicalCenter.Patients
{
    public partial class PatientForm : Form
    {
        private List<Doctor> _doctorsList;

        public PatientForm() => InitializeComponent();
        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void LoadMyReports() => UIHelper.Show.PatientReports(myReports, UserManager.CurrentUser.pEmail);

        private void LoadTheme()
        {
            Theme.Set.FormStyle(this);
            SetLightTheme.Visible = false;
            SetDarkTheme.Visible = false;

            if (Theme.CurrentThemeType == Theme.ThemesTypes.Dark)
                SetLightTheme.Visible = true;
            if (Theme.CurrentThemeType == Theme.ThemesTypes.Light)
                SetDarkTheme.Visible = true;
        }
        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            UIHelper.Show.UserData(email, name, phoneNubmer);
            LoadMyReports();
            UIHelper.FillCombobox(procedures, DataBase.Get.Procedures());
        }

        //Записаться ко врачу

        private void GetAppointmentInfo_Click(object sender, EventArgs e)
        {
            if (myAppointments.Items.Count == 0)
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
            string pEmail = UserManager.CurrentUser.pEmail;
            int staffId = Convert.ToInt32(item.SubItems[0].Text);
            string procedureTitle = item.SubItems[1].Text;
            string procedureTime = item.SubItems[2].Text;
            AppointmentHelper.ShowFullInformation(staffId, procedureTitle, procedureTime, pEmail);
        }
        private void procedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (procedures.SelectedItem == null) return;

            UIHelper.Clear.Comboboxes(doctors, times, dateOfprocedure);
            AppointmentHelper.ProcedureTitle = procedures.SelectedItem.ToString();

            _doctorsList = AppointmentHelper.DoctorWhoDoProcedures();
            UIHelper.FillCombobox(doctors, _doctorsList);
        }
        private void doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctors.SelectedItem == null) return;

            UIHelper.Clear.Comboboxes(times, dateOfprocedure);
            AppointmentHelper.CurrentStuffId = _doctorsList[doctors.SelectedIndex].id;
            dateOfprocedure.Items.AddRange(AppointmentHelper.DoctorFreeDays());
        }
        private void dateOfProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateOfprocedure.SelectedItem == null) return;

            AppointmentHelper.dayOfProcedure = dateOfprocedure.SelectedItem.ToString();
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
            if (Validator.IsNulls(procedures.SelectedItem, doctors.SelectedItem, dateOfprocedure.SelectedItem, times.SelectedItem))
            {
                MessageBox.Show("заполните все данные!");
                return;
            }

            AppointmentHelper.MakeAnAppointment(UserManager.CurrentUser.pEmail);

            EmailManager.SendMessage(UserManager.CurrentUser.pEmail, "Внимание!", $"Вы записались на прием {dateOfprocedure.SelectedItem} числа, \"{procedures.SelectedItem}\" к {doctors.SelectedItem} на {times.SelectedItem}");

            EmailManager.SendMessage(_doctorsList.Find(i => i.id == AppointmentHelper.CurrentStuffId).sEmail, "Добрый день", $"К вам записались на прием  \"{procedures.SelectedItem}\" на {dateOfprocedure.SelectedItem} числа в {times.SelectedItem}");
            DeleteAppointmentData("Вы были успешно записаны!");
        }
        private void DeleteAll_Click(object sender, EventArgs e) => DeleteAppointmentData("Данные были очищены...");
        private void DeleteAppointmentData(string AppointmentStateMessage)
        {
            UIHelper.Clear.Comboboxes(times, doctors, dateOfprocedure);
            procedures.Text = "";
            procedures.SelectedItem = null;
            appointmentState.Text = AppointmentStateMessage;
        }


        //Мои записи

        private void myAppointments_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);
        private void LoadMyAppoinments()
        {
            if (startTime.Value >= endTime.Value)
            {
                MessageBox.Show("Выберите даты корректно!");
                messageLine.Text = "Записи не были загружены!";
                appointmentsAmount.Text = "";
                return;
            }
            string pEmail = UserManager.CurrentUser.pEmail;
            string startDate = startTime.Value.ToString("d");
            string endDate = endTime.Value.ToString("d");

            UIHelper.Show.PatientAppointments(myAppointments, pEmail, startDate, endDate, HasSeen.Checked);

            messageLine.Text = "Записи были успешно загружены!";
            appointmentsAmount.Text = myAppointments.Items.Count.ToString() + " записей";
        }
        private void GetAppointments_Click(object sender, EventArgs e) => LoadMyAppoinments();
        private void HasSeen_CheckedChanged(object sender, EventArgs e) => LoadMyAppoinments();
        private void startEndTime_ValueChanged(object sender, EventArgs e) => LoadMyAppoinments();
        private void GetReportInformation_Click(object sender, EventArgs e)
        {
            if (myReports.Items.Count == 0)
            {
                MessageBox.Show("Загрузите записи");
            }
            if (myReports.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись");
                return;
            }

            ListViewItem item = myReports.SelectedItems[0];
            string pEmail = UserManager.CurrentUser.pEmail;
            int staffId = Convert.ToInt32(item.SubItems[0].Text);
            string procedureTitle = item.SubItems[1].Text;
            string procedureTime = item.SubItems[2].Text;
            AppointmentHelper.ShowFullInformation(staffId, procedureTitle, procedureTime, pEmail);

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            myAppointments.Items.Clear();
            messageLine.Text = "Мы все почистили:)";
            appointmentsAmount.Text = "";
        }

        //мой аккаунт

        private void myReports_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) => UIHelper.SelectCurrentListViewItem(e.Item);
        private void Update_Click(object sender, EventArgs e) => LoadMyReports();
        private void ExitButton_Click(object sender, EventArgs e) => VerificationManager.ExitFrom(this);

        private void SetDarkTheme_Click(object sender, EventArgs e)
        {
            SetLightTheme.Visible = true;
            SetDarkTheme.Visible = false;
            Theme.Set.CurrentTheme(Theme.ThemesTypes.Dark);
            Theme.Set.FormStyle(this);
        }
        private void SetLightTheme_Click(object sender, EventArgs e)
        {
            SetLightTheme.Visible = false;
            SetDarkTheme.Visible = true;
            Theme.Set.CurrentTheme(Theme.ThemesTypes.Light);
            Theme.Set.FormStyle(this);
        }
    }
}
