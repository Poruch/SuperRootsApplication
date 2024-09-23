using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Policy;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression; 

namespace SuperRootsApplication
{
    public class RootCalculator
    {
       
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
            var s1 = Expr.Parse(s);
            var simplified = s1.RationalSimplify(s1);
            string res = simplified.ToString();

            var members = res.Split('+','-');
            foreach (var i in members)
            {
                Console.Write(i);
            }
                if (!(members.Length == 3 || members.Length == 1))
            {
                return "Ош.";
            }
            else if(members.Length == 1)
            {
                int b = members[0].IndexOf("^");
                if (b != -1)
                {
                    return members[0].Substring(0, b) + "   " + members[0];
                }
                else
                    return "Ош.";
            }
            else if (members.Length == 3)
            {
                int b = members[0].IndexOf("^");
                if (b != -1)
                {
                    return members[0].Substring(0, b);
                }
                else
                    return "Ош.";

            }
            return "Ош.";
        }

    }
}
