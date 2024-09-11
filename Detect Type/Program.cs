using System;
using System.Collections.Generic;

namespace Detect_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput("Input anything bro idc");
        }
        static void GetInput(string inputMessage)
        {
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                var rawInput = Console.ReadLine();

                if (int.TryParse(rawInput, out int intValue))
                {
                    Console.WriteLine("it is an int");
                }
                else if (char.TryParse(rawInput, out char charValue))
                {
                    Console.WriteLine("it is an char");
                }
                else if (bool.TryParse(rawInput, out bool boolValue))
                {
                    Console.WriteLine("it is an bool");
                }
                else if (double.TryParse(rawInput, out double doubleValue))
                {
                    Console.WriteLine("it is an double");
                }
                else
                {
                    Console.WriteLine("type is string");
                }









            }
        }
    }
}
