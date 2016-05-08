using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Provide a format string (eg: yyyy_MM_dd-hh_mm_ss). Common format specifiers:");
                Console.WriteLine("\ty\tYear. Repeat for multiple digits.");
                Console.WriteLine("\tM\tMonth. Repeat for multiple digits.");
                Console.WriteLine("\td\tDay of month, 1-31; Repeat for multiple digits.");
                Console.WriteLine("\tH\tHour in 24-hour format. Repeat for multiple digits.");
                Console.WriteLine("\tm\tMinute. Repeat for multiple digits.");
                Console.WriteLine("\ts\tSecond. Repeat for multiple digits.");
                Console.WriteLine("More information on formats available here: https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx");
            }
            else
            {
                //Console.WriteLine(DateTime.Now.ToString("yyyy_MM_dd-hh_mm_ss"));
                Console.WriteLine(DateTime.Now.ToString(args[0]));
            }
        }
    }
}
