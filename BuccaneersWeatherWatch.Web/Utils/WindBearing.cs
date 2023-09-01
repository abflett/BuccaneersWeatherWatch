using System.Runtime.Intrinsics.X86;

namespace BuccaneersWeatherWatch.Web.Utils
{
    public static class WindBearing
    {
        public static string GetDirectionFromDegree(double degree)
        {
            string direction = "";

            if ((degree >= 348.75 && degree <= 361.00) || (degree >= 0.00 && degree <= 11.24))
            {
                direction = "N";
            }

            if (degree >= 11.25 && degree <= 33.74)
            {
                direction = "NNE";
            }

            if (degree >= 33.75 && degree <= 56.24)
            {
                direction = "NE";
            }

            if (degree >= 56.25 && degree <= 78.74)
            {
                direction = "ENE";
            }

            if (degree >= 78.75 && degree <= 101.24)
            {
                direction = "E";
            }

            if (degree >= 101.25 && degree <= 123.74)
            {
                direction = "ESE";
            }

            if (degree >= 123.75 && degree <= 146.24)
            {
                direction = "SE";
            }

            if (degree >= 146.25 && degree <= 168.74)
            {
                direction = "SSE";
            }

            if (degree >= 168.75 && degree <= 191.24)
            {
                direction = "S";
            }

            if (degree >= 191.25 && degree <= 213.74)
            {
                direction = "SSW";
            }

            if (degree >= 213.75 && degree <= 236.24)
            {
                direction = "SW";
            }

            if (degree >= 236.25 && degree <= 258.74)
            {
                direction = "WSW";
            }

            if (degree >= 258.75 && degree <= 281.24)
            {
                direction = "W";
            }

            if (degree >= 281.25 && degree <= 303.74)
            {
                direction = "WNW";
            }

            if (degree >= 303.75 && degree <= 326.24)
            {
                direction = "NW";
            }

            if (degree >= 326.25 && degree <= 348.74)
            {
                direction = "NNW";
            }

            if(string.IsNullOrWhiteSpace(direction))
            {
                direction = "NA";
            }

            return direction;
        }
    }
}
