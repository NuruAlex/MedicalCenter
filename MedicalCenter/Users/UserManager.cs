using MedicalCenter.Users;
using MedicalCenter.Verification;
using System;
using System.Collections.Generic;

namespace MedicalCenter
{
    internal static class UserManager
    {
        public static Patient CurrentUser { get; set; }
        private static Patient TemproraryUser { get; set; }

        public static bool PassRegistationConfirmation(Patient patient)
        {
            if (UserIsExist(patient.pEmail, patient.pPassword))
                return false;
            if (!VerificationManager.PassRegistrationConfimation(patient.pEmail, patient.pName))
                return false;
            TemproraryUser = patient;
            AddUser(patient);
            return true;
        }

        public static bool IsCorrectMachineName(string email) => DataBase.Get.PatientMachineNames(email).Contains(Environment.MachineName);
        public static bool UserIsExist(string email, string password)
        {
            TemproraryUser = GetUser(email);
            return TemproraryUser != null && TemproraryUser.pPassword == password;
        }
        public static bool UserHasEntered() => TemproraryUser.HasEntered;
        public static void Enter()
        {
            if (TemproraryUser == null) return;
            
            if(TemproraryUser.pEmail !=DataBase.Get.LastPatientEntered())
                _ = DataBase.Update.LastPatientEntered(TemproraryUser.pEmail);

            CurrentUser = TemproraryUser;
            CurrentUser.GoNext();
        }

        private static void AddUser(Patient user) => _ = DataBase.NonQueryRequestExecuteAsync($"insert into Patients values('{user.pEmail}','{user.pName}','{user.pBirth.ToString("d")}','{user.pPassword}','{user.pPhoneNumber}','{user.KeyWord}')");
        public static bool PassConfirmation(bool isNewMachine)
        {
            if (TemproraryUser == null)
                return false;
            if(!VerificationManager.PassConfirmation(TemproraryUser.pEmail, TemproraryUser.pName, TemproraryUser.KeyWord, isNewMachine))
                return false;
            if(!UserHasEntered())
               _ = DataBase.NonQueryRequestExecuteAsync($"update Patients set HasEntered = 1 where pEmail = '{TemproraryUser.pEmail}'");
            return true;
        }
        public static List<Patient> GetPatientsLike(string name) => DataBase.ConvertToList<Patient>(DataBase.SelectRequestExecute($"select * from Patients where pName like '{name}%'"));
        public static void AddMachine(string email) => _ = DataBase.NonQueryRequestExecuteAsync($"insert into PatientDevices values ('{email}','{Environment.MachineName}')");
        public static Patient GetUser(string email)
        {
            if (!EmailIsExist(email))  return null;

            return DataBase.ConvertToList<Patient> (DataBase.SelectRequestExecute($"select * from Patients where pEmail ='{email}'"))[0];
        }
        public static bool EmailIsExist(string email) => DataBase.SelectRequestExecute($"select * from Patients where pEmail='{email}'").Rows.Count == 1;
      
    }
}
