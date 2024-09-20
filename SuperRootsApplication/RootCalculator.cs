using System;
using System.Collections.Generic;
using System.Security.Policy;
namespace SuperRootsApplication
{
    public class RootCalculator
    {
        List<string> specificFunction = new List<string>() {"sin","cos","ln"};
        public static double Sqrt(double x, int precision = 15)
        {
            return Math.Round(Math.Sqrt(x), precision);
        }
        public static Tuple<double, double> ISqrt(double real, double imaginary, int precision = 15)
        {
            double r = Math.Sqrt(real * real + imaginary * imaginary);
            double cos = real / r;
            double f = Math.Acos(cos);
            f = f / 2;
            return new Tuple<double, double>(
                Math.Round(Math.Pow(r, 0.5f) * Math.Cos(f), precision),
                Math.Round(Math.Pow(r, 0.5f) * Math.Sin(f), precision));
        }
        public static double LongSqrt(double x, int precision = 15)
        {
            List<int> ints = new List<int>();
            return 0;
        }

        public static string ANALRoot(string s)
        {
            
            foreach(char i in s)
            {

            }

            return "";
        }

    }
}
