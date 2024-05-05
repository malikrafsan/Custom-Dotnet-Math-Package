namespace MathPackage
{
    public class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Modulus(int a, int b)
        {
            return a % b;
        }

        public static int Power(int a, int b)
        {
            return (int)System.Math.Pow(a, b);
        }

        public static int Factorial(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        public static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        public static int Abs(int a)
        {
            return a < 0 ? -a : a;
        }

        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        public static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }

        public static int Sum(int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }

        public static int Product(int[] values)
        {
            int product = 1;
            foreach (int value in values)
            {
                product *= value;
            }
            return product;
        }

        public static int Average(int[] values)
        {
            return Sum(values) / values.Length;
        }

        public static int Median(int[] values)
        {
            System.Array.Sort(values);
            if (values.Length % 2 == 0)
            {
                return (values[values.Length / 2 - 1] + values[values.Length / 2]) / 2;
            }
            else
            {
                return values[values.Length / 2];
            }
        }

        public static int Mode(int[] values)
        {
            System.Collections.Generic.Dictionary<int, int> counts = new System.Collections.Generic.Dictionary<int, int>();
            foreach (int value in values)
            {
                if (counts.ContainsKey(value))
                {
                    counts[value]++;
                }
                else
                {
                    counts[value] = 1;
                }
            }
            int mode = 0;
            int maxCount = 0;
            foreach (System.Collections.Generic.KeyValuePair<int, int> pair in counts)
            {
                if (pair.Value > maxCount)
                {
                    mode = pair.Key;
                    maxCount = pair.Value;
                }
            }
            return mode;
        }

        public static int Range(int[] values)
        {
            int min = values[0];
            int max = values[0];
            foreach (int value in values)
            {
                min = Min(min, value);
                max = Max(max, value);
            }
            return max - min;
        }

        public static int Variance(int[] values)
        {
            int sum = 0;
            int average = Average(values);
            foreach (int value in values)
            {
                sum += (value - average) * (value - average);
            }
            return sum / values.Length;
        }

        public static int StandardDeviation(int[] values)
        {
            return (int)System.Math.Sqrt(Variance(values));
        }

        public static int Ceil(double value)
        {
            return (int)System.Math.Ceiling(value);
        }

        public static int Floor(double value)
        {
            return (int)System.Math.Floor(value);
        }

        public static int Round(double value)
        {
            return (int)System.Math.Round(value);
        }

        public static double Sqrt(double value)
        {
            return (double)System.Math.Sqrt(value);
        }

        public static double Exp(double value)
        {
            return (double)System.Math.Exp(value);
        }

        public static double Log(double value, double newBase)
        {
            return (double)System.Math.Log(value, newBase);
        }

        public static double Log10(double value)
        {
            return (double)System.Math.Log10(value);
        }

        public static double Log(double value)
        {
            return (double)System.Math.Log(value);
        }

        public static double Sin(double value)
        {
            return (double)System.Math.Sin(value);
        }

        public static double Cos(double value)
        {
            return (double)System.Math.Cos(value);
        }

        public static double Tan(double value)
        {
            return (double)System.Math.Tan(value);
        }

        public static double ASin(double value)
        {
            return (double)System.Math.Asin(value);
        }

        public static double ACos(double value)
        {
            return (double)System.Math.Acos(value);
        }

        public static double ATan(double value)
        {
            return (double)System.Math.Atan(value);
        }

        public static double ATan2(double y, double x)
        {
            return (double)System.Math.Atan2(y, x);
        }

        public static double Sinh(double value)
        {
            return (double)System.Math.Sinh(value);
        }

        public static double Cosh(double value)
        {
            return (double)System.Math.Cosh(value);
        }

        public static double Tanh(double value)
        {
            return (double)System.Math.Tanh(value);
        }

    }
}
