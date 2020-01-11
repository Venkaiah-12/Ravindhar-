using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option");
            int Option = int.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:

                    ReplaceString.ReplaceStringMethod();
                    break;
                case 2:
                    flipcoin.flippercentage();
                    break;
                case 3:
                    leapyear.foundyear();
                    break;
                case 4:
                    poweroftwo.powertwo();
                    break;
                case 5:
                    harmonic.harmonicseries();

                    break;
                case 6:
                    factors.factornumber();
                    break;

                case 7:
                    gambling.gambler();
                    break;
                case 8:
                   
                    couponnumber.coupon();

                    break;
                
                
                
                default:
                    break;
            }
        }
    }
}
