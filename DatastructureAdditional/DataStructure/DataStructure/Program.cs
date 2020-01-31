using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.for Number Paranthesis");
            Console.WriteLine("4.for Queue Banking");
            Console.WriteLine("5.Palindrome check from queue");
            Console.WriteLine("6.Hashing function");
            Console.WriteLine("7.PrimeRange");
            Console.WriteLine("8.PrimeAnagramcheck");
            Console.WriteLine("--------------------------------");
            int option = Utility.IntegerInput();
            switch (option)
            {
                case 3:
                    ////creating object to another class and calling function with reference variable
                    NumberPharentheses numberPharentheses = new NumberPharentheses();
                    numberPharentheses.Pharentheses();
                    break;
                case 4:
                    ////creating object to another class and calling function by reference varaiable
                    QueueBanking queueBanking = new QueueBanking();
                    queueBanking.Bankinglist();
                    break;
                case 5:
                    ////creating object to another class and calling function by refernce varaiable 
                    PalindromeChecker palindromeChecker = new PalindromeChecker();
                    palindromeChecker.Palindrome();
                    break;
                case 6:
                    ////creating object to another class and calling function by reference varaiable
                    HashingFunction hashingFunction = new HashingFunction();
                    hashingFunction.Hashing();
                    break;
                case 7:
                    ////creating object to another class and calling function by reference varaiable
                    PrimeRange primeRange = new PrimeRange();
                    primeRange.Primerange();
                    break;
                case 8:
                    PrimeAnagram primeAnagram = new PrimeAnagram();
                    primeAnagram.Primeanagram();
                    break;

                default:
                    ////if u enter the not valid option it will ask u to enter the another option
                    Console.WriteLine("invalid option try again");
                    break;




            }
        }
    }
}
