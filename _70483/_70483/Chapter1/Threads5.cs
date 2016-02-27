using System;
using System.Threading;

namespace _70483.Chapter1
{
    public class Threads5
    {
        private static void ThreadPoolMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Run()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolMethod), 5);
        }
    }
}