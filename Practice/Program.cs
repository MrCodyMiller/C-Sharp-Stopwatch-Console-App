using System;
using System.Threading;


namespace Practice
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var messages = new Messages();
            var stopwatch = new Stopwatch();
            bool quit = true;

            while (quit)
            {
                messages.LineBreak();
                messages.StartMessage();
                messages.EndMessage();
                messages.QuitMessage();
                messages.LineBreak();

                switch (Console.ReadLine().ToUpper())
                {

                    case "S":
                        stopwatch.Start();
                        break;
                    case "E":
                        stopwatch.Stop();
                        Console.WriteLine("Duration: " + stopwatch.Interval().ToString(@"d\:ss\.FF") + " seconds");
                        break;
                    case "Q":
                        quit = false;
                        break;
                    default:
                        messages.IncorrectInput();
                        break;
                }
            }


        }//Main()
    }//Class Program
}//Namespace