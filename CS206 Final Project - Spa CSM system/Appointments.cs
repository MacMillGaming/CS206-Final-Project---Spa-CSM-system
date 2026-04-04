using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CS206_Final_Project___Spa_CSM_system
{
    public class Appointments
    {
        public string Professional { get; set; } = " ";
        public string Service { get; set; } = " ";
        public string DateTime { get; set; }

        public string CustomerName { get; set; }

        public Appointments() { }

        public Appointments(string professional, string service, string datetime)
        {
            Professional = professional;
            Service = service;
            DateTime = datetime;
        }

        public string GetDisplayText() => $"{Professional} {Service}, {DateTime}";

    }
}
