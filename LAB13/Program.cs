using System.Text;

namespace LAB13
{
    class Program
    {
        static int[] Filter(int[] numbers, Predicate<int> predicate)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (predicate(number))
                    result.Add(number);
            }
            return result.ToArray();
        }
        static void task1()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Predicate<int> isEven = n => n % 2 == 0;

            var evenNumbers = Filter(numbers, isEven);

            Console.WriteLine("Парні числа:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        static void OrderStatusChangedHandler(object sender, string status)
        {
            Console.WriteLine($"Статус заказа змінен на: {status}");
        }
        class Order
        {
            public event EventHandler<string> OrderStatusChanged;
            private string status;

            public string Status
            {
                get => status;
                set
                {
                    if (status != value)
                    {
                        status = value;
                        OnOrderStatusChanged(status);
                    }
                }
            }
            protected virtual void OnOrderStatusChanged(string status)
            {
                OrderStatusChanged?.Invoke(this, status);
            }
        }
        static void task2()
        {
            Order order = new Order();
            order.OrderStatusChanged += OrderStatusChangedHandler;
            order.Status = "Отримано";
            order.Status = "Відправлено";
            order.Status = "Доставлено";
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== 1 завдання ===\n");
            task1();
            Console.WriteLine("\n=== 2 завдання ===\n");
            task2();
        }
    }
}
