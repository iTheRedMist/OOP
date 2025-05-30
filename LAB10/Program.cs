namespace LAB10
{
    class Program
    {
        static Queue<string> mortgageApplications = new Queue<string>();

        public static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== МЕНЮ ===");
                Console.WriteLine("1. Оставить заявку");
                Console.WriteLine("2. Обработать первую заявку");
                Console.WriteLine("3. Просмотреть приоритетную заявку");
                Console.WriteLine("4. Просмотреть все заявки");
                Console.WriteLine("5. Рассчитать ежемесячный платёж по ипотеке");
                Console.WriteLine("0. Выйти");
                Console.Write("Выберите действие: ");
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
                        Console.WriteLine("Некорректный ввод. Попробуйте ещё раз...");
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
                Console.WriteLine("Очередь пуста.");
            }
        }

        static void PeekApplication()
        {
            if (mortgageApplications.Count > 0)
            {
                Console.WriteLine($"Следующая заявка: {mortgageApplications.Peek()}");
            }
            else
            {
                Console.WriteLine("Очередь пуста.");
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
                Console.WriteLine("Очередь пуста.");
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

                Console.WriteLine($"Ежемесячный платёж, составляет: {monthlyPayment} грн");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }
        }
    }
}
