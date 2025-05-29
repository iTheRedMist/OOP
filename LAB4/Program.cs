using System.Text;

namespace LAB4
{
    internal class Program
    {
        public static void Task1()
        {
            int age = 25;
            double weight = 72.5;
            char grade = 'A';
            bool student = true;
            string name = "John Cena";
            Console.WriteLine("===1 завдання === \n");
            Console.WriteLine($"Вік: {age}");
            Console.WriteLine($"Вага: {weight}");
            Console.WriteLine($"Оцінка: {grade}");
            Console.WriteLine($"Чи є студентом: {student}");
            Console.WriteLine($"Ім'я: {name}\n");
        }
        public static void Task2()
        {
            Console.WriteLine("===2 завдання === \n");
            while (true)
            {
                Console.WriteLine("Введіть число: ");
                string input = Console.ReadLine();
                try
                {
                    double number = Convert.ToDouble(input);
                    Console.WriteLine($"Ви ввели число: {number}");
                    int parsedNumber = Convert.ToInt32(number);
                    Console.WriteLine($"Його цілочисленна форма: {parsedNumber}");
                    input = Convert.ToString(parsedNumber);
                    Console.WriteLine($"Його рядкова форма: {input}\n");
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ви ввели некоректне значення");
                }
            }
        }
        static void Task3()
        {
            string name;
            int age;
            Console.WriteLine("===3 завдання === \n");
            Console.WriteLine("Введіть ваше ім'я");
            name = Console.ReadLine();
            Console.WriteLine("Введіть ваш вік");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Привіт {name}! Твій вік: {age}\n");
        }
        static void Task4()
        {
            Console.WriteLine("===4 завдання === \n");
            double speed, time, distance;
            Console.WriteLine("Введіть відстань(км): ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть час(год): ");
            time = Convert.ToDouble(Console.ReadLine()) ;
            speed = distance / time;
            Console.WriteLine($"Середня швидкість: {speed} км/год\n");
        }
        static void Task5()
        {
            Console.WriteLine("===5 завдання === \n");
            string str;
            Console.WriteLine("Введіть речення: ");
            str = Console.ReadLine();
            Console.WriteLine($"Довжина: {str.Length} символів");
            Console.WriteLine($"Верхній регістр: {str.ToUpper()}");
            Console.WriteLine($"Замінені пробіли: {str.Replace(" ", "_")}");
            Console.WriteLine($"Перші 5 символів: {str.Substring(0, 5)}\n");

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
