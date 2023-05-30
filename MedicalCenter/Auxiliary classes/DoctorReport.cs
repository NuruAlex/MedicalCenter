using System;
using System.Text;

namespace MedicalCenter
{
    public class DoctorReport
    {
        public int id { get; set; }
        public int stuffId { get; set; }
        public string pEmail { get; set; }
        public string procedureTitle { get; set; }

        public DateTime procedureTime { get; set; }

        public DateTime submitionTime { get; set; }

        public string complaints { get; set; }

        public string inspection { get; set; }

        public string diagnosis { get; set; }
        public string drugs { get; set; }
        public string recomendations { get; set; }
        public string conclusion { get; set; }

       public string[] ToPatientArrayString() => new string[] { stuffId.ToString(), procedureTitle, procedureTime.ToString("G"), recomendations };
       public string ToPrintString() =>new StringBuilder()
            .Append($"\t\t\t---- Данные об отчете ----\n\n")
            .Append($"\t\t\tID отчета: {id}\n\n")
            .Append($"\t\t\tID врача: {stuffId}\n\n")
            .Append($"\t\t\tПочта пациента: {pEmail}\n\n")
            .Append($"\t\t\tНазвание процедуры: {procedureTitle}\n\n")
            .Append($"\t\t\tДата и время процедуры: {procedureTime.ToString("G")}\n\n")
            .Append($"\t\t\tДата и время отправки отчета: {submitionTime.ToString("G")}\n\n")
            .Append($"\t\t\tЖалобы: {complaints}\n\n")
            .Append($"\t\t\tОбщий осмотр: {inspection}\n\n")
            .Append($"\t\t\tДиагноз: {diagnosis}\n\n")
            .Append($"\t\t\tЛекарственные назвачения: {drugs}\n\n")
            .Append($"\t\t\tРекомендации: {recomendations} \n\n")
            .Append($"\t\t\tЗаключение: {conclusion}\n\n")
            .ToString();
    }
}
