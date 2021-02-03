using System;
using System.Collections.Generic;
using System.Text;
/** 
program on datatype conversion
coder sameer
date 3/feb/2021

 * */
namespace ConsoleApp1
{
    //class name Datatypeconveri
    class Datatypeconversion
    {
        static void Main(string[] args)
        {
            //converting string to double
            Console.WriteLine("Enter decimal number:");
            //number to boolean
            double num = Convert.ToDouble(Console.ReadLine());
            //taking input from user 
            Console.WriteLine("Entered Number is: " + num);
            //taking input from user a
            Console.WriteLine("Enter String:");
            //converting string
            string stringvalue = Console.ReadLine();
            //printing string values
            Console.WriteLine("Entered String is: " + stringvalue);

        }
    }
}
