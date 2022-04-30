using System;

namespace CustomTimer.Interfaces
{
    /// <summary>
    /// Represents class to subscribe to the Started, Tick, and Stopped events of the Timer class.
    /// </summary>
    public interface ICountDownNotifier
    {
        /// <summary>
        /// Initializes event handlers.
        /// </summary>
        /// <param name="startHandler">Represents a Start event handler. Can be null.</param>
        /// <param name="stopHandler">Represents a Stop event handler. Can be null.</param>
        /// <param name="tickHandler">Represents a Tick event handler. Can be null.</param>
        void Init(Action<string, int> startHandler, Action<string> stopHandler, Action<string, int> tickHandler);

        /// <summary>
        /// Starts timer.
        /// </summary>
        void Run();
    }
}
