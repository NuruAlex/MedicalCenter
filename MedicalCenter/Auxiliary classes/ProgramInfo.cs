using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter
{
    internal class AbountProgram
    {
        public string AuthorEmail { get; set; }
        public string AuthorName { get; set; }
        public string AuthorPhone { get; set; }
        public string LatestVersion { get; set; }

        public override string ToString() => new StringBuilder()
            .Append($"Почта автора: {AuthorEmail}\n\n")
            .Append($"Имя автора: {AuthorName}\n\n")
            .Append($"Номер телефона автора: {AuthorPhone}\n\n")
            .Append($"Последняя версия: {LatestVersion}\n\n")
            .ToString();

    }
}
