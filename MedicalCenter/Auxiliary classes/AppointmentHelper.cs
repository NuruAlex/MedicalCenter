using System;
using System.Data;
using MedicalCenter.Staffs;
using System.Collections.Generic;
using MedicalCenter.Doctors;

namespace MedicalCenter
{
    internal static class AppointmentHelper
    {
        private static int _appointmentInterval = 30;
        private static DateTime _start { get; set; }
        private static DateTime _end { get; set; }
        public static string dayOfProcedure { get; set; }
        public static string time { get; set; }
        public static string ProcedureTitle { get; set; }
        public static int CurrentStuffId { get; set; }

        public static List<Doctor> DoctorWhoDoProcedures()
            =>DataBase.ConvertToList<Doctor>(
                DataBase.SelectRequestExecute($"select st.id,st.sEmail,st.sName,st.sPassword,st.sSecondPassword,st.sKeyWord,st.sPost,st.sLicence,st.sState " +
                                              $"from Stuffs st left join dPostThreatments dpt " +
                                              $"on st.sPost = dpt.dPost " +
                                              $"where st.sState = 'Врач' and dpt.title = '{ProcedureTitle}'"));

        public static string[] DoctorFreeDays()
        {
            List<string> freeDates = new List<string>();
            DataTable table = DataBase.SelectRequestExecute($"select dayDate from WorkSchedule where stuffId = {CurrentStuffId} and dayType = 1 and dayDate >= GetDate()");

            foreach (DataRow row in table.Rows)
                freeDates.Add(Convert.ToDateTime(row["dayDate"]).ToString("d"));
            return freeDates.ToArray();
        }
        public static List<string> FreeTimes()
        {
            List<string> freeTimes = new List<string>();
            List<string> reservedTimes = ReservedTimes();

            if(dayOfProcedure != DateTime.Today.ToString("d"))
                    _start = Convert.ToDateTime("9:00:00");
            if (dayOfProcedure == DateTime.Today.ToString("d"))
            {
                _start = DateTime.Now;
                _start = _start.AddMilliseconds(-_start.Millisecond).AddSeconds(-_start.Second);//Убираем секунды и милисекунды
               
                
                int minutes = _start.Minute < 30 ? 0 : _start.Minute > 30 ? 60 : 30;
                _start = _start.AddMinutes(minutes - _start.Minute);//убираем минуты до 0 либо до 60

            }
                
             _end = Convert.ToDateTime("21:00:00");


            while (_start < _end)
            {
                if (!reservedTimes.Contains(_start.ToString("HH:mm")))
                    freeTimes.Add(_start.ToString("HH:mm"));
                _start = _start.AddMinutes(_appointmentInterval);
            }
            return freeTimes;
        }
        private static DateTime GetFullTime()
        {
            DateTime date = Convert.ToDateTime(dayOfProcedure);
            DateTime fullTime = new DateTime
             (
                date.Year, date.Month, date.Day,
                Convert.ToDateTime(time).Hour,
                Convert.ToDateTime(time).Minute,
                 0
             );
            return fullTime;
        }
        public static void MakeAnAppointment(string email)
            => _ = DataBase.Add.Appointment(new Appointment{ procedureTitle = ProcedureTitle, pEmail = email, stuffId = CurrentStuffId, dayDate = GetFullTime()});
        
        public static void MarkAsSeen(int id, string procedureTitle, string procedureTime, string pEmail)
            => _ = DataBase.NonQueryRequestExecuteAsync($"update Appointments set HasSeen = 1 where stuffId = {id} and procedureTitle ='{procedureTitle}' and dayDate ='{procedureTime}' and pEmail = '{pEmail}'");

        public static Appointment GetAppointment(int id, string procedureTitle, string procedureTime, string pEmail)
            => _ = DataBase.ConvertToList<Appointment>(DataBase.SelectRequestExecute($"select * from Appointments where stuffId = {id} and procedureTitle = '{procedureTitle}' and dayDate = '{procedureTime}' and pEmail ='{pEmail}' "))[0];
        private static List<string> ReservedTimes()
        {
            List<Appointment> appointments = DataBase.ConvertToList<Appointment> (DataBase.SelectRequestExecute($"select * from Appointments where stuffId = {CurrentStuffId}"));
            List<string> reservedTimes = new List<string>();

            foreach (Appointment app in appointments)
                if (app.dayDate.ToString("d") == dayOfProcedure)
                    reservedTimes.Add(app.dayDate.ToString("HH:mm"));

            return reservedTimes;
        }
        public static List<DoctorReport> GetReport(int staffId, string procedureTitle, string procedureTime, string pEmail)
            => DataBase.ConvertToList<DoctorReport>(DataBase.SelectRequestExecute($"select * from DoctorReports where stuffId ={staffId} and procedureTitle = '{procedureTitle}' and procedureTime = '{procedureTime}' and pEmail ='{pEmail}'"));
     
        public static void ShowFullInformation(int staffId, string procedureTitle, string procedureTime, string pEmail)
        {
            AppointmentReportInformation form = new AppointmentReportInformation();
            form.LoadAppointment(GetAppointment(staffId, procedureTitle, procedureTime, pEmail));

            List<DoctorReport> reports = GetReport(staffId, procedureTitle, procedureTime, pEmail);
            if(reports.Count == 1)   
                form.LoadReport(reports[0]);
            if(reports.Count == 0)
                form.LoadReport(null);
            form.ShowDialog();
        }
    }
}
