using System.Text;
using static Program;

class Program
{
    public class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            set
            {
                if (value < 0 || value > 120)
                    Console.WriteLine("Вік повинен бути в діапазоні від 0 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }
    public static void Task1()
    {
        Student student = new Student();
        student.Name = "Андрій";
        student.Age = 25;
        Console.WriteLine($"Ім'я: {student.Name},\nВік: {student.Age}");
    }

    public class Car
    {
        private int speed;
        public string Speed
        {
            get { return ($"Швидкість автомобіля: {speed} км/г"); }
        }
        public void Accelerate(int increment)
        {
            speed += increment;
        }
        public void Brake(int decrement)
        {
            speed -= decrement;
            if (speed < 0)
            {
                speed = 0;
                Console.WriteLine("Машина стоїть на місці");
            }
        }

    }
    public static void Task2()
    {
        Car auto = new Car();

        auto.Accelerate(50);
        Console.WriteLine(auto.Speed);

        auto.Brake(20);
        Console.WriteLine(auto.Speed);

        auto.Brake(40);
        Console.WriteLine(auto.Speed);


    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("===1 завдання === ");
        Task1();
        Console.WriteLine("===2 завдання === ");
        Task2();
    }

}