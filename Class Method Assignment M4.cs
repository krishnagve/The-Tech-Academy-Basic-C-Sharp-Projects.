using System; // Allows use of basic system functions like Console

namespace DivideByTwoApp
{
    // Static class - cannot be instantiated and contains only static members
    static class MathOperations
    {
        // VOID METHOD
        // This method takes an integer, divides it by 2, and displays the result
        public static void DivideByTwo(int number)
        {
            // Perform division
            int result = number / 2;

            // Display the result to the screen
            Console.WriteLine("Result (void method): " + result);
        }

        // METHOD WITH OUTPUT PARAMETER
        // This method divides the number by 2 and returns the result using an out parameter
        public static void DivideByTwo(int number, out int result)
        {
            // Assign the divided value to the output parameter
            result = number / 2;
        }

        // OVERLOADED METHOD
        // This method overloads DivideByTwo by accepting a double instead of int
        public static void DivideByTwo(double number)
        {
            // Perform division on a double value
            double result = number / 2;

            // Display the result
            Console.WriteLine("Result (overloaded method with double): " + result);
        }
    }

    class Program
    {
        static void Main()
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read user input from the console
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the void method that divides the number by 2
            MathOperations.DivideByTwo(userNumber);

            // Call the method with an output parameter
            MathOperations.DivideByTwo(userNumber, out int outputResult);

            // Display the output parameter result
            Console.WriteLine("Result (out parameter): " + outputResult);

            // Call the overloaded method using a double
            MathOperations.DivideByTwo((double)userNumber);

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
