using System;

namespace CustomTimer.EventArgsClasses
{
    /// <summary>
    /// Arguments class for 'Started' event.
    /// </summary>
    public class StoppedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoppedEventArgs"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        public StoppedEventArgs(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name { get; }
    }
}
