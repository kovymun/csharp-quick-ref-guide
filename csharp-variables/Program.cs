// Understanding Variables in C#

/*
* In this section, we will explore variables in C#.
* Variables are used to store and manage data in a program.
* We will look at different types of variables and how to use them in C#.
*/

// A simple demonstration of variables in C#:

using System;

class CSharpVariables
{
    static void Main()
    {
        // Declaring and initializing variables
        int age = 25; // Integer variable
        double pi = 3.14159; // Double-precision floating point variable
        char grade = 'A'; // Character variable
        string name = "Alice"; // String variable
        bool isStudent = true; // Boolean variable

        // Displaying variable values
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Pi Value: " + pi);
        Console.WriteLine("Is Student? " + isStudent);

        //String interpolation
        Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
    }
}

//SYNTAX for defining a variable
// datatype variableName = value; Variable declaration and initialization
