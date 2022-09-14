using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LineComparisonProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-1 Calculate the Length of Line
            //variables
            int x1;
            int y1;
            int x2; 
            int y2; 
            double Length;

            Console.WriteLine("Please Enter the X1 and Y1 values:");
            Console.WriteLine("x1 value");
            x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 value");
            y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the x2 and y2 values:");
            Console.WriteLine("x2 value");
            x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 value");
            y2= Convert.ToInt32(Console.ReadLine());

            //Formula
            Length = Math.Sqrt((x2 - x1 ^ 2 + y2 - y1 ^ 2));

            Console.WriteLine("Length of the Line is: "+Length);
            Console.ReadLine();

        }
    }
}
