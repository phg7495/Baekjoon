using System;
using static System.Console;

namespace BePresident
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string TestCase = ReadLine();
            int T = Convert.ToInt32(TestCase);
            int[] Output = new int[T];

            for (int i = 0; i < T; i++)
            {

                string Height = ReadLine();
                string Width = ReadLine();
                int k = Convert.ToInt32(Height);
                int n = Convert.ToInt32(Width);

                int[,] room = new int[k+1, n];

                for(int j = 0; j <= k; j++)
                {
                    for(int m = 0; m < n; m++)
                    {
                        if(j == 0)
                            room[j, m] = m+1;
                        else if(m == 0)
                            room[j, m] = 1;
                        else
                            room[j, m] = room[j, m - 1] + room[j - 1, m];
                    }
                }
                Output[i] = room[k,n-1];
            }
            foreach(int i in Output)
                Console.WriteLine(i);
        }
    }
}