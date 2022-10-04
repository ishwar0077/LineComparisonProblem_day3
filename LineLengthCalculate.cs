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
            // variables for line 1
            int x1 = 3;
            int y1 = 4;
            int x2 = 4;
            int y2 = 3;

            //variable for line2
            int x3 = 4, x4 = 5, y3 = 5, y4 = 4;
            // Calculating distance
            double lengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lengthOfLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Lenth of Line1 is: " + lengthOfLine1);
            Console.WriteLine("Lenth of Line2 is: " + lengthOfLine2);

            int status = lengthOfLine1.CompareTo(lengthOfLine2);

            // checking the status
            if (status > 0)
            {
                Console.WriteLine("{0} is greater than {1}",
                                        lengthOfLine1, lengthOfLine2);
            }
            else if(status < 0 )
            {
                Console.WriteLine("{0} is less than {1}",
                                            lengthOfLine1, lengthOfLine2);
            }
            else
            {
                Console.WriteLine("{0} is equals to {1}",
                                            lengthOfLine1, lengthOfLine2);
            }
           
        }
    }
}