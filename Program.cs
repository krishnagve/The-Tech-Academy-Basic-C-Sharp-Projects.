using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();

            // Ask the user to enter the first number
            Console.WriteLine("Enter an integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the second number (optional)
            Console.WriteLine("Enter a second integer, or just press Enter:");

            try
            {
                // Try to read and convert the second number
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Call the method with both numbers
                int results = mathOp.MathOperation(num1, num2);

                // Display the result
                Console.WriteLine(num1 + " * " + num2 + " = " + results);
            }
            catch
            {
                // If no second number is entered, call method with only one parameter
                int results = mathOp.MathOperation(num1);

                // Display the result using the default value
                Console.WriteLine(num1 + " * Default 1 = " + results);
            }

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
