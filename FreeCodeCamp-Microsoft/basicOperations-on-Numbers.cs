//  https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/
//    Basic operations on numbers     2023.12.14
using System;

public class Program {
    public static void Main (string[] args) {
      /*Unit 2 Overloading the operator
          This means when one symbol has multiple purposes.
            - '+' : It's used as addition of numbers and 
                    as concatenation  of strings.
            - '()' : They are used as invocation of method,
                    as order of operations for operators,
                    as casting data.
      */
      string firstName = "Yuuka";
      int level = 25 ; 
      int levelUpper = 3 ;
      Console.WriteLine(firstName + " is level " + level); 
      // C-sharp compiler implicity convert an 'int' value into a 'string' value for concatenation.
      Console.writeLine(firstName + " has improve her level to " + level + levelUpper);
      Console.writeLine(firstName + " has improve her level to " + (level + levelUpper));
      // Use '()' to declare the order of operations.


      /* Unit 3  Basic math operators
         - '-' : is the subtraction operator
         - '+' : is the addition operator
         - '*' : is the multiplication operator
         - '/' : is the division operator
         - '%' : is the remainder operator
      */
      /*More Data types
          integer : use 'int' to declarate a integer value.
          decimal : use 'decimal' and 'm' to declarate a floating point number value.
                    The number (left of the assignment operator) should be type decimal.

        Data Conversion
          Casting is a type of data conversion, that allows temporarily treat a value as
          a different data type.
            -Use '(datatype)' in front of the value (before or right side) to cast it.

        Order of operations
          -PEMDAS:
          1.Parenthesis
          2.Exponents
          3.Multiplication and Division (from left to right)
          4.Addition and Subtraction (from left to right)

          C-sharp does not have exponent operator. It's common use the 
          System.Math.Pow method, from the .NET Class library.
      */        
      int sum = 4+2;
      int difference = 3-2;
      int product = 5*6;
      int quotient = 8/7;
      int remainder = 200%3;
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Difference: " + difference);
      Console.WriteLine("Product: " + product);
      Console.WriteLine("Quotient: " + quotient);
      Console.WriteLine($"Remainder:  {remainder}");
      Console.WriteLine($"Quotient(decimal): {(decimal)7/5}"); // casting
      Console.WriteLine($"Quotient(decimal): {7.0m/5}"); //decimal type
      Console.WriteLine(2+(3*5/4)-1); //PEMDAS


      /* Unit 4 Compound Assignment
         They compound some operation in addition to assigning the result to the variable.
        - '-=', '+=', '*=', '/='.
         - '--' and '++' : decrement  and increment value, can be assign 
         before or after the value for affect performing of retrieve.
      */  
      int numberA = 10;
      numberA -= 5;
      numberA += 3;
      numberA *= 7;
      numberA /= 7;
      Console.WriteLine("The grade note is: " + (++numberA));
      Console.WriteLine("I repeat, the grade note is: " + (numberA++));
      Console.WriteLine("The new grade note is: " + (numberA));
      Console.WriteLine("Nevermind, The grade note is: " + (--numberA));
      // Use '()' arround the expression '(++numberA)' improve readability.


      /* Challenge
        Convert fahrenheit to Celsius
        Expected output:
        The temperature is 34.444444444444444444444444447 Celsius.
      */
      //To convert Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).
      int fahrenheit = 94;
      int celsius = 0;
      decimal convertionFtoC = (fahrenheit - 32) * (5.0m / 9.0m);
      decimal convertionCtoF = (celsius / (5.0m / 9.0m)) + 32;
      Console.WriteLine($"The temperature is {celsius} Celsius.");
      Console.WriteLine($"or the temperature is {fahrenheit} Celsius.");

      decimal fahrenheit2 = 94;
      decimal celsius2 = 0;
      decimal convertionFtoC2 = (fahrenheit2 - 32) * (5.0m / 9.0m);
      celsius2 = convertionFtoC2;
      decimal convertionCtoF2 = (celsius2 / (5.0m / 9.0m)) + 32;
      fahrenheit2 = convertionCtoF2;
      Console.WriteLine($"The temperature is {celsius2} Celsius.");
      Console.WriteLine($"or the temperature is {fahrenheit2} fahrenheit.");

    }
}