using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string simple = "This is a normal string";
            string verbatim = @"C:\Users\Joao\Documents";
            string ola = "Olá";
            string world = "World";
            int valor = 1;
            string s = String.Format("O número {0} é equivalente à letra {1}", 5, "B");
            double xx = 0.12345;
            int ii = 18;

            Console.WriteLine(simple);
            Console.WriteLine(verbatim);
            Console.WriteLine(ola + " " + world);
            Console.WriteLine("This " + world);
            Console.WriteLine($"O valor é {valor}");
            Console.WriteLine(s);
            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}
