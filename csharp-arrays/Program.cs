using System;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Declaration and Initialization
            int[] numbers = new int[5]; // Declare an array of 5 integers
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine("Accessing elements in an array:");
            Console.WriteLine(numbers[0]); // Output: 10
            Console.WriteLine(numbers[4]); // Output: 50

            // Another way to declare and initialize
            string[] fruits = { "Apple", "Banana", "Cherry" };

            Console.WriteLine("\nLooping through string array:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            // Using foreach loop
            Console.WriteLine("\nUsing foreach to loop through integer array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Real-world Example 1: Store weekdays
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            Console.WriteLine("\nWeekdays:");
            foreach (string day in weekdays)
            {
                Console.WriteLine(day);
            }

            // Real-world Example 2: Calculate average score
            double[] scores = { 88.5, 92.0, 76.5, 81.0 };
            double total = 0;
            foreach (double score in scores)
            {
                total += score;
            }
            double average = total / scores.Length;
            Console.WriteLine($"\nAverage Score: {average}");
        }
    }
}

/*
Arrays in C#

In C#, an array is a data structure that holds a fixed number of elements of the same type. Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

-------------------
1. **Declaring an Array**
-------------------
Syntax:
int[] numbers = new int[5];

You can also initialize at the time of declaration:
int[] numbers = { 10, 20, 30, 40, 50 };

-------------------------------
2. **Accessing Array Elements**
-------------------------------
Array elements are accessed using their index (starting from 0).

Example:
Console.WriteLine(numbers[0]); // Output: 10

--------------------------
3. **Looping Through Arrays**
--------------------------

Using a **for loop**:
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Using a **foreach loop**:
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

----------------------------
4. **Real-world Applications**
----------------------------

- Storing a list of items such as names, weekdays, scores.
- Calculating statistical values like average, min, max.
- Building fixed menus or static data lists.

Example: Calculating average score

double[] scores = { 88.5, 92.0, 76.5, 81.0 };
double total = 0;
foreach (double score in scores)
{
    total += score;
}
double average = total / scores.Length;
Console.WriteLine($"Average Score: {average}");

*/
