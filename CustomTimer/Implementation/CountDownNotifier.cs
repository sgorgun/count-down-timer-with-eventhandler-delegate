using System;
using CustomTimer.Interfaces;

namespace CustomTimer.Implementation
{
    /// <inheritdoc/>
    public class CountDownNotifier : ICountDownNotifier
    {
        /// <inheritdoc/>
        public void Init(Action<string, int> startDelegate, Action<string> stopDelegate, Action<string, int> tickDelegate)
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