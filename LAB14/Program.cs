namespace LAB14
{
    class Program
    {
        static void Main()
        {
            
            string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };

            
            Task[] tasks = new Task[fileNames.Length];

            
            for (int i = 0; i < fileNames.Length; i++)
            {
                int fileIndex = i;  
                tasks[i] = Task.Run(() => ProcessFile(fileNames[fileIndex]));
            }

            Task.WhenAll(tasks).Wait();

            Console.WriteLine("Обробка файлів завершена!");
        }

        static void ProcessFile(string fileName)
        {
            int errorCount = 0;

            try
            {
                
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    if (line.Contains("ERROR"))
                    {
                        errorCount++;
                    }
                }

                Console.WriteLine($"Файл {fileName}: знайдено {errorCount} помилок.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при обробці файлу {fileName}: {ex.Message}");
            }
        }
    }

}
