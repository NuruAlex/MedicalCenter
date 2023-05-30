using System;
using System.Collections.Generic;
using MedicalCenter.Verification;

namespace MedicalCenter.Staffs
{
    internal static class StaffManager
    {
        public static IStaff CurrentStaff { get; set; }
        private static IStaff TemproraryStaff { get; set; }

        public static void Enter()
        {
            if (TemproraryStaff == null) return;

            if (TemproraryStaff.id != DataBase.Get.LastStaffEntered())
                DataBase.Update.LastStaffEntered(TemproraryStaff.id);

            CurrentStaff = TemproraryStaff;
            CurrentStaff.GoNext();
        }
        public static bool StaffIsExist(string email, string state, string password, string secondPassword)
        {
            TemproraryStaff = GetStaff(email, state);
            return TemproraryStaff != null && TemproraryStaff.sPassword == password && TemproraryStaff.sSecondPassword == secondPassword;
        }
        public static bool StaffHasEntered() => TemproraryStaff.HasEntered;
        public static bool PassConfirmation(bool isNewMachine)
        {
            if (TemproraryStaff == null)
                return false;
            if(!VerificationManager.PassConfirmation(TemproraryStaff.sEmail, TemproraryStaff.sName, TemproraryStaff.sKeyWord, isNewMachine))
                return false;
            DataBase.NonQueryRequestExecuteAsync($"update Stuffs set HasEntered =1 where sEmail ='{TemproraryStaff.sEmail}' and sState ='{TemproraryStaff.sState}'");
            return true;
        }

        public static bool PassRegistrationConfirmation(IStaff s)
        {
            if (StaffIsExist(s.sEmail, s.sState, s.sPassword, s.sSecondPassword))
                return false;
            if (!VerificationManager.PassRegistrationConfimation(s.sEmail, s.sName))
                return false;
            AddStaff(s);
            return true;
        }
        public static IStaff GetStaffById(int id)  => DataBase.ConvertToList<Doctor>(DataBase.SelectRequestExecute($"select * from Stuffs where id = {id}"))[0];
        public static bool IsCorrectMachineName(string email,string state) => DataBase.Get.StaffMachineNames(GetStaff(email,state).id).Contains(Environment.MachineName);
        public static void AddMachine(string email,string state) => _ = DataBase.NonQueryRequestExecuteAsync($"insert into StaffDevices values ('{GetStaff(email,state).id}','{Environment.MachineName}')");
        private static void AddStaff(IStaff staff)
        {
            if (staff == null) return;

            if (staff.sState == "Главврач") return;


            _ = DataBase.NonQueryRequestExecuteAsync($"insert into Stuffs values('{staff.sEmail}','{staff.sName}','{staff.sPassword}','{staff.sSecondPassword}','{staff.sKeyWord}','{staff.sPost}','{staff.sLicence}','{staff.sState}')");
        }
        public static bool EmailAndStateIsExist(string email,string state)
            => DataBase.SelectRequestExecute($"select * from Stuffs where sEmail='{email}' and sState='{state}'").Rows.Count == 1;

        private static IStaff GetStaff(string email, string state)
        {
            if (!EmailAndStateIsExist(email, state))
                return null;

            switch (state)
            {
                case "Администратор": return GetStaff<Admin>(email, state);

                case "Врач": return GetStaff<Doctor>(email, state);

                case "Бухгалтер": return GetStaff<Accountant>(email, state);

                case "Администратор рецепшен": return GetStaff<Reseptionist>(email, state);

                case "Главврач": return GetStaff<HeadPhysician>(email, state);

                default: return null;
            }
        }
        private static IStaff GetStaff<T>(string email, string state)
        {
            List<T> stuffs = DataBase.ConvertToList<T>
                   (DataBase.SelectRequestExecute($"select * from Stuffs where sEmail ='{email}' and sState ='{state}'"));
            if (stuffs.Count == 1)
                return (IStaff)stuffs[0];
            return null;
        }

    }
}
