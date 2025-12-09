using System;   // Gives access to basic .NET functionality like Console.

namespace StudentReport   // Namespace that groups related classes together.
{
    class Program         // The main class of our program.
    {
        // Entry point of the program. Execution starts here.
        static void Main(string[] args)
        {
            // ----- TITLE / HEADER -----

            // Prints the school name to the console.
            Console.WriteLine("Academy of Learning Career College");

            // Prints the title of the report on the next line.
            Console.WriteLine("Student Daily Report");

            // Prints a blank line for readability.
            Console.WriteLine();

            // ----- COLLECT STUDENT INFORMATION -----

            // Asks for the student's name and stores it as a string.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();    // Reads the name typed by the user.

            // Asks which course the student is on and stores it as a string.
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Asks which page number the student is on.
            Console.WriteLine("What page number?");
            // Reads the input as text, converts it to an integer, and stores it in pageNum.
            int pageNum = Convert.ToInt32(Console.ReadLine());

            // Asks if the student needs help and expects "true" or "false".
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();    // Stores the raw string answer.
            bool needHelpBool = bool.Parse(needHelp); // Converts the string to a boolean value.

            // Asks about positive experiences and stores the response as a string.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Asks for any other feedback and stores it as a string.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Asks how many hours the student studied today.
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();      // Reads the hours as text.
            int studyHoursNum = Convert.ToInt32(studyHours); // Converts the text to an integer.

            // ----- END MESSAGE -----

            // Prints a closing message to the student.
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            // Waits for the user to press Enter so the console window doesn't close immediately.
            Console.ReadLine();
        }
    }
}
