using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace MedicalCenter.Doctors
{
    public partial class AppointmentReportInformation : Form
    {
        private Appointment Appointment { get; set; }
        private DoctorReport Report { get; set; }


        private string TextToPrint = "";
        

        private void распечататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextToPrint = "";
            TextToPrint += Appointment.ToPrintString();

            if (Report != null)
                TextToPrint += Report.ToPrintString();

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;


            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void PrintPageHandler(object sender,PrintPageEventArgs e) => e.Graphics.DrawString(TextToPrint, new Font("Arial", 12),Brushes.Black,0,0);


        public AppointmentReportInformation() => InitializeComponent();

        public void LoadAppointment(Appointment appointment)
        {
            if (appointment == null)
                return;
            Appointment = appointment;
            AppointmentInfo.Text = Appointment.ToPrintString();
        }
        public void LoadReport(DoctorReport report)
        {
            if (report == null)
            {
                ReposrtInfo.Visible = false;
                return;
            }
            Report = report;

            ReportInfo.Text = Report.ToPrintString();
           
        }

        private void AppointmentReportInformation_FormClosed(object sender, FormClosedEventArgs e) => Hide();

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            SaveFile.Filter = "txt files (*.txt)|*.txt";
            SaveFile.FilterIndex = 1;
            SaveFile.RestoreDirectory = true;

            if (SaveFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
                
            using (StreamWriter writer = new StreamWriter(SaveFile.FileName, false, Encoding.UTF8))
            {
                writer.WriteLineAsync(Appointment.ToPrintString());

                if (Report == null)
                {
                    writer.Close();
                    MessageBox.Show("Данные были записаны и сохранены");
                    return;
                }
                writer.WriteLineAsync(Report.ToPrintString());
            }
            MessageBox.Show("Данные были записаны и сохранены");
        }

        private void AppointmentReportInformation_Load(object sender, EventArgs e)
        {
            Theme.Set.FormStyle(this);
        }
    }
}
