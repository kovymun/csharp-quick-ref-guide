/* C# Strings */

/*
1. Strings are used to store text. They are one of the most commonly used data types.
2. In C#, strings are instances of the `System.String` class.
3. Strings are immutable, meaning once a string is created, it cannot be modified. Any method that appears to modify a string actually returns a new string.
4. For heavy string manipulation, use `StringBuilder` from `System.Text` namespace as it's more memory-efficient.
5. Strings support many built-in methods like `ToUpper()`, `ToLower()`, `Trim()`, `Replace()`, `Split()`, and more.

Let’s explore various string operations and concepts with examples.
*/

using System;
using System.Text;  // Required for StringBuilder

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declaring and Initializing Strings
            string firstName = " James ";
            string lastName = "Smith";

            // 2. String Methods

            Console.WriteLine($"Original: '{firstName}'");

            // ToUpper - Converts to uppercase
            Console.WriteLine($"Upper case: {firstName.ToUpper()}");

            // ToLower - Converts to lowercase
            Console.WriteLine($"Lower case: {firstName.ToLower()}");

            // Trim - Removes whitespace at the start and end
            Console.WriteLine($"Trimmed: '{firstName.Trim()}'");

            // Replace - Replace part of the string
            string replaced = firstName.Replace("James", "John");
            Console.WriteLine($"Replaced: {replaced}");

            // Length - Get number of characters
            Console.WriteLine($"Length: {firstName.Length}");

            // Substring - Extract part of a string
            Console.WriteLine($"Substring (0, 3): {firstName.Substring(0, 3)}");

            // Contains - Check if a string contains a substring
            Console.WriteLine($"Contains 'Jam'? {firstName.Contains("Jam")}");

            // IndexOf - Find position of a character or substring
            Console.WriteLine($"Index of 'a': {firstName.IndexOf('a')}");

            // Split - Split string into array
            string fullName = "James Robert Smith";
            string[] nameParts = fullName.Split(' ');
            Console.WriteLine("Split full name:");
            foreach (string part in nameParts)
            {
                Console.WriteLine(part);
            }

            // 3. String Concatenation
            string full = firstName.Trim() + " " + lastName;
            Console.WriteLine($"Concatenated Name: {full}");

            // 4. String Interpolation
            Console.WriteLine($"Hello, my name is {firstName.Trim()} {lastName}");

            // 5. Escape Characters
            string quote = "She said, \"Hello!\"";
            Console.WriteLine(quote);

            string filePath = "C:\\Users\\James\\Documents";
            Console.WriteLine(filePath);

            // 6. StringBuilder (Efficient for frequent modifications)
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World!");
            Console.WriteLine($"StringBuilder Result: {sb.ToString()}");

            // 7. Null or Empty Checks
            string emptyString = "";
            string nullString = null;

            Console.WriteLine($"IsNullOrEmpty (emptyString): {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"IsNullOrEmpty (nullString): {string.IsNullOrEmpty(nullString)}");

            Console.WriteLine($"IsNullOrWhiteSpace (spaces): {string.IsNullOrWhiteSpace("   ")}");
        }
    }
}

/*
** Summary of Common String Methods: **

| Method               | Description                                  |
|----------------------|----------------------------------------------|
| .ToUpper()           | Converts all characters to uppercase         |
| .ToLower()           | Converts all characters to lowercase         |
| .Trim()              | Removes whitespace from start and end        |
| .Replace()           | Replaces part of the string with another     |
| .Substring(start, length) | Extracts part of the string             |
| .Contains()          | Checks if a substring exists                 |
| .IndexOf()           | Returns the position of a character/substr   |
| .Split()             | Splits the string into parts using delimiter |
| .Length              | Returns the number of characters             |

** Why Use StringBuilder? **

Because strings are immutable, if you are modifying a string many times (like in a loop), using a `StringBuilder` is more efficient. It avoids creating many intermediate string objects in memory.

Example:

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 5; i++)
{
    sb.Append("Line " + i + "\n");
}
Console.WriteLine(sb.ToString());
