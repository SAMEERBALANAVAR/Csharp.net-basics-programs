using System;
using System.Collections.Generic;
using System.Text;
//program on Decreament operator by sameer on 3/feb/2021
namespace Basic_C_SHARP
{
    //class name Decreament
    class Decreament
    {
        static void Main(string[] args)
        {
            //datatype int value 
            //x is var
            int x;
            //taking input from users
            Console.WriteLine("Enter value for x \n");
            //storing value into var x
            x = int.Parse(Console.ReadLine());
            //postincreament procedure
            x++;
            Console.Write("Postincreament of x is = " + x);
              //pretincreament procedure
            --x;
            Console.Write("Pretincreament of x is = " + x);

        }
    }
}
