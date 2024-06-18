using System;

class Program
{
    static void Main()
    {
        // Ask the user for their age
        Console.Write("Please enter your age: ");

        // Read the user input
        string input = Console.ReadLine();

        // Try to convert the input to an integer
        if (int.TryParse(input, out int age))
        {
            // Print out the age
            Console.WriteLine($"Your age is {age}.");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
