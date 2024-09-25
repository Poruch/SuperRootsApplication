using System;
using System.Collections.Generic;
using System.Linq;
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
            if(r == 0)
                return Tuple.Create(real, imaginary);
            double cos = real / r;
            double f = Math.Acos(cos);
            f = f / 2;
            return new Tuple<double, double>(
                Math.Round(Math.Pow(r, 0.5f) * Math.Cos(f), precision),
                Math.Round(Math.Pow(r, 0.5f) * Math.Sin(f), precision));
        }
        /// <summary>
        /// don`t work
        /// </summary>
        /// <param name="x"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static double LongSqrt(double x, int precision = 15)
        {
            List<int> ints = new List<int>();
            return 0;
        }
        public static string ANALRoot(string s, int precision = 15)
        {
            Expr s1;
            try
            {
                s1 = Expr.Parse(s);
            }
            catch
            {
                return SuperRootCalculator.errorFormat[SuperRootCalculator.NumberLanguage];
            }
            var simplified = s1.RationalSimplify(s1);
            string res = simplified.ToString();

            var members = res.Split('+', '-');
            foreach (var i in members)
            {
                Console.Write(i);
            }
            if (!(members.Length == 1))
            {
                return SuperRootCalculator.errorCalculate[SuperRootCalculator.NumberLanguage];
            }
            else if (members.Length == 1)
            {
                string result = "|";
                var mem = members[0].Split('*');
                string others = "sqrt(";
                bool sqr = false;
                bool oth = false;
                foreach (var item in mem)
                {
                    int b = item.IndexOf("^");
                    bool isDigit = int.TryParse(item, out int b2);
                    if (b != -1)
                    {
                        if (int.TryParse(item.Substring(b + 1), out int z))
                        {
                            if (z % 2 == 0)
                            {
                                if (z != 2)
                                {
                                    result += item.Substring(0, b) + $"^{z / 2}*";
                                    sqr = true;
                                }
                                else
                                {
                                    result += item.Substring(0, b) + "*";
                                    sqr = true;
                                }
                            }
                            else
                            {
                                others += item + "*";
                                oth = true;
                            }
                        }
                        else
                        {
                            result += item.Substring(0, b) + "*";
                            sqr = true;
                        }

                    }
                    else if (!isDigit)
                    {
                        others += item + "*";
                        oth = true;
                    }
                    else if (isDigit)
                    {
                        result = Sqrt(b2, precision).ToString() + "*" + result;
                        sqr = true;
                    }

                }
                if (result[result.Length - 1] == '|')
                {
                    if(sqr)
                    result = result.Substring(0, result.IndexOf('*'));                    
                }
                else
                result = result.Substring(0,result.Length-1) +"|";
                others = others.Substring(0, others.Length - 1) + ")";
                if(sqr && oth)
                {
                    return result +"*" + others ;
                }
                else if(sqr && !oth)
                {
                    return result;
                }
                else if (!sqr && oth)
                {
                    return others;
                }

            }
            return SuperRootCalculator.errorCalculate[SuperRootCalculator.NumberLanguage];
        }

    }
}
