using System;
using System.Xml.Linq;
using CustomTimer.EventArgsClasses;

namespace CustomTimer
{
    /// <summary>
    /// A custom class for simulating a countdown clock, which implements the ability to send a messages and additional
    /// information about the Started, Tick and Stopped events to any types that are subscribing the specified events.
    /// - When creating a CustomTimer object, it must be assigned:
    ///     - name (not null or empty string, otherwise ArgumentException will be thrown);
    ///     - the number of ticks (the number must be greater than 0 otherwise an exception will throw an ArgumentException).
    /// - After the timer has been created, it should fire the Started event, the event should contain information about
    /// the name of the timer and the number of ticks to start.
    /// - After starting the timer, it fires Tick events, which contain information about the name of the timer and
    /// the number of ticks left for triggering, there should be delays between Tick events, delays are modeled by Thread.Sleep.
    /// - After all Tick events are triggered, the timer should start the Stopped event, the event should contain information about
    /// the name of the timer.
    /// </summary>
    public class Timer
    {
        private readonly string timerName;
        private int ticks;

        /// <summary>
        /// Initializes a new instance of the <see cref="Timer"/> class.
        /// </summary>
        /// <param name="timerName">Name.</param>
        /// <param name="ticks">Ticks.</param>
        public Timer(string timerName, int ticks)
        {
            if (string.IsNullOrEmpty(timerName))
            {
                throw new ArgumentException("Can't be null or empty.", nameof(timerName));
            }

            if (ticks <= 0)
            {
                throw new ArgumentException("The number must be greater than 0.", nameof(ticks));
            }

            this.timerName = timerName;
            this.ticks = ticks;
            this.Started = null;
            this.Tick = null;
            this.Stopped = null;
        }

        public event EventHandler<StartedEventArgs>? Started;

        public event EventHandler<TickEventArgs>? Tick;

        public event EventHandler<StoppedEventArgs>? Stopped;

        public void Start()
        {
            this.OnStarted(new (this.timerName, this.ticks));

            while (this.ticks > 0)
            {
                this.ticks--;
                this.OnTick(new (this.timerName, this.ticks));
                Thread.Sleep(100);
            }

            this.OnStopped(new (this.timerName));
        }

        protected virtual void OnStarted(StartedEventArgs e) => this.Started?.Invoke(this, e);

        protected virtual void OnTick(TickEventArgs e) => this.Tick?.Invoke(this, e);

        protected virtual void OnStopped(StoppedEventArgs e) => this.Stopped?.Invoke(this, e);
    }
}
