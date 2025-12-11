using System;
using System.Collections.Generic;

namespace ArrayAndListAssignment
{
    class ArrayAssigment
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------
            // 1) STRING ARRAY
            // ---------------------------------------------------------

            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Mango", "Orange" };

            // Ask the user for an index to display the value at that index
            Console.WriteLine("Select an index (0–4) to view a fruit from the string array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Validate the index using a try/catch
            try
            {
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            catch
            {
                // Message when user selects an invalid index
                Console.WriteLine("Sorry, that index does not exist in the string array.");
            }



            // ---------------------------------------------------------
            // 2) INTEGER ARRAY
            // ---------------------------------------------------------

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask user for an index to display the integer at that index
            Console.WriteLine("\nSelect an index (0–4) to view a number from the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Validate index using try/catch
            try
            {
                Console.WriteLine("The number at that index is: " + intArray[intIndex]);
            }
            catch
            {
                Console.WriteLine("Sorry, that index does not exist in the integer array.");
            }



            // ---------------------------------------------------------
            // 3) STRING LIST
            // ---------------------------------------------------------

            // Create a list of strings
            List<string> nameList = new List<string>()
            {
                "Krishna",
                "Arjuna",
                "Bheem",
                "Nakula",
                "Sahadeva"
            };

            // Ask user for an index to display a name from the list
            Console.WriteLine("\nSelect an index (0–4) to view a name from the list:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Validate index using try/catch
            try
            {
                Console.WriteLine("You selected: " + nameList[listIndex]);
            }
            catch
            {
                Console.WriteLine("Sorry, that index does not exist in the list.");
            }

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
