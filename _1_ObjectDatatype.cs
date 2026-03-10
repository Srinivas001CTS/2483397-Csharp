// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //declaring a string
        string a="srinu";
        //appending 
        a += " is ";
        a += "a student";
        Console.WriteLine(a);
        //declaring an object
        object obj;
        obj=12.2F;
        Console.WriteLine(obj);
        
        //to show the type of the object by using GetType();
        Console.WriteLine(obj.GetType());
        
    }
}
