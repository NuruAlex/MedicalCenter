using System;
using System.Data;
using System.Reflection;
using MedicalCenter.Staffs;
using System.Data.SqlClient;
using MedicalCenter.Accountants;
using System.Collections.Generic;
using MedicalCenter.HeadPhysicians;

namespace MedicalCenter
{
    static class DataBase
    {
        private static SqlConnection _connection;

        public static void InitConnection() 
        {
            _connection = new SqlConnection($"Server = 192.168.1.11, 32150;Database = MedicalCenter;User Id=test;Password = 123;Trusted_Connection=True;");
        }
        public static void OpenConnection()
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " connection opening");
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " connection closing");
            }
        }

        public static DataTable SelectRequestExecute(string request)
        {
            OpenConnection();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(request, _connection);
            try
            {
                using (SqlDataReader reader =  command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message+" select request");
            }
            

            CloseConnection();
            return table;
        }
        public static int NonQueryRequestExecuteAsync(string request)
        {
            OpenConnection();
            int affectedRowsAmount = 0;

            SqlCommand command = new SqlCommand(request, _connection);
            
            try
            {
               affectedRowsAmount = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " execute non query");
            }
            CloseConnection();
            return affectedRowsAmount;
        }

        public static List<T> ConvertToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static List<string>ConvertToList(DataTable dt,string propertyName)
        {
            List<string>result = new List<string>();

            foreach (DataRow row in dt.Rows)
                result.Add(Convert.ToString(row[propertyName]));
            return result;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    try
                    {
                        if (pro.Name == column.ColumnName)
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        else
                            continue;
                    }catch
                    {
                    }
                }
            }
            return obj;
        }

        public static class Update
        {
            public static  int LastPatientEntered(string email)
            {
                if (Get.LastPatientEntered() != null)
                   return  NonQueryRequestExecuteAsync($"update LastPatientEntered set pEmail ='{email}'");
                return  Add.LastPatientEntered(email);
            }
            public static int LastStaffEntered(int id)
            {
                if(Get.LastStaffEntered() != -1)
                  return  NonQueryRequestExecuteAsync($"update LastStaffEntered set id={id}");
                return Add.LastStaffEntered(id);
            }
            public static int Day(string staffId, string dayType, string date) => NonQueryRequestExecuteAsync($"update WorkSchedule set dayType ={dayType} where stuffId ={staffId} and dayDate='{date}'");
            public static  int Drug(Drug d) =>  NonQueryRequestExecuteAsync($"update Drugs set dDescription = '{d.dDescription}', dProvider = '{d.dProvider}', remains = {d.remains}, cost = {d.cost} where title ='{d.title}'");
        }
        public static class Add
        {
              public static int LastStaffEntered(int id) =>  NonQueryRequestExecuteAsync($"insert into LastStaffEntered values ({id})");
              public static int LastPatientEntered(string email) =>  NonQueryRequestExecuteAsync($"insert into LastPatientEntered values ('{email}')");
              public static int RestDay(string stuffId, string dayDate) =>  NonQueryRequestExecuteAsync($"insert into WorkSchedule (stuffId,dayType,dayDate) values({stuffId},{0},'{dayDate}')");
              public static int WorkDay(string stuffId, string dayDate) =>  NonQueryRequestExecuteAsync($"insert into WorkSchedule (stuffId,dayType,dayDate,startTime,endTime) values({stuffId},{1},'{dayDate}','9:00:00','21:00:00')");
              public static int Appointment(Appointment app) =>  NonQueryRequestExecuteAsync($"insert into Appointments values ('{app.pEmail}','{app.stuffId}','{app.dayDate}','{app.procedureTitle}',0)");
              public static int NewDrug(Drug drug) =>  NonQueryRequestExecuteAsync($"insert into Drugs values ('{drug.title}','{drug.dDescription}','{drug.dProvider}',{drug.remains},{drug.cost})");
              public static int AccountantReport(AccountantReport report) =>  NonQueryRequestExecuteAsync($"insert into AccountantReports values ({report.stuffId},'{report.startTime}','{report.endTime}',{report.moneySum},{report.salesAmount},'{report.submitionTime}')");
              public static int Report(DoctorReport rep) =>  NonQueryRequestExecuteAsync($"insert into DoctorReports values ({rep.stuffId},'{rep.pEmail}','{rep.procedureTitle}','{rep.procedureTime}','{rep.submitionTime}','{rep.complaints}','{rep.inspection}','{rep.diagnosis}','{rep.drugs}','{rep.recomendations}','{rep.conclusion}')");
        }
        public static class Get
        {
            public static string LastPatientEntered()
            {
                List<string> lastPatientEntered =  ConvertToList(SelectRequestExecute("select * from LastPatientEntered"), "pEmail");
               
                if (lastPatientEntered.Count > 0)
                    return lastPatientEntered[0];
                return null;
            }
            public static int LastStaffEntered() 
            {
                List<string> lasStaffEntered =  ConvertToList(SelectRequestExecute("select * from LastStaffEntered"), "id");
                if (lasStaffEntered.Count > 0)
                    return Convert.ToInt32(lasStaffEntered[0]);
                return -1;
            }
            public static List<Drug> Drugs() =>  ConvertToList<Drug>(SelectRequestExecute("select * from Drugs"));
            public static List<string> Procedures() => ConvertToList(SelectRequestExecute("select * from Threatments"),"title");
            public static List<Sale> Sales(string startTime, string endTime) => ConvertToList < Sale > (SelectRequestExecute($"select * from Sales where dayDate >= '{startTime}' and dayDate<'{endTime}'"));
            public static List<AccountantReport> AccountantReports(int id, string startDate, string endDate) => ConvertToList<AccountantReport>(SelectRequestExecute($"select * from AccountantReports where stuffId = {id} and startTime >= '{startDate}' and endTime <= '{endDate}'"));
            public static List<DoctorReport> PatientReports(string email) => ConvertToList<DoctorReport> (SelectRequestExecute($"select * from DoctorReports where pEmail ='{email}'"));
            public static List<DoctorReport>PatientReports(string email,string startDate,string endDate) => ConvertToList<DoctorReport>(SelectRequestExecute($"select * from DoctorReports where pEmail ='{email}'  and submitionTime >= '{startDate}' and submitionTime <= '{endDate}' "));
            public static List<Appointment> PatientAppointments(string email,string startDate,string endDate,bool hasSeen) => ConvertToList<Appointment> (SelectRequestExecute($"select * from Appointments where pEmail ='{email}' and HasSeen = '{hasSeen}' and dayDate >= '{startDate}' and dayDate <= '{endDate}' "));
            public static List<Appointment> PatientAppointments(string email,string startDate,string endDate) => ConvertToList<Appointment> (SelectRequestExecute($"select * from Appointments where pEmail ='{email}' and dayDate >= '{startDate}' and dayDate <= '{endDate}' "));
            public static List<Appointment> DoctorAppointments(string stuffId) => ConvertToList<Appointment> (SelectRequestExecute($"select * from Appointments where stuffId ={stuffId} and dayDate = '{DateTime.Today.ToString("d")}' and HasSeen = 0"));
            public static List<Appointment> DoctorAppointments(string stuffId,string startDate,string endDate,bool hasSeen) => ConvertToList<Appointment>(SelectRequestExecute($"select * from Appointments where stuffId ={stuffId} and HasSeen = '{hasSeen}' and dayDate >= '{startDate}' and dayDate <= '{endDate}' "));
            public static List<Doctor> Doctors() => ConvertToList<Doctor> (SelectRequestExecute($"select * from Stuffs where sState ='Врач'"));
            public static List<string> Posts() => ConvertToList( SelectRequestExecute($"select dPost from dPosts"),"dPost");
            public static List<string> States() => ConvertToList( SelectRequestExecute($"select sStatus from sState"), "sStatus");
            public static List<string> PatientMachineNames(string email) => ConvertToList(SelectRequestExecute($"select * from PatientDevices where pEmail ='{email}'"), "MachineName");
            public static List<string> StaffMachineNames(int staffId) => ConvertToList(SelectRequestExecute($"select * from StaffDevices where stuffId ='{staffId}'"), "MachineName");
        }
    }
}