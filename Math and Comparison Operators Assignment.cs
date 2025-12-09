using System;  

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------
            // PROGRAM HEADER
            // ---------------------------------------------
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine(); // Blank line for readability


            // ---------------------------------------------
            // PERSON 1 INPUT
            // ---------------------------------------------
            Console.WriteLine("Person 1");

            // Ask for hourly rate and read input as a string
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();

            // Ask for hours worked per week and read input as a string
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();

            // Convert both inputs to integers and calculate annual salary (52 weeks)
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;



            // ---------------------------------------------
            // PERSON 2 INPUT
            // ---------------------------------------------
            Console.WriteLine();  // Blank line for visual separation
            Console.WriteLine("Person 2");

            // Ask for hourly rate
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();

            // Ask for hours worked per week
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();

            // Convert inputs and calculate annual salary
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;



            // ---------------------------------------------
            // OUTPUT SECTION
            // ---------------------------------------------

            // Display Person 1 annual salary
            Console.WriteLine();
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            // Display Person 2 annual salary
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            // Compare salaries: returns true or false
            bool person1MakesMore = salary1 > salary2;

            // Print result of comparison
            Console.WriteLine("Person 1 makes more money than Person 2:");
            Console.WriteLine(person1MakesMore);

            // Keep console open until user presses Enter
            Console.ReadLine();
        }
    }
}
