using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Quadratic
    {
        public  void rootsOfEquation()
        {
            double a = Utility.userInputs();
            double b = Utility.userInputs();
            double c = Utility.userInputs();
            double determinent = b * b - 4 * a * c;
            double root1;
            double root2;

            //roots are real and differnt
            if (determinent>0)
            {
              root1 =(-b+Math.Sqrt(determinent)/2*a);
              root2 = (-b - Math.Sqrt(determinent) / 2 * a);
                Console.WriteLine("the root1 and root2 are: " + root1 + root2);

            }
            else if(determinent==0)
                {
                    root1 = root2 = -b / 2 * a;
                    Console.WriteLine("the roots of equation are:" + root1);

                }
            else
            {
                double realpart = -b / 2 * a;
                double imaginarypart = Math.Sqrt(determinent / 2 * a);
                Console.WriteLine("the realpart and imaginary part:" + realpart + " " +imaginarypart);
            }

            
            

        }
    }
}
