using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Windchill
    {
        public  void temperaturetofarhenhit()
        {
            double t = Utility.userInputs();
            double v = Utility.userInputs();
            double w = 35.74 + 0.6215*t +(0.4275*t - 35.75)*Math.Pow(v, 0.16);
            Console.WriteLine("the weigth of time and velocity are :" + w);

        }
    }
}
