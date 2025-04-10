
using System;

namespace TypeCastingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type-Casting Example
            int num = 42;
            double result = num;  // Implicit casting from int to double
            Console.WriteLine("Implicit Casting Example: " + result);  // Output: 42.0

            // Explicit Type-Casting Example
            double price = 99.99;
            int roundedPrice = (int)price;  // Explicit casting from double to int
            Console.WriteLine("Explicit Casting Example: " + roundedPrice);  // Output: 99

            // Real-world Example 1: Temperature Conversion (Fahrenheit to Celsius)
            double fahrenheit = 98.6;
            int celsius = (int)((fahrenheit - 32) * 5 / 9);  // Explicit cast to int
            Console.WriteLine("Temperature Conversion Example: " + celsius);  // Output: 37

            // Real-world Example 2: Financial System (Currency Conversion USD to EUR)
            double usdAmount = 123.45;
            double exchangeRate = 0.91;  // USD to EUR conversion rate
            double eurAmount = usdAmount * exchangeRate;
            int roundedEurAmount = (int)eurAmount;  // Explicit cast to int
            Console.WriteLine("Currency Conversion Example: " + roundedEurAmount);  // Output: 112
        }
    }
}

/*
Type Casting in C#

In many programming languages, type casting refers to converting a value from one data type to another. In C#, type casting can be categorized into two types:

1. Implicit Casting (also known as automatic casting)
2. Explicit Casting (also known as manual casting)

IMPLICIT TYPE-CASTING

Implicit casting happens automatically when there is no risk of data loss. This typically occurs when a smaller data type is being converted to a larger data type, or when a derived class is being cast to its base class. The compiler automatically handles the casting without requiring any additional syntax.

For example, converting an int to a double is an implicit cast, as the double type can hold larger values than an int without losing any information.

Example of Implicit Casting:

int num = 42;
double result = num;  // Implicit casting from int to double
Console.WriteLine(result);  // Output: 42.0


In this example, the int value 42 is automatically cast to a double because double can represent all values of an int without any precision loss.

---------------------
EXPLICIT TYPE-CASTING
---------------------

* Explicit casting occurs when there is a potential risk of losing data, and you need to inform the compiler about the conversion. This happens when you're trying to convert 
from a larger type to a smaller type, or between incompatible types. In such cases, you need to use casting syntax to specify the conversion.

* For example, when converting a double to an int, you might lose the decimal part of the number. Explicit casting allows you to perform this conversion manually, 
but you must be aware of the potential data loss.

Example of Explicit Casting:

double price = 99.99;
int roundedPrice = (int)price;  // Explicit casting from double to int
Console.WriteLine(roundedPrice);  // Output: 99

In this case, we explicitly cast a double value 99.99 to an int, resulting in the value 99, and the decimal part is truncated.

**REAL-WORLD EXAMPLES**:

Example 1: Converting a Temperature
Imagine you're working with a temperature sensor that measures the temperature in Fahrenheit, but your display system only accepts temperature in Celsius. You may need to convert the Fahrenheit value to Celsius using type casting. The formula for conversion is:

Celsius = (Fahrenheit - 32) * 5 / 9

Here, you'll cast the Fahrenheit value (a double) to an integer if you're displaying a whole number for simplicity.


double fahrenheit = 98.6;
int celsius = (int)((fahrenheit - 32) * 5 / 9);  // Explicit cast to int
Console.WriteLine(celsius);  // Output: 37


Example 2: Financial System (Currency Conversion)
In a financial application, you might need to perform currency conversion from one currency (say USD) to another (say EUR). After performing the conversion, you may want to round the result to the nearest whole number for display purposes. You can use explicit casting to round the result.

double usdAmount = 123.45;
double exchangeRate = 0.91;  // USD to EUR conversion rate
double eurAmount = usdAmount * exchangeRate;
int roundedEurAmount = (int)eurAmount;  // Explicit cast to int
Console.WriteLine(roundedEurAmount);  // Output: 112

In this case, the result of the conversion is rounded to the nearest whole number before it is displayed.

In summary, type casting in C# allows you to convert data between different types, with implicit casting happening automatically when safe, and explicit casting used 
when potential data loss or type incompatibility is involved. It's important to understand when and how to use each type of casting to ensure the integrity of your data.
*/
