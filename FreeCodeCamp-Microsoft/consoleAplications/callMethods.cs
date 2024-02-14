//https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/
//  Call Methods from the .NET class library    2023.12.18
using System;

public class callMethods {
    public static void Main (string[] args) {
        /*Calling Methods
        The term "state" define the condition of execution
        environment at a specific moment in time. As the code is
        execute line by line, values are store in variables.
        A current state of the application is the collection of
        all the values stored in memory in that moment.

        Stateless (static) methods
            They are methods that don't need to rely on the current
            state of the application, they work without changing or
            referencing any values stored in memory.

            It can be access directly, the basis are:
            -Type the class name.
            -Use the member access operator(.).
            -Add the method name.
            -Add the method invocation operator ("()").
            -Specify the necessary arguments for the method.
            -Some methods need too:
                -Pass additional values.
                -Accept a return values.
        
        Stateful (instance) methods
            They are methods that need to access to the state of the app
            to work properly.
            They rely on values stored in memory or they modify the state.
            They keep track of their state in fields, which are variables
            defined on the class.
            Each new instance of the class gets its own copy of those
            fields in which to store state.

        A single class can support both stateful and stateless methods. 
        However, when you need to call stateful methods, you must first
        create an instance of the class so that the method can access
        state.
        An instance of a class is called an object.

        */
        /*	Stateful(instance) vs Stateless(static) methods
        -One approach for determining whether a method is stateful or stateless
        is to consult the documentation.
        -You can also attempt to access the method directly from the class itself.
        Worst can happen is get a compilation error.
        */
        //Next method is a stateful method.
        Random dice = new Random(); // Create an object called 'dice'
        int roll = dice.Next(1, 7); // Access and invocate the method 'Next'
        Console.WriteLine(roll);
        Console.WriteLine(dice.Next(1, 7));


        /*	Return values
        Void methods: Complete their function without return a value;
        they are 'quietly'.
        return a value is the primary function of a method.

	        input parameters
        The terms 'parameter' and 'argument' are used interchangeably.However,
        'parameter' refers to the variable that's being used inside the method. 
        'argument' is the value that's passed when the method is called.
        Methods use a 'method signature' to define the number and data type of
        each parameter. The coding statement that calls the method MUST adhere
        the parameters necessary for the method signature.
        Arguments, a concrete value, must be compatible with the parameter type.
        Altought, argument name (e.g., int low = 1;) doesnot have to be the same
        as the parameter name difined in the method.

        Many methods have too overloaded method signatures. this enable calling
        methods with or without arguments, and provide different data types on them.
        It is defined with multiple method signatures.
        */
        int number = 7;
        string text = "seven";

        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine(text); 
        // WriteLine is an example of overloaded method
        
        /* IntelliSense
        Visual Studio Code includes IntelliSense features that are powered by a language
        service. This featured, in c sharp, provides completions based on language
        semantics or based on your source code.
        
        Looking for Documentation
        learn.microsoft.com is a 'source of truth' when looking for documentation in
        C sharp.
        -Search engine request: "C# Class.Method()
            This search is useful for documentation for a method.
        */

        Random dice2 = new Random();
        int roll1 = dice2.Next();
        int roll2 = dice2.Next(101);
        int roll3 = dice2.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        /*An exclusive upper bound means that the number is not include in the range.
        In the example above, numbers no larger than 101 will be trow, but never will
        be 101. 
        */  

        // challenge
        int firstValue = 500;
        int secondValue = 600;
        int largerValue;
        int largerValue = Math.Max(firstValue, secondValue);
        Console.WriteLine(largerValue);
    }
}