using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option");
            Console.WriteLine("1.BinarySearchFile");
            Console.WriteLine("2.InsertionSort");
            Console.WriteLine("3.BubbleSort");
            Console.WriteLine("4.MergeSort");
            Console.WriteLine("5.Anagram");
            Console.WriteLine("6.primenumbers");
             Console.WriteLine("7.regex");
            int Option = int.Parse(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    BinarySearchFile.Binarysearch();
                    break;
                case 2:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.insertion();
                    break;
                case 3:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.bubblesort();
                    break;
                case 4:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.mergesort();
                    break;
                case 5:
                    Anagrams anagram = new Anagrams();
                    anagram.anagrams();
                    break;
                case 6:
                    PrimeRange.primenumbers();
                    break;
                    case 7:
                        Regex regex= new Regex();
                    regex.regularexpression();







                default:
                    break;

            }
        }
    }
}
