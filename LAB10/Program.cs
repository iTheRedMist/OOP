﻿using System.Text;

namespace LAB10
{
    class Program
    {
        static Queue<string> mortgageApplications = new Queue<string>();

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== МЕНЮ ===");
                Console.WriteLine("1. Залишити заявку");
                Console.WriteLine("2. Обробити першу заявку");
                Console.WriteLine("3. Подивитись пріорітетну заявку");
                Console.WriteLine("4. Подивитись всі заявки");
                Console.WriteLine("5. Розрахувати щомісячний платіж за іпотекою");
                Console.WriteLine("0. Вийти");
                Console.Write("Введіть дію: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddApplication();
                        break;
                    case "2":
                        ProcessApplication();
                        break;
                    case "3":
                        PeekApplication();
                        break;
                    case "4":
                        ShowAllApplications();
                        break;
                    case "5":
                        CalculateMortgage();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Некоректний ввод. Спробуйте ще раз!");
                        break;
                }
            }
        }

        static void AddApplication()
        {
            Console.Write("Введите имя заявщика: ");
            string name = Console.ReadLine();
            mortgageApplications.Enqueue(name);
            Console.WriteLine("Заявка добавлена.");
        }

        static void ProcessApplication()
        {
            if (mortgageApplications.Count > 0)
            {
                string processed = mortgageApplications.Dequeue();
                Console.WriteLine($"Обработана заявка: {processed}");
            }
            else
            {
                Console.WriteLine("Черга порожня.");
            }
        }

        static void PeekApplication()
        {
            if (mortgageApplications.Count > 0)
            {
                Console.WriteLine($"Наступна заявка: {mortgageApplications.Peek()}");
            }
            else
            {
                Console.WriteLine("Черга порожня.");
            }
        }

        static void ShowAllApplications()
        {
            if (mortgageApplications.Count > 0)
            {
                Console.WriteLine("Все заявки в очереди:");
                foreach (string name in mortgageApplications)
                {
                    Console.WriteLine("* " + name);
                }
            }
            else
            {
                Console.WriteLine("Черга порожня.");
            }
        }

        static void CalculateMortgage()
        {
            try
            {
                Console.Write("Введите сумму кредита (P): ");
                decimal P = decimal.Parse(Console.ReadLine());

                Console.Write("Введите годовую процентную ставку (в %): ");
                decimal annualRate = decimal.Parse(Console.ReadLine());

                Console.Write("Введите срок кредита (в годах): ");
                int years = int.Parse(Console.ReadLine());

                decimal r = annualRate / 12 / 100;
                int n = years * 12;

                // Формула іпотечного платежу
                decimal monthlyPayment = P * (r * (decimal)Math.Pow((double)(1 + r), n)) / ((decimal)Math.Pow((double)(1 + r), n) - 1);
                monthlyPayment = Math.Round(monthlyPayment, 2);

                Console.WriteLine($"Щомісячний платіж за іпотекою: {monthlyPayment} грн");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка вводу: " + ex.Message);
            }
        }
    }
}
