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

            Console.Write("Enter middle name: ");
            string middle_name = Console.ReadLine();


            Console.Write("Enter last name: ");
            string last_name = Console.ReadLine();

            ConsoleColor name_color = ConsoleColor.Green;
            ConsoleColor middle_name_color = ConsoleColor.Blue;
            ConsoleColor last_name_color = ConsoleColor.Magenta;

            Console.ForegroundColor = name_color;
            Console.Write(name);

            Console.ForegroundColor = middle_name_color;
            Console.Write(" ");
            Console.Write(middle_name);

            Console.ForegroundColor = last_name_color;
            Console.Write(" ");
            Console.WriteLine(last_name);

            Console.ResetColor();
        }
    }
}
