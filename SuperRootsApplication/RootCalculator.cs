using System;

namespace SuperRootsApplication
{
    public class RootCalculator
    {
        public double Sqrt(double x, int precision = 15)
        {
            return Math.Round(Math.Sqrt(x), precision);
        }
        public Tuple<double, double> ISqrt(double real, double imaginary, int precision = 15)
        {
            double r = Math.Sqrt(real * real + imaginary * imaginary);
            double cos = real / r;
            double f = Math.Acos(cos);
            f = f / 2;
            return new Tuple<double, double>(
                Math.Round(Math.Pow(r, 0.5f) * Math.Cos(f), precision),
                Math.Round(Math.Pow(r, 0.5f) * Math.Sin(f), precision));
        }
        public string ANALRoot()
        {
            return "";
        }

    }
}
