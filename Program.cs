using System;
namespace Fermat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckFermat(3,4,5,3);
        }
        static void CheckFermat(int a, int b, int c, int n)
        {
            if (n > 2)
            {
                double sum = Math.Pow(a, n) + Math.Pow(b, n);
                double equal = Math.Pow(c, n);

                if (sum == equal)
                {
                    Console.WriteLine("Holy smokes, Fermat was wrong!");
                }
                else
                {
                    Console.WriteLine("No, that doesn't work.");
                }
            }
            else
            {
                Console.WriteLine("No, that doesn't work.");
            }
        }
    }
}
