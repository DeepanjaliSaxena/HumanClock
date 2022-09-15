using System;

namespace HumanClock
{
    /// <summary>
    /// Converts the digital time to human friendly word time.
    /// </summary>
    interface IHumanFriendlyClock
    {
        /// <summary>
        /// Converts DateTime time input into human friendly words.
        /// </summary>
        /// <param name="inputTime">Datetime value of value input by user.</param>
        /// <returns>Returns time in human friendly words.</returns>
        public string GetHumanFriendlyTime(DateTime inputTime);
    }
}
