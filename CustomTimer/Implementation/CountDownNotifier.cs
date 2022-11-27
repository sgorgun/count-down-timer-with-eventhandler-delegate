using System;
using CustomTimer.EventArgsClasses;
using CustomTimer.Interfaces;

namespace CustomTimer.Implementation
{
    /// <inheritdoc/>
    public class CountDownNotifier : ICountDownNotifier
    {
        /// <inheritdoc/>
        public void Init(EventHandler<StartedEventArgs>? startHandler, EventHandler<StoppedEventArgs>? stopHandler, EventHandler<TickEventArgs>? tickHandler)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc/>
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
