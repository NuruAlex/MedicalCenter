using System;

namespace MedicalCenter.Accountants
{
    internal class AccountantReport
    {
        public int id { get; set; }
        public int stuffId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public double moneySum { get; set; }
        public DateTime submitionTime { get; set; }
        public int salesAmount { get; set; }

        public string[] ToAccountantArrayString() => new string[]
        {
            startTime.ToString("d"), 
            endTime.ToString("d"),
            moneySum.ToString(),
            submitionTime.ToString("d") 
        };
    }
}
