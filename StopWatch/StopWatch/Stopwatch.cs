using System;

namespace StopWatch
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _startTime = DateTime.MinValue;
        private DateTime _endTime = DateTime.MinValue;

        public void Stop() 
        {
            if (_startTime == DateTime.MinValue)
                throw new InvalidOperationException("Must start stopwatch first");

            _endTime = DateTime.Now;
            Console.WriteLine("Stopped.");
            _duration = _startTime - _endTime;
            Console.WriteLine("DURATION: " + _duration);
            Reset();
        }
        public void Start()
        {
            if (_startTime != DateTime.MinValue)
                throw new InvalidOperationException("Stopwatch already started.");

            _startTime = DateTime.Now;
            Console.WriteLine("Starting.");
        }

        private void Reset()
        {
            _endTime = DateTime.MinValue;
            _startTime = DateTime.MinValue;
        }
    }
}
