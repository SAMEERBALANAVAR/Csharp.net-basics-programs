using System;
using System.Collections.Generic;
using System.Text;
//program on Multiplication by sameer on 3/feb/2021
namespace Basic_C_SHARP
{
    //class name Multiplication
    class Multiplication
    {
        static void Main(string[] args)
        {
            //datatype is int type and  variables are a,b,c 
            int a, b, c;
            //taking input from user a
            Console.WriteLine("Enter value for a");
            //store value in a
            a = int.Parse(Console.ReadLine());
            //taking input from user a
            Console.WriteLine("Enter value for b");
            //store value in b
            b = int.Parse(Console.ReadLine());
            //multiplication operation done below
            c = a * b;
            //printing ouput using 3rd var ie c
            Console.Write("Multiplication of a and b is = " + c);



        }
    }
}
