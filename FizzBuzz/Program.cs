using FizzBuzz_Library;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPlease enter a number: ");
                int userInput = int.Parse(Console.ReadLine());
                FizzBuzzer fizzBuzzer = new FizzBuzzer();
                Console.WriteLine(fizzBuzzer.GetBuzzer(userInput));
            }  
        }
    }
}
