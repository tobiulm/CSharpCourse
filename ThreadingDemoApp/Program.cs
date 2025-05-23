using System;
using System.Threading;

namespace ThreadingDemoApp
{
    internal class Program
    {
        internal static int I = 0;
        public static object LOCKVAR = "";


        static void Main(string[] args)
        {
            Thread[] threads = new Thread[100];
            for (int j = 0; j < threads.GetUpperBound(0); j++)
            {
                threads[j] = new Thread(new ThreadStart(ThreadMethod));
                threads[j].Name = $"Thread {j}";
                threads[j].Start();
            }
            Console.ReadLine();
        }


        internal static void ThreadMethod()
        {
            lock (LOCKVAR)
            {
                string threadName = Thread.CurrentThread.Name ?? "Unknown";
                string threadId = Thread.CurrentThread.ManagedThreadId.ToString();
                string message = $"Thread gestartet:\t{threadName}\t{threadId}\t";
                I++;
                message += $"I = {I}";
                Console.WriteLine(message);
            }
        }
    }
}
