using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class _5_NesetedSwitch
    {
        public static void Main(string[] args) {
            int outer = 2;
            int inner = 3;

            switch (outer)
            {
                case 1:
                    Console.WriteLine("Outer value is 1");
                    break;
                case 2:
                    Console.WriteLine("outer value is 2");
                    switch (inner)
                    {
                        case 1:
                            Console.WriteLine("Inner value is 1");
                            break;
                        case 2:
                            Console.WriteLine("Inner value is 2");
                            break;
                        case 3:
                            Console.WriteLine("inner value is 3");
                            break;
                        default:
                            Console.WriteLine("The inner value is more than 3");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("The outer value is more than 2");
                    break;
            }
        }
    }
}
