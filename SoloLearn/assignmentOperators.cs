//    Assignment Operators    2023.12.15
using System;

public class Operators {
    public static void Main (string[] args) {
        /*Assignment Operators
          Assign values to variables for make working with variables
          easier.
            -'=' : equal assignment operator.
                   Use ',' to create different variables of same type
                   in the same statement.
            -'+=' : addition assignment operator.
        */
        int x=5, y=6, z=7;
        x+=y; 
        y-=z;
        z*=x;
        x/=y;
        y%=z;
        Console.WriteLine($"x={x}, y={y}, z={z}");
    }
}