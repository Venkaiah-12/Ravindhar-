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
                    Flipcoin.flippercentage();
                    break;
                case 3:
                    LeapYear.foundyear();
                    break;
                case 4:
                    PowerOfTwo.powertwo();
                    break;
                case 5:
                    Harmonic.harmonicseries();

                    break;
                case 6:
                    Factors.factornumber();
                    break;

                case 7:
                    Gambling.gambler();
                    break;
                case 8:
                   
                    CouponNumber.coupon();

                    break;
                case 9:
                    TwoDimension.twodim();
                    break;
                case 10:
                    ArrayTriplet.triplets();
                    break;
                case 11:
                    Distance distance = new Distance();
                    distance.origintopoint();
                    break;
                case 12:
                    Quadratic quadratic = new Quadratic();
                    quadratic.rootsOfEquation();
                    break;
                case 13:
                    Windchill windChill = new Windchill();
                    windChill.temperaturetofarhenhit();
                    break;
                case 14:
                    StopWatch stopwatch = new StopWatch();
                        break;
                case 15:
                    VendingMachine vendingMachine = new VendingMachine();
                    vendingMachine.CurrencyNotes();

                    break;
                case 16:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.daysofweek();
                    break;
                case 17:
                    TemperatureConversion temperatureConversion = new TemperatureConversion();
                    temperatureConversion.temperaturecoversion();
                    break;

                default:
                    break;
            }
        }
    }
}
