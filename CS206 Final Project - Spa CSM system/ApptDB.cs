using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    public static class ApptDB
    {

        private const string dir = @"C:\C#\Files";
        private const string path = dir + "Appointments.txt";

        public static void SaveAppointments(List<Appointments> appointments)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Appointments appointment in appointments)
            {
                textOut.Write(appointment.Professional + "|");
                textOut.Write(appointment.Service + "!");
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
                    Professional = columns[0],
                    Service = columns[1],
                    
                };

                string datetime = appointment.DateTime.ToString();

                datetime = columns[2];

                appointments.Add(appointment);
            }

            textIn.Close();

            return appointments;
        }

    }
}
