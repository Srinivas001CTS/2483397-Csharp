using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class _8_Throwkeyword
    {
        static string sub = null;

        //throwing a new exception with custom message
        static void displaysubject(string subject)
        {
            if(subject == null)
            {
                throw new NullReferenceException( "Exception message");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                displaysubject(sub);
            }catch(Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }

        }
    }
}
