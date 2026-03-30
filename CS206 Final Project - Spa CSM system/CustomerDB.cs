using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    public static class CustomerDB
    {
        private static readonly string baseDir = AppDomain.CurrentDomain.BaseDirectory;

        private static readonly string dir = Path.Combine(baseDir, "Files");

        private static readonly string path = Path.Combine(dir, "Customers.txt");

        public static void SaveCustomers(List<Customers> customers)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (Customers customer in customers)
            {
                textOut.Write(customer.FirstName + "|");
                textOut.Write(customer.LastName + "|");
                textOut.Write(customer.Email + "|");
                textOut.WriteLine(customer.Phone);
            }

            // write the end of the document
            textOut.Close();
        }

        public static List<Customers> GetCustomers()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<Customers> customers = new List<Customers>();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                Customers customer = new Customers
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Email = columns[2],
                    Phone = long.Parse(columns[3])

                };

                

                customers.Add(customer);
            }

            textIn.Close();

            return customers;
        }
    }
}
