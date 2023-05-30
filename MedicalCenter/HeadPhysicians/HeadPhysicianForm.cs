using MedicalCenter.Staffs;
using MedicalCenter.Verification;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MedicalCenter.HeadPhysicians
{
    public partial class HeadPhysicianForm : Form
    {
        public HeadPhysicianForm() => InitializeComponent();
        List<Doctor> doctors = new List<Doctor>();

       
       

        private void HeadPhysicianForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void HeadPhysicianForm_Load(object sender, EventArgs e)
        {
            Theme.Set.FormStyle(this);
            MessageBox.Show(Color.FromArgb(240,240,240).GetBrightness().ToString());
            doctors = DataBase.Get.Doctors();
            UIHelper.Show.StaffData(aEmail, aEmail, aPassword, aSecondPassword);
        }
        
        
        //Расписание

        private void LoadWorkSchedule()
        {
            if(Validator.ValidateDates(startDate.Value, endDate.Value))
                return;
           
            ClearTimeTable();
            string start = startDate.Value.ToString("yyyy-MM-dd");
            string end = endDate.Value.ToString("yyyy-MM-dd");

            List<Day> workSchedule = WorkSchedule.GetWorkSchedule(start, end);

            if (workSchedule.Count == 0)
            {
                MessageBox.Show("Расписания нет на эти даты");
                return;
            }
          
            foreach (Day day in workSchedule)
            {
                int index = timeTable.Rows.Add();
                timeTable.Rows[index].Cells[0].Value = day.stuffId;
                timeTable.Rows[index].Cells[1].Value = day.dayType;
                timeTable.Rows[index].Cells[2].Value = day.dayDate.ToString("yyyy-MM-dd");
            }
        }

        private void GetWorkSchedule_Click(object sender, EventArgs e) => LoadWorkSchedule();
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateDates(startDate.Value, startDate.Value))
                return;
            DateTime start = startDate.Value, end = startDate.Value;

            while (start < end)
            {
                foreach (Doctor doctor in doctors)
                    WorkSchedule.GenerateDay(doctor.id.ToString(), start.ToString("d"));
                start = start.AddDays(1);
            }
        }
        private void InputChanges_Click(object sender, EventArgs e)
        {
            if (timeTable.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Вы не создали расписание");
                return;
            }

            foreach (DataGridViewRow row in timeTable.Rows)
               WorkSchedule.AddDay(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
            ClearTimeTable();
        } 
        private void CreateTimeTable_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateDates(startDate.Value, startDate.Value))
                return;
            ClearTimeTable();

            
            DateTime start = startDate.Value;
            DateTime end = startDate.Value;
            List<Doctor> doctors = DataBase.Get.Doctors();

            while (start < end)
            {
                foreach (Doctor doctor in doctors)
                {
                    int index = timeTable.Rows.Add();
                    timeTable.Rows[index].Cells[0].Value = doctor.id;
                    timeTable.Rows[index].Cells[1].Value = "False";
                    timeTable.Rows[index].Cells[2].Value = start.ToString("yyyy-MM-dd");
                }
                start = start.AddDays(1);
            }
        }
        private void ClearTimeTable()
        {
            if(timeTable.Columns.Count != 0)
                timeTable.Rows.Clear();
        }
        private void ClearButton_Click(object sender, EventArgs e) => ClearTimeTable();
      
        //Препараты
       
        private void GetDrugsInfo_Click(object sender, EventArgs e)
        {
            ClearDrugTable();
            List<Drug> drugs = DataBase.Get.Drugs();
            
            foreach(Drug drug in drugs)
            {
                int index = DrugTable.Rows.Add();
                DrugTable.Rows[index].Cells[0].Value = drug.title;
                DrugTable.Rows[index].Cells[1].Value = drug.dDescription;
                DrugTable.Rows[index].Cells[2].Value = drug.dProvider;
                DrugTable.Rows[index].Cells[3].Value = drug.remains;
                DrugTable.Rows[index].Cells[4].Value = drug.cost;
            }
        }
      
        private void AddDrug_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DrugTable.SelectedRows)
            {
               _ = DataBase.Add.NewDrug(new Drug
               {
                    title = row.Cells[0].Value.ToString(),
                    dDescription = row.Cells[1].Value.ToString(),
                    dProvider = row.Cells[2].Value.ToString(),
                    remains = Convert.ToInt32(row.Cells[3].Value),
                    cost = Convert.ToDouble(row.Cells[4].Value)
               });
            }
        }
        private void ClearDrugTable()
        {
            if (DrugTable.Rows.Count != 0)
                DrugTable.Rows.Clear();
        }
        private void ClearGrugTable_Click(object sender, EventArgs e) => ClearDrugTable();
      
        private void UpdateDrug_Click(object sender, EventArgs e)
        {
            if(DrugTable.SelectedRows.Count==0)
            {
                MessageBox.Show("Выделите строки");
                return;
            }
            foreach (DataGridViewRow row in DrugTable.SelectedRows)
            {
                _ = DataBase.Update.Drug(new Drug
                {
                    title = row.Cells[0].Value.ToString(),
                    dDescription = row.Cells[1].Value.ToString(),
                    dProvider = row.Cells[2].Value.ToString(),
                    remains = Convert.ToInt32(row.Cells[3].Value),
                    cost = Convert.ToDouble(row.Cells[4].Value)
                });
            }
        }

        //Мой аккаутн
        



        private void ExitButton_Click(object sender, EventArgs e) => VerificationManager.ExitFrom(this);


    }
}
