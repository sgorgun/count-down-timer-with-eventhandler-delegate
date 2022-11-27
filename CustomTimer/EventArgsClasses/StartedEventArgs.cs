using System;

namespace CustomTimer.EventArgsClasses
{
    /// <summary>
    /// Arguments class for 'Started' event.
    /// </summary>
    public class StartedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartedEventArgs"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="ticks">Ticks.</param>
        public StartedEventArgs(string name, int ticks)
        {
            this.Name = name;
            this.Ticks = ticks;
        }

        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets ticks.
        /// </summary>
        public int Ticks { get; }
    }
}
