using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables and Constants
            const char myChar = 'A';
            const double PI = 3.14;

            int firstNumber = 20;
            string firstName = "";
            
            Console.WriteLine($"The first number = {firstNumber}");

            // Expressions

            double calculationResult = 0;
            calculationResult = firstNumber + 10;
           Console.WriteLine($"Adding {firstNumber} to 10 = {calculationResult}");

            // Casting
            int result = 0;
            double testResult = 3.3;
            result = (int)testResult;
           Console.WriteLine(result);

            // Parsing strings
            string inputValue1 = "456";
            result = 4 + int.Parse(inputValue1);
            Console.WriteLine($"I am using parsing. The result of adding {inputValue1} to 4 = {result}");

            bool parseStatus;

            int myParsedResult;

            parseStatus = int.TryParse("Adi", out myParsedResult);

            if(parseStatus)
            {
                result = myParsedResult + 4;
                Console.WriteLine($"I am using parsing. The result of adding {myParsedResult} to 4 = {result}");
            }
            else
            {
                Console.WriteLine("You did not enter a numeric value.");
            }

            // Loops
            // 1. For loops

           /* for(int counter = 1; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            } */

            // Use a loop to iterate through an array

            int[] myArray = { 1, 3, 5, 6, 8, 9, 10 };

            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine($"myArray[{i}] = {myArray[i]}");
        }
    }
}
