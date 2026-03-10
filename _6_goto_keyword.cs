using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    internal class _6_goto_keyword
    {
        public static void Main(string[] args)
        {
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.Write("Helloo...");
                    goto default; ;
                case 2:
                    Console.Write("Kanuparthi ");
                    goto case 3;
                case 3:
                    Console.Write("Srinivasulu ");
                    goto case 1;
                default:
                    Console.WriteLine(" How are you ???");
                    break;
            }
        }
    }
}
