using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb5
{
    public class SeriesCalculator
    {
        public double CalculateWithLoop(double x, double N)
        {
            double result = 1;
            double factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                result += Math.Pow(x, i) / factorial;
            }
            return result;
        }

        public double CalculateWithRecursion(double x, double N)
        {
            return CalculateRecursively(x, N, 1, 1, 1);
        }

        private double CalculateRecursively(double x, double N, int i, double factorial, double result)
        {
            if (i > N)
            {
                return result;
            }
            factorial *= i;
            result += Math.Pow(x, i) / factorial;
            return CalculateRecursively(x, N, i + 1, factorial, result);
        }
    }
}
