using System;
using System.Threading.Tasks;

namespace _70483.Chapter1
{
    public class Tasks1
    {
        public static void Run()
        {
            var t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });
        }
    }
}