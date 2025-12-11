using System;
using System.Collections.Generic;

namespace ArrayAppendAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Part 1 – Array and text append
            // -------------------------------

            // Create a one-dimensional array of strings.
            string[] messages = { "Hello", "Welcome", "Good Day", "Thanks", "Have Fun" };

            // Ask the user to input some text.
            Console.WriteLine("Please enter some text to add to each message:");
            string userText = Console.ReadLine(); // Store user input.

            // First loop: Append the user's text to each element in the array.
            // This loop modifies the array but does NOT print anything yet.
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] += " " + userText; // Add user text to the end of each string.
            }

            // Second loop: Print each updated string to the console.
            Console.WriteLine("\nUpdated messages:");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg); // Display each updated message.
            }

            // ------------------------------------------
            // Part 2 – Infinite loop example and fix
            // ------------------------------------------

            Console.WriteLine("\nExample of an INFINITE LOOP (commented out):");

            /*
             * ❌ This is an example of an infinite loop.
             * The variable 'number' never changes, so the condition stays true forever.
             *
             * int number = 1;
             *
             * while (number == 1)
             * {
             *     Console.WriteLine("This loop would run forever!");
             * }
             *
             * NOTE: This code is commented out so your program does not freeze.
             */

            Console.WriteLine("\nFixed version of the loop:\n");

            int number = 1;   // Start at 1.

            // ✔ FIX: We increment 'number' so the loop will eventually stop.
            while (number <= 3)   // This condition is false once number becomes 4.
            {
                Console.WriteLine("Loop iteration number: " + number);

                number++;         // Increment the loop variable so the loop ends.
            }

            // -----------------------------------------
            // Part 3 – Loops using < and <= operators
            // -----------------------------------------

            // Loop using "<" operator.
            Console.WriteLine("\nLoop using the '<' operator:");

            int x = 0; // Start value for x.

            // This loop runs while x is LESS than 5.
            while (x < 5)   // Using "<" operator.
            {
                Console.WriteLine("Value of x (using <): " + x);
                x++; // Increment x to move toward ending the loop.
            }

            // Loop using "<=" operator.
            Console.WriteLine("\nLoop using the '<=' operator:");

            int y = 0; // Start value for y.

            // This loop runs while y is LESS THAN OR EQUAL TO 5.
            while (y <= 5)   // Using "<=" operator.
            {
                Console.WriteLine("Value of y (using <=): " + y);
                y++; // Increment y to avoid an infinite loop.
            }

            // ---------------------------------------------------
            // Part 4 – List with unique items + single match search
            // ---------------------------------------------------

            // Create a list of UNIQUE strings.
            List<string> fruits = new List<string>()
            {
                "Apple",
                "Banana",
                "Cherry",
                "Mango",
                "Orange"
            };

            // Ask the user to search for an item in the list.
            Console.WriteLine("\nEnter text to search for in the list of fruits:");
            string searchInput = Console.ReadLine();

            bool found = false; // Tracks whether a match was found.

            // Loop through the list and search for the matching item.
            for (int i = 0; i < fruits.Count; i++)
            {
                // Compare in a case-insensitive way.
                if (fruits[i].ToLower() == searchInput.ToLower())
                {
                    Console.WriteLine($"\nMatch found at index {i}: {fruits[i]}");
                    found = true;
                    break; // Stop the loop once the first match is found.
                }
            }

            // If the user input doesn't match any list item, tell them.
            if (!found)
            {
                Console.WriteLine("\nThe item you entered is NOT on the list.");
            }

            // -----------------------------------------------------------------
            // Part 5 – List with duplicates + show ALL matching indices
            // -----------------------------------------------------------------

            // A list containing duplicate strings.
            List<string> animals = new List<string>()
            {
                "Dog",
                "Cat",
                "Bird",
                "Dog",
                "Fish",
                "Cat",
                "Dog"
            };

            Console.WriteLine("\nEnter text to search for in the animals list (contains duplicates):");
            string duplicateSearch = Console.ReadLine();

            bool duplicateFound = false; // Tracks if any matches exist.

            Console.WriteLine("\nSearching for ALL matches (no break):");

            // Loop through ENTIRE list and show every match (no break).
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].ToLower() == duplicateSearch.ToLower())
                {
                    Console.WriteLine($"Match found at index {i}: {animals[i]}");
                    duplicateFound = true;
                }
            }

            // If no match was found at all, tell the user.
            if (!duplicateFound)
            {
                Console.WriteLine("\nYour input is NOT on the list.");
            }

            // -----------------------------------------------------------------------
            // Part 6 – Foreach + duplicate detection (similar to the model solution)
            // -----------------------------------------------------------------------

            // Create a list of strings that has at least two identical strings in it.
            List<string> names = new List<string>()
            {
                "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary"
            };

            // This list will track which names we have already seen.
            List<string> repeatCheck = new List<string>();

            Console.WriteLine("\nChecking which names are unique and which are duplicates:\n");

            // Foreach loop that evaluates each item in the list.
            foreach (string name in names)
            {
                // If the name is already in repeatCheck, it has appeared before.
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine(name + " - this name has been repeated. " +
                                      "Use last name initial when referring to this student.");
                }
                else
                {
                    // First time we see this name: it is unique so far.
                    Console.WriteLine(name + " - this name has not been repeated.");
                    repeatCheck.Add(name); // Record that we've seen this name.
                }
            }

            // Keep the console window open so the user can read the output.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
