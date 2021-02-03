using System;
using System.Collections.Generic;
using System.Text;
//program on Increament operation by sameer on 3/feb/2021
namespace Basic_C_SHARP
{
    //class name Increament
    class Increament
    {
        static void Main(string[] args)
        {
            //declaring datatype as int with var a
            int a;
            //taking input from user for var a
            Console.WriteLine("Enter value for a \n");
            //storing value into var a
            a = int.Parse(Console.ReadLine());
            //postincreament operation
            a++;
            Console.Write("Postincreament of a is = " + a);
            //preincreament operation
            --a;
            Console.Write("Pretincreament of a is = " + a);

        }
    }
}
