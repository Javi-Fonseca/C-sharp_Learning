//https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/
//  Call Methods from the .NET class library    2023.12.18
using System;

public class callMethods {
    public static void Main (string[] args) {
        /*Calling Methods
        The term "state" define the condition of execution
        environment at a specific moment in time. As the code is
        execute line by line,values are store in variables.
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
    }
}