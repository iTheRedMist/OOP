using System.Text;

class Program
{
    
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Спить.");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Мяу.");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав.");
        }
    }
    class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Муу.");
        }
    }

    static void Task1()
    {
        List<Animal> animals = new List<Animal>
    {
        new Cat(),
        new Dog(),
        new Cow()
    };
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Sleep();
            Console.WriteLine();
        }
    }

    abstract class PaymentMethod
    {
        public abstract void Pay(decimal amount);

        public void Confirm()
        {
            Console.WriteLine("Платіж підтверджено");
        }
    }
    class CreditCard : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата кредитною карткою на суму {amount} грн.");
            Confirm();
        }
    }
    class PayPal : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через PayPal на суму {amount} грн.");
            Confirm();
        }
    }
    class ApplePay : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через Apple Pay на суму {amount} грн.");
            Confirm();
        }
    }
    static void Task2()
    {
        PaymentMethod payment;
        payment = new CreditCard();
        payment.Pay(1200.75m);
        payment = new PayPal();
        payment.Pay(500.00m);
        payment = new ApplePay();
        payment.Pay(299.99m);
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