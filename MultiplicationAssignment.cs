using System;  

class Program
{
    static void Main(string[] args)
    {
        // -------------------------------
        // 1. Multiply user input by 50
        // -------------------------------

        Console.WriteLine("Enter a number to multiply by 50:");
        // Using long ensures large numbers (bigger than 10,000,000) can be handled safely.
        long input1 = Convert.ToInt64(Console.ReadLine());
        long result1 = input1 * 50;
        Console.WriteLine("Result: " + result1);
        Console.WriteLine();   // Blank line for readability



        // -------------------------------
        // 2. Add 25 to user input
        // -------------------------------

        Console.WriteLine("Enter a number to add 25 to:");
        long input2 = Convert.ToInt64(Console.ReadLine());
        long result2 = input2 + 25;
        Console.WriteLine("Result: " + result2);
        Console.WriteLine();



        // -------------------------------
        // 3. Divide user input by 12.5
        // -------------------------------

        Console.WriteLine("Enter a number to divide by 12.5:");
        double input3 = Convert.ToDouble(Console.ReadLine());
        double result3 = input3 / 12.5;   // Using double for decimal accuracy
        Console.WriteLine("Result: " + result3);
        Console.WriteLine();



        // -------------------------------
        // 4. Check if input is > 50
        // -------------------------------

        Console.WriteLine("Enter a number to check if it is greater than 50:");
        double input4 = Convert.ToDouble(Console.ReadLine());
        bool isGreaterThan50 = input4 > 50;   // Boolean comparison
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);
        Console.WriteLine();



        // -------------------------------
        // 5. Divide input by 7 and show the remainder (% operator)
        // -------------------------------

        Console.WriteLine("Enter a number to find the remainder when divided by 7:");
        long input5 = Convert.ToInt64(Console.ReadLine());
        long remainder = input5 % 7;   // % gives the remainder after division
        Console.WriteLine("Remainder: " + remainder);
        Console.WriteLine();



        // Prevents automatic window closing
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
