namespace BuccaneersWeatherWatch.Web.Utils
{
    public static class TimeConversion
    {
        public static DateTime UnixToLocalTime(int unixTimestamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(dateTimeOffset, localTimeZone);

            return localTime.DateTime;
        }

        public static DateTime UnixToUtcTime(int unixTimestamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            return dateTimeOffset.UtcDateTime;
        }
    }
}
