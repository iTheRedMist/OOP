using System.Runtime.ConstrainedExecution;

namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }


        private static void Task1()
        {
            int user_age = 20;
            string UserName = "Андрій";
            Console.WriteLine("Привіт, " + UserName + "! Твій вік: " + user_age );
        }
        private static void Task2()
        {
            //int int = 10; // int не можна використовувати як ім'я змінної
            //string class = "Hi"; // class - зарезервоване слово
            //bool new = true; // new - зарезервоване слово
            //Console.Writeline(int + " " + class + " " + new);
            // правильно буде:
            int number = 10;
            string message = "Ні";
            bool type = true;
            Console.WriteLine(number + " " + message + " " + type);
        }
        private static void Task3()
        {
            string name = "Анна"; // створюємо змінну name з ім'ям Анна, тип данних string
            int age = 25; // створюємо змінну age зі значенням 25, тип данних int
            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age); // виводимо у консоль повідомлення "Привіт, Анна! Твій вік: 25)
        }
    }
}
