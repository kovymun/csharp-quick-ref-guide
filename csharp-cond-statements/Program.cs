/*
If-else Statements:
The if statement evaluates a condition, and if it's true, the associated code block is executed. If the condition is false, the else block (if present) runs instead.

SYNTAX:

if (condition)
{
    // Code to execute if the condition is true
}
else
{
    // Code to execute if the condition is false
}
*/

using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

        }
    }
}

