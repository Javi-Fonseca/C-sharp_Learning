//      Variables   2023.12.11
using System;

public class Variables {
    public static void Main (string[] args) {
        /* The variables are containers of storing values.
        There are different types of values:
            -String = "chains of text" */
        
        string caracter; //Create a variable, type string.
        //This is called declaration.
        caracter = "Reisa"; //Assign a value for the variable.
        // This is called initialization.
        string weapon = "shotgun";  // Shorting is useful when the value is already known.
        Console.WriteLine(caracter);
        caracter = "Yuuka";  //Changing the value of a variable.
        Console.WriteLine(caracter);

        /*  Rules of variable names.
        1. It must begin with a letter or an underscore.
        2. It can't contain spaces.
        3. It can just contain letters, numbers or underscores.
        4. It is case-sensitive.
        5. Do not use keywords.
        Extra: Use descriptive names is so useful; makes the code more uderstandable. 
        */
    }   
}