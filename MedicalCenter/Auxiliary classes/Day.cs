using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.HeadPhysicians
{
    internal class Day
    {
        public int id { get; set; }
        public int stuffId { get; set; }
        public bool dayType { get; set; }
        public DateTime dayDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
