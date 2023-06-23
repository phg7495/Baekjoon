using System;
using static System.Console;

namespace ACMHotel
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string Test = ReadLine();
            int T = Convert.ToInt32(Test);
            int[] X = new int[T];
            int[] Y = new int[T];

            for (int i = 0; i < T; i++)
            {

                string[] input = Console.ReadLine().Split(' ');

                int H = Convert.ToInt32(input[0]);
                int W = Convert.ToInt32(input[1]);
                int N = Convert.ToInt32(input[2]);

                X[i] = 1;
                Y[i] = 1;

                for (int j = 1; j < N; j++)
                {
                    if (Y[i] == H)
                    {
                        Y[i] = 1;
                        X[i]++;
                    }
                    else
                        Y[i]++;
                }
            }

            for (int i = 0; i < T; i++)
                WriteLine("{0}{1:D2}", Y[i], X[i]);
        }
    }
}