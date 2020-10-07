using System;
using System.Text.RegularExpressions;

namespace pr_03_01_01
{
    class Program
    {
        static bool IsPhone(string s)
        {
            string pattern = @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{4}$";
            return Regex.IsMatch(s, pattern);
        }

        static bool IsZip(string s)
        {
            string pattern = @"^\d{5}(\-\d{4})?$";
            return Regex.IsMatch(s, pattern);
        }

        static void Main(string[] args)
        {
            string[] testStrings = { "(555)555-1212", "(555) 555-1212", "555-555-1212", "5555551212", "01111", "01111-1111", "47", "111-11-1111" };
            foreach (string s in testStrings)
            {
                if (IsPhone(s))
                    Console.WriteLine("{0} is a phone", s);
                else if (IsZip(s))
                    Console.WriteLine("{0} is a zip", s);
                else
                    Console.WriteLine("{0} is unknown", s);
            }
        }
    }
}