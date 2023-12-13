//      Data Types  2023.12.11
using System;

public class Variables {
    public static void Main (string[] args){
        /* Data types:
            -String: Everything in double quotes is a string.
            -Char: Stores a sigle character, enclosed in sigle quotes.
            -Integer: Int is used to store whole numbers.
            -Double: Double is used to store decimal numbers.
            -Float: Uses less storage in memory than double, but it is less precise.
                Need a 'f' postfix for declaration.
            -Decimal: Uses more storage in memory than double, but is is more precise.
                Need a 'm' postfix for declaration.
            -Boolean: Value of condition, just 'true' or 'false'.
        */
        string character = "Yuuka";
        char range = 'S';
        int age = 16;
        float height = 1.56f;
        double weight = 100.01;
        decimal efectivity = 95.5m;
        bool active = true;
        
        Console.WriteLine("Character info:");
        Console.Write("Name: ");
        Console.WriteLine(caracter);
        Console.Write("Range field: ");
        Console.WriteLine(range);
        Console.Write("Age: ");
        Console.WriteLine(age);
        Console.Write("Height: ");
        Console.WriteLine(height);
        Console.Write("Weight: ");
        Console.WriteLine(weight);
        Console.Write("Efectivity: ");
        Console.WriteLine(efectivity);
        Console.Write("Active player: ");
        Console.Writeline(active);
    }
}