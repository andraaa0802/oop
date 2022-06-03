using System;

namespace LR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, contor = 0;

            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            int[] l = new int[n];
            int[] r = new int[n];

            string[] buffer = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(buffer[i]);

            int min = v[n - 1];
            int max = v[0];

            for (int i = 0; i < n; i++)
            {
                if (v[i] >= max)
                {
                    max = v[i];
                    l[i] = max;
                }
            }

            for (int i = n - 1; i >= 0; i--)
                if (v[i] <= min)
                {
                    min = v[i];
                    r[i] = min;
                }

            for (int i = 1; i < n - 1; i++)
                if (v[i] == l[i] && l[i] == r[i])
                    contor++;

            Console.WriteLine(contor);
        }
    }
}
