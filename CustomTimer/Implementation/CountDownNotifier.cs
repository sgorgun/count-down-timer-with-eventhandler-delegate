using System;
using CustomTimer.EventArgsClasses;
using CustomTimer.Interfaces;

namespace CustomTimer.Implementation
{
    /// <inheritdoc/>
    public class CountDownNotifier : ICountDownNotifier
    {
        private readonly Timer timer;

        public CountDownNotifier(Timer timer) => this.timer = timer;

        /// <inheritdoc/>
        public void Init(EventHandler<StartedEventArgs>? startHandler, EventHandler<StoppedEventArgs>? stopHandler, EventHandler<TickEventArgs>? tickHandler)
        {
            if (startHandler != null)
            {
                this.timer.Started += startHandler;
            }

            if (stopHandler != null)
            {
                this.timer.Stopped += stopHandler;
            }

            if (tickHandler != null)
            {
                this.timer.Tick += tickHandler;
            }
        }

        /// <inheritdoc/>
        public void Run() => this.timer.Start();
    }
}
