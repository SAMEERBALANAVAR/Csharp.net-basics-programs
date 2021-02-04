using System;
using System.Collections.Generic;
using System.Text;
//Program on JaggedArray by sameer on 4/feb/2021
namespace ConsoleApp1
{
	//class name JaggedArray
    class JaggedArray
    {
		public static void Main()
		{
			//creating two array ie array inside array
			int[][,] jArray = new int[2][,];
			//3 columns and 2 rows array we have created
			jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
			jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };
			//printing the every indivisual lines of arrray elements of array for first array elements
			Console.WriteLine(jArray[0][0, 0]);
			Console.WriteLine(jArray[0][0, 1]);
			Console.WriteLine(jArray[0][1, 0]);
			Console.WriteLine(jArray[0][1, 1]);
			//printing  the every indivisual lines of arrray elements for second array elements
			Console.WriteLine(jArray[1][0, 0]);
			Console.WriteLine(jArray[1][0, 1]);
			Console.WriteLine(jArray[1][1, 0]);
			Console.WriteLine(jArray[1][1, 1]);
		}
	}
}
