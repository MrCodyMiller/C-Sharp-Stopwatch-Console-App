using System;

namespace Practice
{
    partial class Program
    {
        #region Exercise1
        //Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop. We call the start method ﬁrst, and the stop method next. Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan. Display the duration on the console. We should also be able to use a stopwatch multiple times. So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly. We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice.
        #endregion

        public class Messages
        {
            public void StartMessage()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press (S) to start stopwatch");
            }
            public void EndMessage()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press (E) to end stopwatch");
            }
            public void QuitMessage()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press (Q) to quit Application");
                Console.ResetColor();
            }
            public void IncorrectInput()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input");
            }
            public void LineBreak()
            {
                Console.WriteLine();
            }
        }


    }}//Namespace
