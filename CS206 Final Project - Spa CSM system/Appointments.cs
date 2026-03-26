using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    public class Appointments
    {
        public string Professional { get; set; } = " ";
        public string Service { get; set; } = " ";
        public DateTime DateTime { get; set; }

        public Appointments() { }

        public Appointments(string professional, string service, DateTime datetime)
        {
            Professional = professional;
            Service = service;
            DateTime = datetime;
        }

    }
}
