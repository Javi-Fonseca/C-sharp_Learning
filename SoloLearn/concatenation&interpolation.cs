// Concatenation and Iterpolation   2023.12.31
using System;

public class Strings3{
    public static void Main (string[] args){
        /* Concatenation
        Using the addition operator "+" for add one string to another
        is called "Concatenation"
        -Even numbers inside a string are added as string rather than
        numbers.
        -It's possible perform concatenation with variables.

        Interpolation
        Adding a variable inside other variable or in astring is
        called "Interpolation".
        -To create it:
        --Add the prefix "$" symbol before the double quotes.
        --Add the variable inside curly brackets "{}".
        */
        string player1Name = "El puerquito que llora";
        string player2Name = "noonmaster";
        string player3Name = "elpepe4490";
        Console.WriteLine(
        $"The player \"{player1Name}\", " +
        $"\"{player2Name}\" and " + 
        @$""{player3Name}" are eliminated!.");

        /*Exercise
        Make a country cards for a school project. The program takes
        the country and the name of its capital name, and output a
        string in the next format:
        Country:"contryname",Capital:"capitalname"
        */
        string country = Console.ReadLine();
        string capital = Console.ReadLine();
        Console.WriteLine(@$"Country: {country}, Capital: {capital}");
    }
}