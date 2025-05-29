using System.Text;

namespace LAB7
{
    internal class Program
    {
        public static void Task1()
        {
            Console.WriteLine("=== 1 завдання ===");
            for(int i = 2; i <= 20; i+=2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("===================\n");
        }
        public static void Task2()
        {
            int sum = 0;
            int input;
            Console.WriteLine("=== 2 завдання ===");
            Console.WriteLine("Введіть числa (0 для завершення)");
            while (true)
            {
                Console.Write("Введіть число: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) break;
                sum += input;
            }
            Console.WriteLine($"Сума: {sum}");
            Console.WriteLine("===================\n");
        }
        public static void Task3()
        {
            string password;
            Console.WriteLine("=== 3 завдання ===");
            do
            {
                Console.Write("Введіть пароль: ");
                password = Console.ReadLine();
                if (password != "1234")
                {
                    Console.WriteLine("Пароль невірний!");
                }
            }
            while (password != "1234");
            {
                Console.WriteLine("Доступ дозволено!");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Task1();
            Task2();
            Task3();
        }
    }
}
