using System;
using System.Text;

namespace LAB6
{
    internal class Program
    {
        public static void Task1()
        {
            Console.WriteLine("=== 1 завдання === \n");
            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 1)
            {
                Console.WriteLine("Число не є парним");
            }
            else
            {
                Console.WriteLine("Число парне!");
            }
            Console.WriteLine("=================== \n");
        }
        public static void Task2()
        {
            Console.WriteLine("=== 2 завдання === \n");
            Console.Write("Введіть оцінку: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade < 60)
            {
                Console.WriteLine("Ваша оцінка F!");
            }
            else if (grade < 75)
            {
                Console.WriteLine("Ваша оцінка C!");
            }
            else if (grade < 90)
            {
                Console.WriteLine("Ваша оцінка B!");
            }
            else
            {
                Console.WriteLine("Ваша оцінка A!");
            }
            Console.WriteLine("=================== \n");
        }
        public static void Task3()
        {
            Console.WriteLine("=== 3 завдання === \n");
            Console.Write("Введіть число (1-7): ");
            int weekday = Convert.ToInt32(Console.ReadLine());
            switch (weekday)
            {
                case 1: Console.WriteLine("Понеділок"); break;
                case 2: Console.WriteLine("Вівторок"); break;
                case 3: Console.WriteLine("Середа"); break;
                case 4: Console.WriteLine("Четвер"); break;
                case 5: Console.WriteLine("П'ятниця"); break;
                case 6: Console.WriteLine("Субота"); break;
                case 7: Console.WriteLine("Неділя"); break;
                default: Console.WriteLine("Ви ввели некоректне значення"); break;
            }
            Console.WriteLine("=================== \n");
        }
        public static void Task4()
        {
            Console.WriteLine("=== 4 завдання === \n");
            Console.Write("Введіть марку авто: ");
            string brand = Console.ReadLine();
            switch (brand)
            {
                case "Toyota": Console.WriteLine("Японія"); break;
                case "BMW": Console.WriteLine("Германія"); break;
                case "Tesla": Console.WriteLine("США"); break;
            }
            Console.WriteLine("=================== \n");
        }
        public static void Task5()
        {
            Console.WriteLine("=== 5 завдання === \n");
            Console.Write("Введіть температуру: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            string result = temp >= 0 ? "Погода тепла " : "Погода холодна ";
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("=================== \n");
        }
        public static void Task6()
        {
            Console.WriteLine("=== 6 завдання === \n");
            try
            {
                Console.Write("Введіть перше число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                double div = a / b;
                Console.WriteLine("Результат: " + div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: поділ на нуль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: некоректний формат числа!");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            
        }
    }
}

