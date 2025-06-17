using System.Text;

class Program
{
    class Transport
    {
        public string Name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт рухається...");
        }
    }
    class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Автомобіль рухається.");
        }
    }
    class Bicycle : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Велосипед рухається.");
        }
    }
    class Train : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Потяг рухається.");
        }
    }
    public static void Task1()
    {
        Transport[] transports = {
            new Car { Name = "Ford" },
            new Bicycle { Name = "BMX" },
            new Train { Name = "Kawasaki" }
        };
        Console.WriteLine("Транспортні засоби:");
        foreach (Transport i in transports)
        {
            i.Move();
        }
    }
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Робочий працює.");
        }
    }
    class Programmer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Програміст програмує.");
        }
    }
    class Designer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Дизайнер дизайне.");
        }
    }
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Менеджер керує.");
        }
    }
    public static void Task2()
    {
        List<Employee> employees = new List<Employee>
        {
            new Programmer(),
            new Designer(),
            new Manager()
        };
        Console.WriteLine("Робітники:");
        foreach (Employee e in employees)
        {
            e.Work();
        }
    }
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("===1 завдання ===");
        Task1();
        Console.WriteLine("===2 завдання ===");
        Task2();
    }
}