namespace LAB5
{
    internal class Program
    {
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Task1()
        {
            Console.WriteLine("=== 1 завдання ===\n");
            Console.WriteLine(IsEven(5));
            Console.WriteLine(IsEven(6));
            Console.WriteLine("==================\n");
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static void Task2()
        {
            Console.WriteLine("=== 2 завдання ===\n");
            Console.WriteLine(Sum(5,10));
            Console.WriteLine(Sum(2,3,4));
            Console.WriteLine(Sum(2.5,3.1));
            Console.WriteLine("==================\n");
        }
        public static int Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return 0;
        }
        public static void Task3()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("=== 3 завдання ===\n");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("==================\n");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
