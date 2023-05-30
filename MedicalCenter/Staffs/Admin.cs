using MedicalCenter.Admins;


namespace MedicalCenter.Staffs
{
    internal class Admin:IStaff
    {
        public int id { get; set; }
        public string sEmail { get; set; }
        public string sPassword { get; set; }
        public string sSecondPassword { get; set; }
        public string sKeyWord { get; set; }
        public string sName { get; set; }
        public string sPost { get; set; }
        public string sLicence { get; set; }
        public string sState { get; set; }
        public bool HasEntered { get; set; }

        public void GoNext()
        {
            AdminForm form = new AdminForm();
            form.Show();
        }

    }
}
