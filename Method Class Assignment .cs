using System; // Allows us to use Console and basic system features

// Create a class to hold our void method
class MathActions
{
    // Create a void method that takes two integers as parameters
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (multiply by 5)
        int result = firstNumber * 5;

        // Display the result of the math operation
        Console.WriteLine("Result of math operation on first number: " + result);

        // Display the second integer to the screen
        Console.WriteLine("Second number value: " + secondNumber);
    }
}

// Main program class
class Program
{
    // Main method where the program starts running
    static void Main()
    {
        // Instantiate the MathActions class
        MathActions math = new MathActions();

        // Call the method by passing two numbers normally (by position)
        math.DoMath(4, 10);

        // Call the method again, this time specifying parameters by name
        math.DoMath(firstNumber: 6, secondNumber: 20);

        // Keep the console window open until the user presses Enter
        Console.ReadLine();
    }
}
