using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, N, i;
            double S;
            Console.WriteLine("k = "); k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N = ");  N = Convert.ToInt32(Console.ReadLine());

            S = 0;
            k = N;
            while (k <= 19)
            {
                S += Math.Sqrt(Math.Pow(Math.Sin(k), 2) + Math.Pow(Math.Cos(N / k), 2));
                k++;
            }
            Console.WriteLine($"{Math.Round(S, 2)}");
            S = 0;
            k = N;
            do
            {
                S += Math.Sqrt(Math.Pow(Math.Sin(k), 2) + Math.Pow(Math.Cos(N / k), 2));
                k++;
            } while (k <= 19);
            Console.WriteLine($"{Math.Round(S, 2)}");
            S = 0;
            for (k = N; k <= 19; k++)
            {
                S += Math.Sqrt(Math.Pow(Math.Sin(k), 2) + Math.Pow(Math.Cos(N / k), 2));
            }
            Console.WriteLine($"{Math.Round(S, 2)}");
            S = 0;
            for (k = 19; k >= N; k--)

            {
                S += Math.Sqrt(Math.Pow(Math.Sin(k), 2) + Math.Pow(Math.Cos(N / k), 2));
            }
            Console.WriteLine($"{Math.Round(S, 2)}");
            Console.ReadKey();
        }
    }
}
