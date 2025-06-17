using System.Text;

class Program
{
    public class BankAccount
    {
        private decimal balance = 0;
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public async Task DepositAsync(decimal amount)
        {
            await semaphore.WaitAsync();
            try
            {
                await Task.Delay(100);
                balance += amount;
                Console.WriteLine($"Поповнення +{amount}");
            }
            finally
            {
                semaphore.Release();
            }
        }

        public async Task WithdrawAsync(decimal amount)
        {
            await semaphore.WaitAsync();
            try
            {
                await Task.Delay(100);
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Зняття -{amount}");
                }
                else
                {
                    Console.WriteLine($"Недостатньо коштів -{amount}");
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        public void ShowMyBalance()
        {
            Console.WriteLine($"Фінальний баланс: {balance}");
        }
    }
    public static async Task Task1()
    {
        BankAccount account1 = new BankAccount();
        await account1.DepositAsync(200);
        await account1.WithdrawAsync(100);
        await account1.DepositAsync(300);
        await account1.WithdrawAsync(50);
        account1.ShowMyBalance();
    }
    public static async Task Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        await Task1();
    }
}