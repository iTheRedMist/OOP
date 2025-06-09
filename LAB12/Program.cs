using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace LAB12
{
    internal class Program
    {
        struct Point
        {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - this.X, 2) + Math.Pow(other.Y - this.Y, 2));
        }
    }
    static void task1()
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(0, 0);
            Console.WriteLine(p1.DistanceTo(p2));
        }

    class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public string Color;
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, int year)
        : this(brand, model)
        {
            Year = year;
        }
        public Car(string brand, string model, int year, string color)
        : this(brand, model, year)
        {
            Color = color;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Марка: " + Brand);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Рік: " + (Year != 0 ? Year.ToString() : "Невідомо"));
            Console.WriteLine("Колір: " + (!string.IsNullOrEmpty(Color) ? Color : "Невідомо"));
        }
    }

    static void task2()
        {
            Car car1 = new Car("Ford", "Scorpio");
            Car car2 = new Car("Toyota", "Scala", 2019);
            Car car3 = new Car("Renault", "Traffic", 2006, "Yellow");

            Console.WriteLine("Інформація про перший автомобіль:");
            car1.ShowInfo();
            Console.WriteLine("\nІнформація про другий автомобіль:");
            car2.ShowInfo();
            Console.WriteLine("\nІнформація про третій автомобіль:");
            car3.ShowInfo();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            task1();
            task2();
        }
    }
}
