using System;

namespace Surname_LR3_project
{
    class Program
    {
        // Переменные для хранения данных
        static double a = 0;
        static double b = 0;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Меню (Вариант 3) ---");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести В");
                Console.WriteLine("3. Выполнить операцию '*' (A * B)");
                Console.WriteLine("4. Выполнить операцию '/' (A / B)");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт меню: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            InputA();
                            break;
                        case 2:
                            InputB();
                            break;
                        case 3:
                            Multiply();
                            break;
                        case 4:
                            Divide();
                            break;
                        case 0:
                            Console.WriteLine("Выход из программы.");
                            break;
                        default:
                            Console.WriteLine("Неверный выбор, попробуйте снова.");
                            break;
                    }
                }
            } while (choice != 0);
        }

        // Задание 1: Ввод числа А
        static void InputA()
        {
            Console.Write("Введите значение A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Значение A сохранено: {a}");
        }

        // Задание 2: Ввод числа В
        static void InputB()
        {
            Console.Write("Введите значение B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Значение B сохранено: {b}");
        }

        // Задание 3: Умножение
        static void Multiply()
        {
            double result = a * b;
            Console.WriteLine($"Результат умножения ({a} * {b}) = {result}");
        }

        // Задание 4: Деление
        static void Divide()
        {
            if (b != 0)
            {
                double result = a / b;
                Console.WriteLine($"Результат деления ({a} / {b}) = {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
            }
        }
    }
}
