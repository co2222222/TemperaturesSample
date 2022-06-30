using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturesSample
{
    internal class TemperatureConversions
    {
        public static double ToCelsius(double Fahrenheit)
        {
            double celsius = (Fahrenheit - 32) * 5 / 9;
            return Math.Round(celsius,2);
        }

        public static double ToFahrenheit(double celsius)
        {
            double Fahrenheit = ((celsius * 9) / 5) + 32;
            return Math.Round(Fahrenheit,2);
        }

    }
}
