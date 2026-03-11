using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class _7_Swith_with_continue
    {
        public static void Main(string[] args)
        {
            string[] arr = { "apple", "banana", "mango" };
            foreach (string i in arr)
            {
                switch (i)
                {
                    case "apple":
                        Console.WriteLine("Apple Found");
                        continue;
                    case "banana":
                        Console.WriteLine("Banana Founded!");
                        break;
                    default:
                        Console.WriteLine("Some other fruit!!!");
                        break;
                }
                Console.WriteLine("I am not run when you used 'continue' keyword");
            }
        }
    }
}
