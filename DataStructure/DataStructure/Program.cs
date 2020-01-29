using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.for Number Paranthesis");
            Console.WriteLine("4.for Queue Banking");
            Console.WriteLine("--------------------------------");
            int option = Utility.IntegerInput();
            switch (option)
            {
                case 3:
                    NumberPharentheses numberPharentheses = new NumberPharentheses();
                    numberPharentheses.Pharentheses();
                    break;
                default:
                    Console.WriteLine("invalid option try again");
                    break;
                case 4:
                    QueueBanking queueBanking = new QueueBanking();
                    queueBanking.Bankinglist();
                    break;



            }
        }
    }
}
