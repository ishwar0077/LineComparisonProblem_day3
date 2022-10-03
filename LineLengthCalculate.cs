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
            // Calculating distance
            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
            Console.WriteLine("Lenth of Line is: " + lengthOfLine);
            
        }
    }
}
