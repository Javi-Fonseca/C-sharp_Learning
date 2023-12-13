//      Doing math  2023.12.11
using System;

public class Math {
    public static void Main (string[] args) {
        /*  Arithmatic operators
        "+" : addition.
        "-" : subtraction.
        "*" : multiplication.
        "/" : division.
        Every operator works as the data type 
        (e.g. "/" redondea the result with 'int' numbers).
          
            Arithmatic Rules on C#:
        C# follows regular math rules.
        */
    int WingsBeat_of_hummingbird_per_Second = 80;
    int WingsBeat_of_hummingbird_per_Minute = WingsBeat_of_hummingbird_per_Second * 60;
    Console.Write("Wings beat of a hummingbird: ");
    Console.Write(WingsBeat_of_hummingbird_per_Minute);
    Console.WriteLine(" beats/minute.");

    int numberA = 20;
    int numberB = 3;
    Console.Write(numberA / numberB);
    Console.WriteLine(". The result is a whole number, as 'int' is used as the data type.");
    }
}