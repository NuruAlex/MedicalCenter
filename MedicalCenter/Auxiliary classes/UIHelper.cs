using MedicalCenter.Staffs;
using System.Windows.Forms;
using System.Collections.Generic;
using MedicalCenter.Accountants;

namespace MedicalCenter
{
    internal static class UIHelper
    {

        private static bool _capsLockIsOn = false;
        public static string CapsOnOff()
        {
            _capsLockIsOn = !_capsLockIsOn;
            if (_capsLockIsOn)
                return "Caps Lock включен";
            return "Caps Lock выключен";
        }

        public static class Show
        {
            private static void DoctorAppointments(ListView listViewToFill, List<Appointment>dataSource)
            {
                listViewToFill.Items.Clear();
                foreach (Appointment app in dataSource)
                    listViewToFill.Items.Add(new ListViewItem(app.ToDoctorArrayString()));
            }
            public  static void DoctorAppointments(ListView listViewToFill,string staffId) => DoctorAppointments(listViewToFill, DataBase.Get.DoctorAppointments(staffId));
            public  static void DoctorAppointments(ListView listViewToFill, string stuffId, string startDate,string endDate,bool hasSeen) => DoctorAppointments(listViewToFill, DataBase.Get.DoctorAppointments(stuffId, startDate, endDate, hasSeen));
       
            private static void PatientAppointment(ListView listViewToFill,List<Appointment>dataSource)
            {
                listViewToFill.Items.Clear();
                foreach (Appointment app in dataSource)
                    listViewToFill.Items.Add(new ListViewItem(app.ToPatientArrayString()));
            }
            public  static void PatientAppointments(ListView listViewToFill, string pEmail, string startDate, string endDate) => PatientAppointment(listViewToFill, DataBase.Get.PatientAppointments(pEmail, startDate, endDate));
            public  static void PatientAppointments(ListView listViewToFill, string pEmail, string startDate, string endDate, bool hasSeen) => PatientAppointment(listViewToFill, DataBase.Get.PatientAppointments(pEmail, startDate, endDate, hasSeen));

            private static void PatientReports(ListView listViewToFill,List<DoctorReport> dataSource)
            {
                listViewToFill.Items.Clear();
                foreach (DoctorReport rep in dataSource)
                    listViewToFill.Items.Add(new ListViewItem(rep.ToPatientArrayString()));
            }
            public  static void PatientReports(ListView listViewToFill,string pEmail) => PatientReports(listViewToFill,DataBase.Get.PatientReports(pEmail));
            public  static void PatientReports(ListView listViewToFill, string pEmail,string startDate,string endDate) => PatientReports(listViewToFill, DataBase.Get.PatientReports(pEmail, startDate, endDate));
           

            public static void AccountantReports(ListView listViewToFill,int staffId,string startDate,string endDate)
            {
                listViewToFill.Items.Clear();
                foreach (AccountantReport rep in DataBase.Get.AccountantReports(staffId, startDate,endDate))
                    listViewToFill.Items.Add(new ListViewItem(rep.ToAccountantArrayString()));
            }

            public static bool UserData(Label email,Label name,Label phone)
            {
                if(UserManager.CurrentUser == null)
                    return false;

                email.Text = "Ваша почта: " + UserManager.CurrentUser.pEmail;
                name.Text  = "Имя: " + UserManager.CurrentUser.pName;
                phone.Text = "Номер телефона: " + UserManager.CurrentUser.pPhoneNumber;
                return true;
            }
            public static bool StaffData(Label email, Label name, Label password,Label secondPassword)
        {
            if (StaffManager.CurrentStaff == null)
                return false;

            email.Text = "Ваша почта: " + StaffManager.CurrentStaff.sEmail;
            name.Text = "Имя: " + StaffManager.CurrentStaff.sName;
            password.Text = "Пароль: " + StaffManager.CurrentStaff.sPassword;
            secondPassword.Text = "Второй пароль: " + StaffManager.CurrentStaff.sSecondPassword;
            return true;
        }

        }
        public static void SelectCurrentListViewItem(ListViewItem itemToSelect)
        {
            itemToSelect.Selected = true;
            foreach (ListViewItem item in itemToSelect.ListView.Items)
                if (item != itemToSelect)
                    item.Selected = false;
        }
       
        public static class Clear
        {
            public static void DataGridView(DataGridView item)
            {
                if(item.DataSource!=null)
                {
                    item.DataSource = null;
                    return;
                }
                if (item.Rows.Count != 0)
                {
                    item.Rows.Clear();
                    return;
                }
            }
            public static void Labels(params Label[]lablelsToClear)
            {
                foreach (Label label in lablelsToClear)
                    label.Text = "";
            }
            public static void Comboboxes(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedItem = null;
                comboBox.Text = "";
                comboBox.Items.Clear();
            }
        }
        }

        public static void FillCombobox<T>(ComboBox comboBoxToFill, List<T> dataSource)
        {
            comboBoxToFill.Items.Clear();
            foreach (T item in dataSource)
                comboBoxToFill.Items.Add(item.ToString());
        }


    }
}
