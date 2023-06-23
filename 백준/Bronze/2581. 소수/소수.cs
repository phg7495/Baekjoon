using System;
using static System.Console;

namespace PrimeNumber2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string MCount = ReadLine();
            string NCount = ReadLine();

            int M = Convert.ToInt32(MCount);
            int N = Convert.ToInt32(NCount);

            int SumPrimeNumber = 0;
            int MinPrimeNumber = 0;

            int Minvalid = 0;

            for (int i = M; i <= N; i++)
            {
                int valid = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        valid = 0;
                        break;
                    }
                }
                if (i == 1)
                    valid = 0;

                if (valid == 1)
                {
                    SumPrimeNumber += i;
                    if (Minvalid == 0)
                    {
                        MinPrimeNumber = i;
                        Minvalid = 1;
                    }
                }
            }

            if (Minvalid == 1)
            {
                WriteLine(SumPrimeNumber);
                WriteLine(MinPrimeNumber);
            }
            else
                WriteLine(-1);
        }
    }
}