//    User Input    2023.12.15
using System;

public class userInput {
    public static void Main (string[] args) {
        /*User Input
          Readline() method takes user input and retrieve it.
            -From Console class.
            -Makes more interactive programs.
            -Only returns 'string' values.

          Type Conversion
          C-sharp lets convert a type of value to other.
            -'int' : This methods converts the values to an integer depending of
              bit size value needed.
                Convert.ToInt16()
                Convert.ToInt32() //32 bits is the default bit size of 'int' type in C-sharp
                Convert.ToInt64()
            -'boolean' : Converts a type to a boolean type.
                Convert.ToBoolean()
            -'char' : Converts a type to a char type.
                Convert.ToChar()
            -'Double' : Converts a type to a double type.
                Convert.ToDouble()
            -'string' : Converts a type to a string type.
                Convert.ToString()
        */
        string nickname;
        nickname = Console.ReadLine();
        Console.WriteLine("Welcome: " + nickname);
        string level;
        level = Console.ReadLine();
        int levelUser = Convert.ToInt32(level);
        Console.WriteLine($"Level: {levelUser}");
    }
}