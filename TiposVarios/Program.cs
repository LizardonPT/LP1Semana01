// See https://aka.ms/new-console-template for more information
using System;

namespace TiposVarios
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int number = 3;
            float pi = 3.14f;
            double piplus = 2.14159;
            decimal z = 9.9999m;
            char emoji = '\u00A5';
            double real = 6.0e13;

            Console.WriteLine(number.ToString());
            Console.WriteLine(pi.ToString());
            Console.WriteLine(piplus.ToString());
            Console.WriteLine(z.ToString());
            Console.WriteLine(emoji);
            Console.WriteLine(real);
        }
    }
}
