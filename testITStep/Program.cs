using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testITStep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            ConsoleColor name_color = ConsoleColor.Green;

            Console.ForegroundColor = name_color;
            Console.WriteLine(name);

            Console.ResetColor();
        }
    }
}
