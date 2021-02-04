using System;
using System.Collections.Generic;
using System.Text;
//program on Enumaration by sameer on 4/feb/2021
namespace ConsoleApp1
{
    //class name Enumaration
    class Enumaration
    {
        //Enum name Categories
        enum Categories
        {
            //Different categories
            Electronics = 1,
            Food = 2,
            Automotive = 3,
            Arts ,
            BeautyCare = 4,
            Fashion = 5,
            WomanFashion = 6
        }
        public static void Main()
        {
            //printing Electonics category
            Console.WriteLine(Categories.Electronics);
            //print value of arts 
            int stream = (int)Categories.Arts;
            Console.WriteLine(stream);
            //printing default value of category 11
            var wd = (Categories)11;
            Console.WriteLine(wd);

        }
    }

   
}
