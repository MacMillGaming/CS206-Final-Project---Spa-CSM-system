using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    public static class ApptDB
    {

        private static readonly string baseDir = AppDomain.CurrentDomain.BaseDirectory;

        private static readonly string dir = Path.Combine(baseDir, "Files");

        private static readonly string path = Path.Combine(dir, "Appointments.txt");

        public static void SaveAppointments(List<Appointments> appointments)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Appointments appointment in appointments)
            {
                textOut.Write(appointment.CustomerName + "|");
                textOut.Write(appointment.Professional + "|");
                textOut.Write(appointment.Service + "|");
                textOut.WriteLine(appointment.DateTime);
            }

            textOut.Close();
        }

        public static List<Appointments> GetAppointments()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn = 
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Appointments> appointments = new List<Appointments>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                
                Appointments appointment = new Appointments
                {

                    CustomerName = columns[0],
                    Professional = columns[1],
                    Service = columns[2],
                    DateTime = DateTime.Parse(columns[3])
                    
                };
                               

                appointments.Add(appointment);
            }

            textIn.Close();

            return appointments;
        }

    }
}
