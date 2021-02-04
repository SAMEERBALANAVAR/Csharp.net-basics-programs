using System;
using System.Collections.Generic;
using System.Text;
//program on Condtion statements by sameer on 4/feb/2021
namespace ConsoleApp1
{
    //class name IfStatements
    class IfStatements
    {
        static void Main(string[] args)
        {
            //concidering total marks as 100
            int total = 100;
            //taking values from users
            Console.WriteLine("enter the marks");
            //storing values in total
            total = int.Parse(Console.ReadLine());
            if (total <= 35)
            {
                Console.WriteLine("Sorry! you earned bronze medal");
            }
            else if (total <= 75)
            {
                Console.WriteLine("Hurry!!! you have earned silver medal");
            }
            else
            {
                Console.WriteLine("Congratulations you have earned gold medal");
            }
        }
    }
}
