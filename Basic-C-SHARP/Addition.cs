using System;
using System.Collections.Generic;
using System.Text;
//program for adding two number and stored in 3rd var and display 3rd value
//done by sameer on 3/feb/2021

namespace Basic_C_SHARP
{
    //class name Addtion
    class Addition
    {
        static void Main(string[] args)
        {
            //Data type is int with variable are a,b,c
            int a, b, c;
            //taking input from user for a var
            Console.WriteLine("Enter value for a");
            //store that value inside a
            a = int.Parse(Console.ReadLine());
             //taking input from user for b var
            Console.WriteLine("Enter value for b");
             //store that value inside b
            b = int.Parse(Console.ReadLine());
            //addition of a and b and are stored inside c var
            c = a + b;
            
           //output of the program
            Console.Write("Addition of a and b is = " + c);



        }
    }
}
