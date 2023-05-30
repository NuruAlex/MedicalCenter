using System;

namespace MedicalCenter.Accountants
{
    internal class Sale
    {
        public int id { get; set; }
        public string drugTitle { get; set; }
        public DateTime dayDate { get; set; }
        public int amount { get; set; }
        public double moneySum { get; set; }
    }
}
