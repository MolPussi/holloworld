﻿using System;
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
            double a = 0; // Переменная для хранения A
            double b = 0; // Переменная для хранения B
            bool isASet = false; // Флаг для проверки, введено ли A
            bool isBSet = false; // Флаг для проверки, введено ли B

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

                if (choice == "1")
                {
                    // Ввод A
                    Console.Write("Введите A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    isASet = true; // Устанавливаем флаг, что A введено
                }
                else if (choice == "2")
                {
                    // Ввод B
                    Console.Write("Введите B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    isBSet = true; // Устанавливаем флаг, что B введено
                }
                else if (choice == "3")
                {
                    // Операция сложения
                    if (isASet && isBSet)
                    {
                        double result = a + b;
                        Console.WriteLine($"Результат A + B = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Сначала введите A и B.");
                    }


                }
                else if (choice == "4")
                {
                    // Операция вычитания
                    if (isASet && isBSet)
                    {
                        double result = a - b;
                        Console.WriteLine($"Результат A - B = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Сначала введите A и B.");
                    }
                }
                else if (choice == "5")
                {
                    // Операция умножения
                    if (isASet && isBSet)
                    {
                        double result = a * b;
                        Console.WriteLine($"Результат A * B = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Сначала введите A и B.");
                    }
                }
                else if (choice == "6")
                {
                    // Операция деления
                    if (isASet && isBSet)
                    {
                        if (b != 0)
                        {
                            double result = a / b;
                            Console.WriteLine($"Результат A / B = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Сначала введите A и B.");
                    }
                }
            }
        }
    }
}
