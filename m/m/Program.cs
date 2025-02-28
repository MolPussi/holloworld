using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выполнить операцию '-'");
                Console.WriteLine("5. Выполнить операцию '*'");
                Console.WriteLine("6. Выполнить операцию '/'");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт меню: ");

                string choice = Console.ReadLine();

                if (choice == "0") break;

            }
        }
    }
}
