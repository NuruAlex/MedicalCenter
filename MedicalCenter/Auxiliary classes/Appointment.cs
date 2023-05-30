using System;
using System.Text;

namespace MedicalCenter
{
    public class Appointment
    {
        public int id { get; set; }
        public string procedureTitle { get; set; }
        public string pEmail { get; set; }
        public int stuffId { get; set; }
        public DateTime dayDate { get; set; }
        public bool HasSeen { get; set; }


        public string[] ToPatientArrayString() => new string[] { stuffId.ToString(), procedureTitle, dayDate.ToString("G") };
        public string[] ToDoctorArrayString() => new string[] { pEmail, procedureTitle, dayDate.ToString("G") };

        public string ToPrintString()
        {
            StringBuilder b = new StringBuilder();
            b.Append($"\t\t\t---- Данные о записи ----\n\n")
               .Append($"\t\t\tID записи: {id}\n\n")
               .Append($"\t\t\tНазвание процедуры: {procedureTitle} \n\n")
               .Append($"\t\t\tПочта пациента: {pEmail}\n\n")
               .Append($"\t\t\tID врача: {stuffId}\n\n")
               .Append($"\t\t\tДата и время процедуры: {dayDate.ToString("G")}\n\n");

            if (HasSeen)
                b.Append("\t\t\tПросмотрено\n\n");
            if (!HasSeen)
                b.Append("\t\t\tОтчет пока не составлен \n\n\n");
            return b.ToString();
        }
    }
}
