using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EnumFormat
    {
        enum Importance
        {
            Low,
            Medium,
            Critical
        }

        static void Main()
        {
            M("G");
            M("g");
            M("X");
            M("x");
            M("F");
            M("f");
            M("D");
            M("d");
        }

        static void M(string format)
        {
            // Use Enum.Format with the specified format string.
            string value = Enum.Format(typeof(Importance), Importance.Critical, format);
            Console.WriteLine("{0} = {1}", format, value);
        }
    }
}
