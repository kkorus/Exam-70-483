using System;
using System.Threading.Tasks;

namespace _70483.Chapter1
{
    public class Tasks4
    {
        public static void Run()
        {
            var t = Task.Run(() =>
            {
                return 42;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.WriteLine(t.Result);
        }
    }
}