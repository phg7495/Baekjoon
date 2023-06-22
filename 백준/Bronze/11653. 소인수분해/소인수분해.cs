using System;
using static System.Console;

namespace Factorization
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string N = ReadLine();
            int Num = Convert.ToInt32(N);

            if (Num != 1)
            {
                for (int i = 2; i <= Num; i++)
                {
                    while (true)
                    {
                        if (Num % i == 0)
                        {
                            WriteLine(i);
                            Num = Num / i;
                        }
                        else
                            break;
                    }
                }
            }
            else
                WriteLine();
        }
    }
}