using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineLengthCalculate
    {

        // Method to calculate distance
        public static void LineLength()
        {
            // variables
            int x1 = 3;
            int y1 = 4;
            int x2 = 4;
            int y2 = 3;
            int x3 = 4, x4 = 5, y3 = 5, y4 = 4;
            // Calculating distance
            double lengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lengthOfLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Lenth of Line is: " + lengthOfLine1);
            Console.WriteLine("Lenth of Line is: " + lengthOfLine2);
            if(lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("line1 and line2 are equal");
            }
            else
            {
                Console.WriteLine("line1 and line2 are not equal");
            }

        }
    }
}
