using System;
using System.Threading.Tasks;

namespace _70483.Chapter1
{
    public class Tasks3
    {
        public static void Run()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((task) =>
            {
                return task.Result * 2;
            });

            Console.WriteLine(t.Result);    //  Displays 84
        }
    }
}