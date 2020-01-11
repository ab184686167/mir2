using System;
using System.Collections.Generic;
using System.Threading;
using Server.MirEnvir;
namespace Server.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += CurrentDomainOnProcessExit;
            Console.CancelKeyPress += ConsoleOnCancelKeyPress;
            Envir.Main.Start();
            var messageQueue = MessageQueue.Instance;
            while (true)
            {
                while (messageQueue.MessageLog.TryDequeue(out var msg))
                {
                    Console.Write($"[{DateTime.Now}][Message]:{msg}");
                }
                Thread.Sleep(10);
            }
        }

        private static void ConsoleOnCancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("^C Pressed... Stop Server...");
            Envir.Main.Stop();
            Environment.Exit(0);
        }

        private static void CurrentDomainOnProcessExit(object sender, EventArgs e)
        {
            
            Console.WriteLine("Exiting...");
            Envir.Main.Stop();
            //Environment.Exit(-1);
        }
    }
}
