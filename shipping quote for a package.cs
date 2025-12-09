using System;  

namespace ShippingQuoteAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------------
            // PROGRAM GREETING
            // --------------------------------------------------------------
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");



            // --------------------------------------------------------------
            // ENTER PACKAGE WEIGHT
            // --------------------------------------------------------------
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program here
            }



            // --------------------------------------------------------------
            // ENTER PACKAGE DIMENSIONS
            // --------------------------------------------------------------
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Sum of all dimensions
            decimal dimensionTotal = width + height + length;

            // Too large?
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program here
            }



            // --------------------------------------------------------------
            // CALCULATE SHIPPING QUOTE
            // --------------------------------------------------------------
            decimal quote = (width * height * length * weight) / 100;



            // --------------------------------------------------------------
            // DISPLAY ESTIMATED TOTAL
            // --------------------------------------------------------------
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            Console.ReadLine();  // Keeps the console open
        }
    }
}
