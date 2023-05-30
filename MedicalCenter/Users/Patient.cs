using MedicalCenter.Patients;
using System;

namespace MedicalCenter.Users
{
    internal class Patient 
    {
        public string pEmail { get; set; }
        public string pName { get; set; }
        public string pPassword { get; set; }
        public string pPhoneNumber { get; set; }
        public DateTime pBirth { get; set; }
        public string KeyWord { get; set; }
        public bool HasEntered { get; set; }


        public void GoNext()
        {
            PatientForm form = new PatientForm();   
            form.Show();
        }
    }
}
