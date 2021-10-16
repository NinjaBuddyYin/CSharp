using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string word = "";
            string reverseWord = "";
            int length;

            Console.WriteLine("Enter a 5 letter word: ");
            word = Console.ReadLine();

            length = word.Length;
            //5 Character check
            while (length != 5)
            {
                Console.WriteLine("\n\tERROR!\n\n");
                Console.WriteLine("Enter a 5 letter word: ");
                word = Console.ReadLine();
                length = word.Length;
            }

            length = length - 1;
            //Reversing
            while (length >= 0)
            {
                reverseWord = reverseWord + word[length];
                length = length - 1;
            }
            //Output
            Console.WriteLine("\nOriginal word = {0}", word);
            Console.WriteLine("Reversed word = {0}", reverseWord);
            //Output File. Exported at: \source\repos\ReverseCSharp\ReverseCSharp\bin\Debug\net5.0\output.txt
            StreamWriter file = new StreamWriter("output.txt");
            file.WriteLine(word);
            file.WriteLine(reverseWord);
            file.Close();
        }
    }
}