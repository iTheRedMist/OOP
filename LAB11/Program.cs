using System.Text;
using System.Text.RegularExpressions;

namespace LAB11
{
    class Program
    {
        static Queue<string> supportQueue = new Queue<string>();
        static void task1()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n=== МЕНЮ СИСТЕМИ ПІДТРИМКИ ===");
                Console.WriteLine("1. Додати нову заявку");
                Console.WriteLine("2. Обробити першу заявку");
                Console.WriteLine("3. Подивитись першу заявку в черзі");
                Console.WriteLine("4. Переглянути всі заявки в черзі");
                Console.WriteLine("0. Вийти");
                Console.Write("Оберіть дію: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddRequest();
                        break;
                    case "2":
                        ProcessRequest();
                        break;
                    case "3":
                        PeekRequest();
                        break;
                    case "4":
                        ShowAllRequests();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Вихід з програми...");
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void AddRequest()
        {
            Console.Write("Введіть текст заявки: ");
            string request = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(request))
            {
                supportQueue.Enqueue(request);
                Console.WriteLine("Заявку додано до черги.");
            }
            else
            {
                Console.WriteLine("Заявка не може бути порожньою.");
            }
        }

        static void ProcessRequest()
        {
            if (supportQueue.Count > 0)
            {
                string request = supportQueue.Dequeue();
                Console.WriteLine($"Оброблено заявку: {request}");
            }
            else
            {
                Console.WriteLine("Черга порожня. Немає заявок для обробки.");
            }
        }

        static void PeekRequest()
        {
            if (supportQueue.Count > 0)
            {
                Console.WriteLine($"Перша заявка в черзі: {supportQueue.Peek()}");
            }
            else
            {
                Console.WriteLine("Черга порожня.");
            }
        }

        static void ShowAllRequests()
        {
            if (supportQueue.Count > 0)
            {
                Console.WriteLine("Список всіх заявок у черзі:");
                foreach (var req in supportQueue)
                {
                    Console.WriteLine($"- {req}");
                }
            }
            else
            {
                Console.WriteLine("Черга порожня.");
            }
        }



        public static void task2()
        {
            Console.WriteLine("Введіть текст для аналізу:");
            string input = Console.ReadLine();

            string cleanedText = Regex.Replace(input.ToLower(), @"[^\w\s]", "");

            string[] words = cleanedText.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                    wordCounts[word]++;
                else
                    wordCounts[word] = 1;
            }

            var sortedWords = wordCounts.OrderByDescending(pair => pair.Value);

            Console.WriteLine("\nСтатистика слів:");
            foreach (var pair in sortedWords)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            task1();
            task2();
        }
    }
}


