using System;
using System.Threading;

namespace _70483.Chapter1
{
    public class Threads1
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);

                // Why the Thread.Sleep(0)? It is used to signal to Windows that this thread is finished. 
                // Instead of waiting for the whole time-slice of the thread to finish, it will immediately switch to another thread.
                Thread.Sleep(0);
            }
        }
        public static void Run()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Main thread: Do some work. " + i);
                Thread.Sleep(0);
            }

            // The Thread.Join method is called on the main thread to let it wait until the other thread finishes.
            t.Join();
        }
    }
}