using System;
using static System.Console;

namespace PrimeNumber1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string Count = ReadLine();
            int c = Convert.ToInt32(Count);

            string input = ReadLine();
            string[] Number = input.Split(' ');

            int[] num = new int[c];
            for (int i = 0; i < num.Length; i++)
                num[i] = Convert.ToInt32(Number[i]);

            int primecount = 0;

            for(int i = 0; i < num.Length; i++)
            {
                int valid = 1;
                for (int j = 2; j < num[i]; j++)
                {
                    if (num[i] % j == 0)
                    {
                        valid = 0;
                        break;
                    }
                }
                if (num[i] == 1)
                    valid = 0;

                if(valid == 1)
                    primecount++;
            }

            WriteLine(primecount);
        }
    }
}