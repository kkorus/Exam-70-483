using System;
using System.Threading;

namespace _70483.Chapter1
{
    public class Threads6
    {
        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Run()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            // If you run this application with the IsBackground property set to true, the application exits immediately. 
            // If you set it to false (creating a foreground thread), the application prints the ThreadProc message ten times.
            t.IsBackground = false;

            t.Start();
        }
    }
}