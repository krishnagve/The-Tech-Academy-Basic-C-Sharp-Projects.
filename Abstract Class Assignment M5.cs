using System; // Provides access to Console and basic system functionality

namespace AbstractClassesAssignment
{
    // Create an abstract class called Person
    public abstract class Person
    {
        // Property to store the first name
        public string firstName { get; set; }

        // Property to store the last name
        public string lastName { get; set; }

        // Abstract method that must be implemented by derived classes
        public abstract void SayName();
    }

    // Create another class called Employee that inherits from Person
    public class Employee : Person
    {
        // Property to store employee ID (included in model answer)
        public int Id { get; set; }

        // Implement the SayName() method required by the abstract Person class
        public override void SayName()
        {
            // Write the full name to the console in the required format
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee sam = new Employee()
            {
                firstName = "Sample",  // Assign first name
                lastName = "Student"   // Assign last name
            };

            // Call the SayName() method on the Employee object
            sam.SayName();

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
