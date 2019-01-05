using System;

namespace LiteralStringsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // A literal string is -- literally -- a string 
            // of individual characters, all strung together.

            // You use a set of double-quotes to define a 
            // literal string.
            string myString = "Hi";

            // What if you need to use double-quotes in your
            // literal string?  Use an escape!
            // myString = "He said \"Hi\".";

            // What if you need to use a back-slash?
            // myString = "Go to c:\\source\\repos";

            // ... or use a verbatim string ...
            // myString = @"Go to 
            // c:\source\repos";

            Console.WriteLine(myString);

            // You can concatenate two strings together using 
            // the concatenation operator:
            // myString = "Bob" + " " + "Tabor";

            // You can do this inside of a Console.WriteLine()
            // Console.WriteLine("Hello" + " " + "World!");
        }
    }
}
