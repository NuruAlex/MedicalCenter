using System;
using System.Linq;

namespace MedicalCenter
{
    internal static class Validator
    {
        public static bool IsNulls(params object[] values) => values.Contains(null);
        public static bool IsEmptyStrings(params string[] values)  => values.Contains("");

        public static bool IsNumbers(params string[] values)
        {
            double number;

            foreach (string value in values)
                if (double.TryParse(value, out number))
                    return true;
            return false;
        }
        public delegate bool Message(DateTime start, DateTime end);

        public static Message ValidateDates = (start, end) =>
        {
            if (start >= end) System.Windows.MessageBox.Show("Выберите корректные даты");
            return start >= end;
        };
    }
}
