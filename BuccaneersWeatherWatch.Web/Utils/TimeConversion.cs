namespace BuccaneersWeatherWatch.Web.Utils
{
    public static class TimeConversion
    {
        public static DateTime UnixToLocalTime(int unixTimestamp)
        {
            // Convert Unix timestamp to DateTimeOffset
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);

            // Get the local time zone
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

            // Convert DateTimeOffset to local time
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(dateTimeOffset, localTimeZone);

            Console.WriteLine("Unix Timestamp: " + unixTimestamp);
            Console.WriteLine("Local Time: " + localTime);

            return localTime.DateTime;
        }
    }
}
