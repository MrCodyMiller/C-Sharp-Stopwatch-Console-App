using System;

namespace Practice
{
    partial class Program
    {
        public class Stopwatch
        {
            private DateTime _start;
            private DateTime _end;
            private bool _running;

          public void Start()
            {
                if (_running)
                    throw new InvalidOperationException("Stopwatch is already running...");
                _start = DateTime.UtcNow;
                _running = true;
                Console.WriteLine("Stopwatch Started...");
            }
            public void Stop()
            {
                if (!_running)
                    throw new InvalidOperationException("Stopwatch has not yet been started...");
                _end = DateTime.UtcNow;
                _running = false;
                Console.WriteLine("Stopwatch Ended...");
            }

            public TimeSpan Interval()
            {
                return _end - _start;
            }

        }
    }
}//Namespace
