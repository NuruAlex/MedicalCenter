using System;
using MedicalCenter.HeadPhysicians;
using System.Collections.Generic;

namespace MedicalCenter
{
    internal static class WorkSchedule
    {
        private static Random _random = new Random();
        private static bool GenerateDayType() => Convert.ToBoolean(_random.Next(2));
        public static bool DayIsReserved(string stuffId, string date) => DataBase.SelectRequestExecute($"select * from WorkSchedule where stuffId = {stuffId} and dayDate = '{date}'").Rows.Count == 1;
        public static List<Day> GetWorkSchedule(string startDate, string endDate) => DataBase.ConvertToList<Day>(DataBase.SelectRequestExecute($"select stuffId,dayType,dayDate from WorkSchedule where dayDate>='{startDate}' and dayDate <='{endDate}'"));


        public static void GenerateDay(string staffId, string date)
        {
            if (DayIsReserved(staffId.ToString(), date))
                return;

            if (GenerateDayType())
                _ = DataBase.Add.WorkDay(staffId, date);
            else
                _ = DataBase.Add.RestDay(staffId, date);
        }
        public static void AddDay(string staffId,string dayType,string date)
        {
            if (DayIsReserved(staffId, date))
                return;
            if (dayType == "False")
                _ = DataBase.Add.RestDay(staffId, date);
            else
                _ = DataBase.Add.WorkDay(staffId, date);
        }
        public static void UpdateDayType(string staffId, string dayType, string date) => DataBase.Update.Day(staffId,dayType,date);
    }
}
