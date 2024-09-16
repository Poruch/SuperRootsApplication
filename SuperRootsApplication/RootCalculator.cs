using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRootsApplication
{
    public class RootCalculator
    {
        public double Sqrt(double x, int precision = 15)
        {
            return Math.Round(Math.Sqrt(x), precision);
        }
        public Tuple<double, double> ISqrt(double real, double imaginary, double n, int precision = 15)
        {
            double r = Math.Sqrt(real * real + imaginary * imaginary);
            double cos = real / r;
            double f = Math.Acos(cos);
            f = f / n;
            return new Tuple<double, double>(
                Math.Round(Math.Pow(r, 1.0 / n) * Math.Cos(f), precision),
                Math.Round(Math.Pow(r, 1.0 / n) * Math.Sin(f), precision));
        }


    }
}
