/* C# Strings */
/*
1. Strings are one of the most fundamental data types in programming. They represent sequences of characters and are used for storing and manipulating text.
2. In C#, the string type is an immutable reference type, meaning once a string is created, it cannot be changed. This immutability has implications for performance and 
memory management, making it essential to understand how to work with strings efficiently.


*/


using System;


namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a string variable and assign a name to it
            string firstName = " James ";

            // String Method: Convert the string to uppercase and print it to the console
            Console.WriteLine($"Upper case string: {firstName.ToUpper()}");


            // String Method: Convert the string to lowercase and print it to the console
            Console.WriteLine($"Lower case string: {firstName.ToLower()}");

            // String Method: Remove leading and trailing whitespace from the string and print it to the console
            Console.WriteLine($"Trimmed string: {firstName.Trim()}");
        }
    }

}

// Considerations:
// StringBuilder is used for efficient string manipulation.
// Example:
// using System.Text;
// StringBuilder sb = new StringBuilder();  // Creating an instance of StringBuilder
