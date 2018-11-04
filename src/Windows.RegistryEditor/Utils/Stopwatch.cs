using System;

using SW = System.Diagnostics.Stopwatch;

namespace Windows.RegistryEditor.Utils
{
    public class Stopwatch
    {
        public event Action Started;
        public event Action<TimeSpan> Stopped;

        protected virtual void OnStarted() => Started?.Invoke();
        protected virtual void OnStopped(TimeSpan e) => Stopped?.Invoke(e);


        private SW watch;

        public Stopwatch()
        {
            watch = new SW();
        }

        public TimeSpan Elapsed => watch.Elapsed;

        public bool IsRunning => watch.IsRunning;

        public Stopwatch Start(bool reset = false)
        {
            if (reset) watch.Reset();

            watch.Start();
            OnStarted();

            return this;
        }

        public TimeSpan Stop()
        {
            if (!watch.IsRunning)
                throw new InvalidOperationException("Stopwatch isn't running");

            watch.Stop();
            OnStopped(Elapsed);

            return Elapsed;
        }
    }
}
