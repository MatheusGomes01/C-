using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseExtensionsMethods.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisOnj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisOnj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours" ;
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
