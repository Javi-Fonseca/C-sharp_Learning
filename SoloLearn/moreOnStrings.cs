// More on Strings      2023.12.31
using System;

public class Strings2 {
    public static void Main (string[] args) {
        /* Escape Character
        Use scape character (backslash "\") to include quotes or
        special characters on a string.
        
        Special characters:
            \n : create or add a new line.
            \t : create or add a tab.
        
        Verbatim String:
        Allows special characters and linebreaks on strings.
        */
        Console.WriteLine("Hello\n\tWorld!!!!!!");
        Console.WriteLine(@"Hello
            World!!!!!!");
        /*Exercise
        The given codes declares a text variable with a value of
        "ABCD". Write a program to output each letter on a separete
        line.
        Expected output:
        A
        B
        C
        D
        */
        string text = "A\nB\nC\nD";
        Console.WriteLine(text);
    }
}