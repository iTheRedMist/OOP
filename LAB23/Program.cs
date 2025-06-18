using System;
using System.Text;

class Program
{
    public class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new();
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
        }

        public void Log(string msg)
        {
            Console.WriteLine($"[{DateTime.Now}] {msg}");
        }
    }

    static void Task1()
    {
        var logger1 = Logger.Instance;
        var logger2 = Logger.Instance;
        logger1.Log("Перше повідомлення");
        logger2.Log("Друге повідомлення");
        Console.WriteLine($"logger1 і logger2 - однаковий екземпляр? {ReferenceEquals(logger1, logger2)}");
        Console.WriteLine();
    }

    public interface INotification
    {
        void Send(string message);
    }
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push: {message}");
        }
    }
    public static class NotificationFactory
    {
        public static INotification? Create(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SMSNotification(),
                "push" => new PushNotification(),
                _ => null
            };
        }
    }
    static void Task2()
    {
        Console.Write("Оберіть тип повідомлення (email/sms/push): ");
        string type = Console.ReadLine() ?? "";
        var notification = NotificationFactory.Create(type);
        if (notification != null)
        {
            notification.Send("Це тестове повідомлення.");
        }
        else
        {
            Console.WriteLine("Невідомий тип повідомлення.");
        }
        Console.WriteLine();
    }

    public class Computer
    {
        public string CPU { get; set; } = "";
        public string GPU { get; set; } = "";
        public int RAM { get; set; }
        public int SSD { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}GB, SSD: {SSD}GB";
        }
    }
    public class ComputerBuilder
    {
        private Computer _computer = new();

        public ComputerBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }
        public ComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }
        public ComputerBuilder SetRAM(int ram)
        {
            _computer.RAM = ram;
            return this;
        }
        public ComputerBuilder SetSSD(int ssd)
        {
            _computer.SSD = ssd;
            return this;
        }
        public Computer Build()
        {
            return _computer;
        }
    }
    static void Task3()
    {

        var gamingPc = new ComputerBuilder()
            .SetCPU("Intel i9")
            .SetGPU("NVIDIA RTX 4090")
            .SetRAM(64)
            .SetSSD(2000)
            .Build();

        var officePc = new ComputerBuilder()
            .SetCPU("Intel i5")
            .SetGPU("Integrated")
            .SetRAM(16)
            .SetSSD(512)
            .Build();

        Console.WriteLine("Геймерський ПК: " + gamingPc);
        Console.WriteLine("Офісний ПК: " + officePc);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("=== 1 завдання ===");
        Task1();
        Console.WriteLine("=== 2 завдання ===");
        Task2();
        Console.WriteLine("=== 3 завдання ===");
        Task3();
    }
}