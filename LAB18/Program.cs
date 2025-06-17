using System.Text;

class Program
{
    interface IAnimal
    {
        void Speak();
        void Eat();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Гав!");
        }
        public void Eat()
        {
            Console.WriteLine("Собака їсть.");
        }
    }
    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Мяу!");
        }
        public void Eat()
        {
            Console.WriteLine("Кіт їсть.");
        }
    }
    static void Task1()
    {
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        foreach (IAnimal animal in animals)
        {
            animal.Speak();
            animal.Eat();
        }
    }

    interface IPaymentMethod
    {
        void Pay(decimal amount);
    }

    class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата кредитною картою: {amount}");
        }
    }
    class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через PayPal: {amount}");
        }
    }

    class ApplePay : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через ApplePay: {amount}");
        }
    }

    class Order
    {
        public IPaymentMethod PaymentMethod { get; set; }

        public Order(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Обробка платіжа...");
            PaymentMethod.Pay(amount);
            Console.WriteLine("Платіж завершено.\n");
        }

    }
    static void Task2()
    {
        Order order1 = new Order(new CreditCard());
        order1.ProcessPayment(150);

        Order order2 = new Order(new PayPal());
        order2.ProcessPayment(15);

        Order order3 = new Order(new ApplePay());
        order3.ProcessPayment(120);

    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("=== 1 завдання ===");
        Task1();
        Console.WriteLine("=== 2 завдання ===");
        Task2();
    }
}