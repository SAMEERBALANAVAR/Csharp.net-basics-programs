using System;
using System.Collections.Generic;
using System.Text;
//program on Substraction by sameer on 3/feb/2021
namespace Basic_C_SHARP
{
    //class name Substraction
    class Substraction
    {
        static void Main(string[] args)
        {
            //datatype is int type and var are a,b,c
            int a, b, c;
            //taking input from user a
            Console.WriteLine("Enter value for a");
            //storing values on to a
            a = int.Parse(Console.ReadLine());
            ////taking input from user b
            Console.WriteLine("Enter value for b");
            //storing values on to b
            b = int.Parse(Console.ReadLine());
            //Substraction operation done below
            c = a - b;
            //printing values using 3rd var ie c
            Console.Write("substraction of a and b is = " + c);



        }
    }
}
