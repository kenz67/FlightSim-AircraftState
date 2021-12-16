using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftState.Services.Helpers
{
    public static class Formatter
    {
        public static string GetLatLong(double value, bool lat)
        {
            string result;

            int iPart = (int)value;

            if (iPart < 0)
            {
                result = lat ? "S" : "W";
            }
            else
            {
                result = lat ? "N" : "E";
            }

            var x = (value - Math.Truncate(value)) * 60;

            result += $"{Math.Abs(iPart)}{(Char)176} {Math.Abs(x):N2}'";

            return result;
        }
    }
}
