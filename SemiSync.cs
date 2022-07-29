namespace SemiSync
{
    public class SemiSync
    {
        private static async Task HandleAsync()
        {
            Console.WriteLine("Run");
            await Task.Delay(1000);
            Console.WriteLine("Exit");
        }
        static async Task Main()
        {
            Task t = HandleAsync();
            if (await Task.WhenAny(t, Task.Delay(5000)) == t)
            {
                Console.WriteLine("It`s Ok");
            }
            else
            {
                Console.WriteLine("Bad. Time Out");
            }
            Console.WriteLine("Done");
        }
    }
}