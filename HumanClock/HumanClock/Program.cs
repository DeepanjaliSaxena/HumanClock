using System;

namespace HumanClock
{
    class Program
    {
        public static void Main(string[] args)
        {
            HumanFriendlyClock humanFriendlyClock = new HumanFriendlyClock();

            InputValidator(out DateTime inputTime);
            var result = humanFriendlyClock.GetHumanFriendlyTime(inputTime);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        /// <summary>
        /// Validate the input entered by user.
        /// </summary>
        /// <param name="inputTime">Outputs the time entered by user.</param>
        private static void InputValidator(out DateTime inputTime)
        {
            short inputOption;
            Console.WriteLine(Constant.OptionMessage);
            Console.WriteLine(Constant.Option1);
            Console.WriteLine(Constant.Option2);
            bool error = short.TryParse(Console.ReadLine(), out inputOption);
            while (!error || (inputOption != 1 && inputOption != 2))
            {
                Console.WriteLine(Constant.OptionError);
                error = short.TryParse(Console.ReadLine(), out inputOption);
            }
            if (inputOption == 1)
            {
                inputTime = DateTime.Now;
            }
            else
            {
                Console.WriteLine(Constant.TimeFormatError);
                error = DateTime.TryParse(Console.ReadLine(), out inputTime);
                while (!error)
                {
                    Console.WriteLine(Constant.TimeFormatError);
                    error = DateTime.TryParse(Console.ReadLine(), out inputTime);
                }
            }
        }
    }
}
