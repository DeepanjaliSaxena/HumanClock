using System;

namespace HumanClock
{
    /// <summary>
    /// Converts the digital time to human friendly word time.
    /// </summary>
    public class HumanFriendlyClock : IHumanFriendlyClock
    {
        /// <summary>
        /// Defines the ones and teens digits in words
        /// </summary>
        private static readonly string[] unitValue = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        /// <summary>
        /// Defines the tens digits in words.
        /// </summary>
        private static readonly string[] tensValue = { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty" };

        /// <summary>
        /// Converts DateTime time input into human friendly words.
        /// </summary>
        /// <param name="inputTime">Datetime value of value input by user.</param>
        /// <returns>Returns time in human friendly words.</returns>
        public string GetHumanFriendlyTime(DateTime inputTime)
        {
            int hour = inputTime.Hour > 12 ? inputTime.Hour - 12 : inputTime.Hour;
            int minute = inputTime.Minute;
            string time = string.Empty;

            if (minute == 0)
            {
                time = unitValue[hour] + Constant.OClock;
            }
            else if (minute < 30)
            {
                time = CalculateTime(hour, minute, Constant.Past);
            }
            else if (minute == 30)
            {
                time = Constant.HalfPast + unitValue[hour];
            }
            else if (minute > 30)
            {
                time = CalculateTime((hour + 1), (60 - minute), Constant.To);
            }
            return time;
        }

        /// <summary>
        /// Calculates the time for minutes greater than 30.
        /// </summary>
        /// <param name="hour">Holds the value of hour.</param>
        /// <param name="minute">Holds the value of minute.</param>
        /// <param name="intermediateWord">Holds the intermediate word like past or to.</param>
        /// <returns>Returns the time in word.</returns>
        private static string CalculateTime(int hour, int minute, string intermediateWord)
        {
            string time = string.Empty;
            if (minute < 20)
            {
                time = unitValue[minute] + intermediateWord + unitValue[hour];
            }
            else if (minute >= 20 && minute < 30)
            {
                time = tensValue[minute / 10] + " " + unitValue[minute % 10] + intermediateWord + unitValue[hour];
            }
            return time;
        }
    }
}
