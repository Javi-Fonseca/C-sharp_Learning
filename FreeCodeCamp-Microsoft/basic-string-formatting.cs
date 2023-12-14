// https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/
//      Perform basic string formatting in C#      2023.12.13
using System;

public class Program {
    public static void Main (string[] args) {
        /*  Unit 2  -Basic string Formatting 
        -- Character escape sequence: Let us insert special characters to affect the output.
            - \t : insert a tab.
            - \n : insert or break in a new line.
            - \" : insert double quotation marks.
            - \r : carring return.
            - \u : unicode escape character; insert special character with 
            a four-character code in Unicode (UTF-16).
             NOTE: Some consoles, like cmd, does not display all Unicode 
             characters (e.g. cmd replace them with a question mark).
                Some characters require UTF-32, that  require a different escape sequence.
        
        -- Verbatim string literals: Let us insert every special charaters as a string.
            - @ : Just use it at the begging of the literal string: @"...
        */

        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("Hello\tWorld!");
        Console.WriteLine("I said \"Hello World!!!\"");
        Console.WriteLine(@"I need to speak in Japanase or what?");
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!!!!");

        /* Unit 3 String Concatenation
            String concatenation allows you to combine smaller literal 
            and variable strings into a single string.
                Use '+' for concatenation.
            NOTE: Avoid creating intermediate variables for concatenation.
        */
        string a = "HELLO";
        string b = "WORLD";
        Console.WriteLine("I SAID " + a + " "+ b + "!!!!!!!!!!!!!!!!!!!!!!!");

        /*  Unit 4 String Interpolation
            Combines multiple values into a sigle literal string by using
            a "template"  and one or MORE  interpolation expressions.
                -interpolation expression "{}" : put any expression that 
                returns a value inside curly braces.
                -literal string template "$" : the dollar sign becomes a literal
                string in a template as a prefix.
                -It is more easier to read.
        NOTE: Avoid creating intermediate variables for interpolation.

                String interpolation and verbatim literals
            You can them by combining the symbols for each and using that 
            as a prefix for the string template.
                NOTE: '$@' is the prefix, not '@$' (error CS8401).
        */
        string c = "Goodbye";
        string d = "World";
        Console.WriteLine($"Ah, You know what, {c} {d}!!!");
        Console.WriteLine($@"\Yeah, i said it, {c} {d}.\");

        // Exercise of Microsoft learn Unit 5
        /* Yhis must be the output:
            View English output:
                c:\Exercise\ACME\data.txt

            Посмотреть русский вывод:
                c:\Exercise\ACME\ru-RU\data.txt
        */
        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        Console.Write("View English output:" + "\n\t" + $@"c:\Exercise\{projectName}\data.txt" + "\n");
        Console.Write($@"{russianMessage}" + "\n\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");
    }
}