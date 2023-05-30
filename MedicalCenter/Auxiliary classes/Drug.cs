using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.HeadPhysicians
{
    internal class Drug
    {
        public string title { get; set; }
        public string dDescription { get; set; }
        public string dProvider { get; set; }
        public int remains { get; set; }
        public double cost { get; set; }
    }
}
