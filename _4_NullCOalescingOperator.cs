using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Code
    {
        public static void Main(string[] args)
        {
            string name = null;

            //Null coalescing operator is used when you want to use a default value if the value of the variable is null

            string result = name ?? "Default value";
            Console.WriteLine(result);


        }
    }
}
