using System;

namespace FizzBuzz_Library
{
    public class FizzBuzzer
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public string GetBuzzer(int number)
        {
            string result = "";

            if (number % 3 == 0)
            {
                result += Fizz;
            }

            if (number % 5 == 0)
            {
                result += Buzz;
            }

            return String.IsNullOrEmpty(result) ? number.ToString() : result;
            
        }
    }
}
