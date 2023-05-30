using MedicalCenter.Staffs;
using MedicalCenter.Verification;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicalCenter.Accountants
{
    public partial class AccountantForm : Form
    {
        List<Sale> sales = new List<Sale>();
        public AccountantForm() => InitializeComponent();
        private void AccountantForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void AccountantForm_Load(object sender, EventArgs e)
        {
            Theme.Set.FormStyle(this);
            UIHelper.Show.StaffData(email, name, password, secondPassword);
        }
        //Оформить отчет
        private double CountMoneySum()
        {
            double sum = 0;
            foreach (Sale s in sales)
                sum += s.moneySum;
            return sum;
        }
        private void SendReport_Click(object sender, EventArgs e)
        {
            if (sales.Count == 0)
            {
                MessageBox.Show("За этот период нет покупок, выберите другой период");
                return;
            }
            _ = DataBase.Add.AccountantReport(new AccountantReport
            {
                stuffId = StaffManager.CurrentStaff.id,
                startTime = startTime.Value,
                endTime = endTime.Value,
                moneySum = CountMoneySum(),
                submitionTime = DateTime.Now,
                salesAmount = sales.Count
            });
            MessageBox.Show("Отчет отправлен!");
            ClearAll();
            SendReport.Visible = false;
        }
        private void GetData_Click(object sender, EventArgs e)
        {
            if (startTime.Value >= endTime.Value)
            {
                MessageBox.Show("Выберите даты корректно");
                return;
            }
            sales.Clear();
            sales = DataBase.Get.Sales(startTime.Value.ToString("d"), endTime.Value.ToString("d"));

            start.Text = "Начальная дата: " + startTime.Value.ToString("d");
            end.Text = "Конечная дата: " + endTime.Value.ToString("d");
            sum.Text = "Сумма: " + CountMoneySum().ToString();
            amount.Text = "Количество покупок: " + sales.Count.ToString();
            SendReport.Visible = true;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (sales.Count == 0)
            {
                MessageBox.Show("За этот период нет покупок, нечего и чистить:)");
                return;
            }
            ClearAll();
        }
        private void ClearAll()
        {
            UIHelper.Clear.Labels(start, end, sum, amount);
            UIHelper.Clear.DataGridView(SalesTable);
            sales.Clear();
        }

        // Мои отчеты
        private void LoadReports()
        {
            if (startD.Value >= endD.Value)
            {
                MessageBox.Show("Выберите даты корректно");
                return;
            }
            UIHelper.Show.AccountantReports(AccountantReports, StaffManager.CurrentStaff.id, startD.Value.ToString("d"), endD.Value.ToString("d"));
        }

        private void GetReports_Click(object sender, EventArgs e) => LoadReports();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => LoadReports();

        private void GetFullInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь пока нет реализации");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            AccountantReports.Items.Clear();
        }



        //Мой аккаунт
        private void ExitButton_Click(object sender, EventArgs e) => VerificationManager.ExitFrom(this);

    }
}
