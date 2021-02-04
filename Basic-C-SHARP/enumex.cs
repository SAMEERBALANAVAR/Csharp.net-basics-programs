using System;
using System.Collections.Generic;
using System.Text;
//program on enum with different actions by sameer on 4/feb/2021
namespace TrainingSession2
{
    class enumex
    {
        enum Color { Blue, Black };



        // Main Method 
        public static void Main(String[] args)
        {
            Color c1 = Color.Blue;
            Console.Write("TypeCode of Enum Constant " + c1 + " : ");



            // Using the GetTypeCode() Method 
            Console.WriteLine(c1.GetTypeCode());



            Color c2 = Color.Blue;
            Console.Write("HashCode of Enum Constant " + c2 + " : ");



            // Using the GetTypeCode Method 
            Console.WriteLine(c2.GetHashCode());
        }

    }
}

