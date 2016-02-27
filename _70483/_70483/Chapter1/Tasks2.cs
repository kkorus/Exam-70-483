using System;
using System.Threading.Tasks;

namespace _70483.Chapter1
{
    public class Tasks2
    {
        public static void Run()
        {
            Task<int> t = Task.Run(() => 42);

            // Attempting to read the Result property will wait until the Task is finished before continuing.
            Console.WriteLine(t.Result);    //  Displays 42
        }
    }
}