using System;
using MedicalCenter.HeadPhysicians;

namespace MedicalCenter.Staffs
{
    internal class HeadPhysician : IStaff
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
            HeadPhysicianForm form = new HeadPhysicianForm();
            form.Show();
        }

       
    }
}
