// See https://aka.ms/new-console-template for more information
using System;

namespace Argumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            
        }
    }
}
