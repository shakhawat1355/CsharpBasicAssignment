using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    public class Prob21
    {
        public void DateTimeManipulator()
        {
            // create a new DateTime object with the current date and time
            DateTime currentDate = DateTime.Now;

            // get the day of the month
            int day = currentDate.Day;

            // get the month as a string
            string month = currentDate.ToString("MMMM");

            // add 1 day to the current date
            DateTime tomorrow = currentDate.AddDays(1);

            // subtract 2 hours from the current time
            DateTime twoHoursAgo = currentDate.AddHours(-2);

            // compare two dates
            DateTime date1 = new DateTime(2023, 4, 6);
            DateTime date2 = new DateTime(2023, 4, 7);
            int result = DateTime.Compare(date1, date2);

        }

        public void TimeSpanManipulator()
        {
            // create a new TimeSpan object with a duration of 1 hour, 30 minutes, and 0 seconds
            TimeSpan duration = new TimeSpan(1, 30, 0);

            // get the total number of minutes in the duration
            int totalMinutes = (int)duration.TotalMinutes;

            // add 15 minutes to the duration
            duration = duration.Add(new TimeSpan(0, 15, 0));

            // subtract 30 seconds from the duration
            duration = duration.Subtract(new TimeSpan(0, 0, 30));

            // compare two durations
            TimeSpan duration1 = new TimeSpan(1, 30, 0);
            TimeSpan duration2 = new TimeSpan(2, 0, 0);
            int result = TimeSpan.Compare(duration1, duration2);

        }
    }
}
