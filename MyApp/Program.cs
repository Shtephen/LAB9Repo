using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static long Factorial(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "Число должно быть неотрицательным.");
            long result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }
    }
}