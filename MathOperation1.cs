using System; 

namespace MainMethodAssignment
{
    // Create a class to hold the math operation
    class MathOperation1
    {
        // Create a method that takes two integers
        // The second parameter is optional and defaults to 1
        public int MathOperation(int i, int j = 1)
        {
            // Multiply the two integers
            int result = i * j;

            // Return the multiplication result
            return result;
        }
    }
}
