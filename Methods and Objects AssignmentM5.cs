using System; // Allows access to Console and basic system features

namespace MethodsAndObjectsAssignment
{
    // Create a class called Person
    public class Person
    {
        // Property to store the first name
        public string FirstName { get; set; }

        // Property to store the last name
        public string LastName { get; set; }

        // Void method that prints the person's full name to the console
        public void SayName()
        {
            // Display the full name in the required format
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Create another class called Employee that inherits from Person
    public class Employee : Person
    {
        // Property to store the employee ID
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee sam = new Employee()
            {
                FirstName = "Sample", // Assign first name
                LastName = "Student"  // Assign last name
            };

            // Call the SayName() method inherited from the Person class
            sam.SayName();

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
