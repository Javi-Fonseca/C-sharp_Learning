//      Arithmatic Operations   2023.12.11
using System;

public class Arithmatic {
    public static void Main (string[] args) {
         /*  Arithmatic operators
        "%" : addition.
        "-" : subtraction.
        "*" : multiplication.
        "/" : division.
        Every operator works as the data type 
        (e.g. "/" redondea the result with 'int' numbers).
        "%" : modulo operator. Returns the reminder of a division.
        "++" : increment. It's shorthand for "var = var + 1;".
        "--" : decrement. It's shorthand for "var = var - 1;".
            Both, increment and decrement, can only be applied to variables.
            Both, can be applied before and after the variable.
          
            Arithmatic Rules on C#:
        C# follows regular math rules.
        */
        int numA = 100;
        int numB = 30;
        int modulo = numA % numB;
        Console.WriteLine(modulo);
        Console.Writeline(modulo++);
        Console.WriteLine(modulo);
        Console.WriteLine(++modulo);
        Console.WriteLine(modulo--);
        Console.WriteLine(modulo);
        Console.WriteLine(--modulo);
    }
}