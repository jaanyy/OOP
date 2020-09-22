using System;
class Lab2p4
{
    static void Main()
    {
        int n = 0;
        n = Convert.ToInt32(Console.ReadLine());
        bool[] primes = new bool[n];
        for (int i = 0; i < n; ++i)
        {
            primes[i] = true;
        }
        primes[0] = primes[1] = false;
        int p = 2, j = 1;
        for(int i = 0; i < n; ++i)
        {
            if (primes[i] == true)
            {

                Console.Write($"{i} ");
                p = i;
                j = 0;
                double temp = ((double)n / (double)p);
                while (j < Math.Ceiling(temp) )
                {
                    primes[p * j] = false;
                    
                    ++j;
                }
            }
        }

        Console.ReadKey();
    }
}
