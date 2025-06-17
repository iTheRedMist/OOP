using System.Text;

class Program
{
    class Container<T>
    {
        public T Value { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Значення: {Value}, Тип: {typeof(T)}");
        }
    }

    static void Task1()
    {
        Container<int> intContainer = new Container<int> { Value = 42 };
        Container<string> stringContainer = new Container<string> { Value = "Привіт" };

        intContainer.ShowInfo();
        stringContainer.ShowInfo();
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Масив не повинен бути порожнім");
        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }

    static void Task2()
    {
        int[] intArray = { 1, 3, 2, 10, 5 };
        double[] doubleArray = { 1.5, 3.7, 2.2, 10.1, 5.0 };
        string[] stringArray = { "apple", "orange", "banana", "pear" };
        Console.WriteLine($"Максимум в intArray: {FindMax(intArray)}");
        Console.WriteLine($"Максимум в doubleArray: {FindMax(doubleArray)}");
        Console.WriteLine($"Максимум в stringArray: {FindMax(stringArray)}");
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("=== 1 завдання === ");
        Task1();
        Console.WriteLine("=== 2 завдання === ");
        Task2();
    }
}