using System; // Imports the System namespace, which contains basic classes like Console

// Create a class named MathOperations
class MathOperations
{
    // Method 1: Takes an integer, performs a math operation, and returns an integer
    public int Calculate(int number)
    {
        // Add 10 to the incoming integer
        int result = number + 10;

        // Return the result as an integer
        return result;
    }

    // Method 2 (overloaded): Takes a decimal, performs a different math operation, and returns an integer
    public int Calculate(decimal number)
    {
        // Multiply the decimal by 2
        decimal result = number * 2;

        // Convert the decimal result to an integer and return it
        return Convert.ToInt32(result);
    }

    // Method 3 (overloaded): Takes a string, converts it to an integer, performs a math operation, and returns an integer
    public int Calculate(string number)
    {
        // Convert the string to an integer
        int convertedNumber = Convert.ToInt32(number);

        // Subtract 5 from the converted integer
        int result = convertedNumber - 5;

        // Return the final result
        return result;
    }
}

// Main program class
class Program
{
    // Main method where the program starts execution
    static void Main()
    {
        // Create an instance of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the first method (int version) and store the result
        int intResult = mathOps.Calculate(20);

        // Display the result of the integer calculation
        Console.WriteLine("Integer method result: " + intResult);

        // Call the second method (decimal version) and store the result
        int decimalResult = mathOps.Calculate(5.5m);

        // Display the result of the decimal calculation
        Console.WriteLine("Decimal method result: " + decimalResult);

        // Call the third method (string version) and store the result
        int stringResult = mathOps.Calculate("30");

        // Display the result of the string calculation
        Console.WriteLine("String method result: " + stringResult);

        // Keep the console window open until the user presses a key
        Console.ReadLine();
    }
}
