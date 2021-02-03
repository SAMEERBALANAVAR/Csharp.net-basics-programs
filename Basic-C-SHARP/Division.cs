using System;
using System.Collections.Generic;
using System.Text;
//program on Divion operation using 2 var ie a and b and print resulted value in 3rd var ie c
namespace Basic_C_SHARP
{
    //class name Division
    class Division
    {
        static void Main(string[] args)
        {
            //intergr datatype with a,b,c variables
            int a, b, c;
            //taking input from user for var a
            Console.WriteLine("Enter value for a");
            //storing input in a
            a = int.Parse(Console.ReadLine());
           //taking input from user for var a
            Console.WriteLine("Enter value for b");
            //storing input in b
            b = int.Parse(Console.ReadLine());
            //Division operation done below
            c = a / b;
            //print values using 3rd var that is c
            Console.Write("Division of a and b is = " + c);



        }
    }
}
