using System;

namespace ConditionalStatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // If Statement Example
            int age = 20;
            if (age >= 18)  // Condition: if age is 18 or greater
            {
                Console.WriteLine("You are an adult.");
            }

            // If-Else Statement Example
            int temperature = 30;
            if (temperature > 25)  // Condition: if temperature is greater than 25
            {
                Console.WriteLine("It's a hot day.");
            }
            else
            {
                Console.WriteLine("It's a cool day.");
            }

            // Else-If Ladder Example
            int score = 75;
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // Switch Statement Example
            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the workweek!");
                    break;
                case "Friday":
                    Console.WriteLine("Almost the weekend!");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend! Enjoy!");
                    break;
                default:
                    Console.WriteLine("Midweek day.");
                    break;
            }

            // Real-world Example 1: Checking Voting Eligibility
            int voterAge = 16;
            if (voterAge >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            // Real-world Example 2: Checking Stock Availability
            int stockQuantity = 50;
            if (stockQuantity > 0)
            {
                Console.WriteLine("Item is in stock.");
            }
            else
            {
                Console.WriteLine("Item is out of stock.");
            }
        }
    }
}

/*
Conditional Statements in C#

In C#, conditional statements allow you to make decisions in your code based on conditions that evaluate to either true or false. Conditional statements help you control the flow of execution in your program.

There are several types of conditional statements in C#, including:

1. **If Statement**
2. **If-Else Statement**
3. **Else-If Ladder**
4. **Switch Statement**

-------------------
1. **IF Statement**
-------------------

The **if statement** allows you to execute a block of code only if a specified condition is true.

Example:

int age = 20;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}

------------------------
2. **IF-ELSE Statement**
------------------------
The if-else statement allows you to execute one block of code if the condition is true, and another block if the condition is false. It offers a way to 
handle both possible outcomes.

Example:

int temperature = 30;
if (temperature > 25)
{
    Console.WriteLine("It's a hot day.");
}
else
{
    Console.WriteLine("It's a cool day.");
}

---------------------
3. **ELSE-IF Ladder**
---------------------

The else-if ladder allows you to check multiple conditions in sequence. It is useful when you need to evaluate more than two possible outcomes. 
Once a true condition is found, the corresponding block of code is executed, and the remaining conditions are skipped.

Example:

int score = 75;
if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 50)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}

-----------------------
4. **SWITCH Statement**
-----------------------

The switch statement allows you to evaluate a single expression against multiple possible cases. It is often used when there are many potential conditions to check, 
and is more readable than using many if-else statements.

Example:

string day = "Monday";
switch (day)
{
    case "Monday":
        Console.WriteLine("Start of the workweek!");
        break;
    case "Friday":
        Console.WriteLine("Almost the weekend!");
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend! Enjoy!");
        break;
    default:
        Console.WriteLine("Midweek day.");
        break;
}

*/