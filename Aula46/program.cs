using System;

namespace Aula46
{
    class Calc
    {
        public int soma(params int[] n)
        {
            int s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
        public double soma(params double[] n)
        {
            double s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
        public int fatorial(int n)
        {
            int res;
            if (n <= 1)
            {
                res = 1;
            }
            else
            {
                res = n * fatorial(n - 1);
            }
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            var res = calc.fatorial(3);

            Console.WriteLine(res);
        }
    }
}
