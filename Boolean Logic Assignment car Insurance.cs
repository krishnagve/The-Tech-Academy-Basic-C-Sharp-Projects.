using System;   

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------
            // CAR INSURANCE APPROVAL PROGRAM
            // ---------------------------------------------------

            // Ask the user for their age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());   // Convert input from text to integer

            // Ask whether the user has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());  // Convert input to boolean (true or false)

            // Ask how many speeding tickets the user has
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // ---------------------------------------------------
            // QUALIFICATION RULES
            // ---------------------------------------------------
            // Applicants must:
            // 1. Be over 15 years old
            // 2. Have NO DUI history
            // 3. Have 3 or fewer speeding tickets

            // Combine all rules into one boolean expression
            bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

            // ---------------------------------------------------
            // OUTPUT RESULT
            // ---------------------------------------------------
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);   // Prints true or false depending on rules

            // Keeps the console window open until user presses Enter
            Console.ReadLine();
        }
    }
}
