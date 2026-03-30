using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    public class Validator
    {

        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = $"{name} is a required field.{LineEnd}";
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {

            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = $"{name} must be a valid decimal value.{LineEnd}";
            }
            return msg;

        }

        public static string IsInt32(string value, string name)
        {

            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = $"{name} must be a valid integer value. {LineEnd}";
            }
            return msg;

        }

        public static string IsWithinRange(string value, string name, decimal min, decimal max)
        {

            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = $"{name} must be between {min} and {max}.{LineEnd}";
                }
            }
            return msg;

        }

        public static string IsValidEmail(string value, string name)
        {
            string msg = "";
            if (!value.Contains('@') || !value.Contains ('.'))
            {
                msg = $"{name} must be a valid email address.{LineEnd}";
            }
            return msg;
        }

        public static string IsValidPhone(string value, string name)
        {
            string msg = "";
            if (value.Length != 10)
            {
                msg = $"{name} must be a valid phone number.{LineEnd}";
            }
            return msg;
        }

    }
}
