using System.IO.Pipes;
using System.Text;

namespace LAB8
{
    internal class Program
    {
        public static void Task1()
        {
            int[] numbers = { 12, 15, 7, 20, 33, 50, 8, 11, 90, 45 };
            var divisible = numbers.Where(n => n % 3 == 0 || n % 5 == 0);
            int sum = divisible.Sum();
            
            Console.WriteLine("=== 1 завдання===");
            Console.WriteLine(string.Join(", ", divisible));
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.WriteLine("==================\n");
        }
        public static void Task2()
        {
            string[] productNames = { "Хліб", "Молоко", "Яблука", "Сир", "Шоколад", "Кофе", "Чай" };
            double[] productPrices = { 25.5, 32.0, 45.3, 120.0, 80.0, 150.0, 75.5 };

            double averagePrice = productPrices.Average();
            Console.WriteLine("=== 1 завдання===");
            Console.WriteLine($"Середня ціна товарів: {averagePrice:F2}");

            Console.WriteLine("Товари, ціна яких перевищує середню: ");
            for ( int i = 0; i < productNames.Length; i++ )
            {
                if( productPrices[i] > averagePrice )
                {
                    Console.WriteLine($"{productNames[i]} - {productPrices[i]} грн");
                }
            }

            int minIndex = Array.IndexOf(productPrices, productPrices.Min());
            int maxIndex = Array.IndexOf(productPrices, productPrices.Max());
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Task1();
            Task2();
        }
    }
}
