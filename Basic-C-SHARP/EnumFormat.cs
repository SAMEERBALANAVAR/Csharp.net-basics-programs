using System;
using System.Collections.Generic;
using System.Text;
//program on EnumFormats by sameer on 4/feb/2021
namespace ConsoleApp1
{
    //class name EnumFormat
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
            //Different Enum Formats
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
            //printing the EnumFormatsValue
            Console.WriteLine("{0} = {1}", format, value);
        }
    }
}
