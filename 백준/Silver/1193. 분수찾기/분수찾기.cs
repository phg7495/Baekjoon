using System;
using static System.Console;

namespace SearchingFraction
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string num = ReadLine();
            int N = Convert.ToInt32(num);
            int n = 0;
            int i = 1;
            int j = 1;

            while(true)
            {
                n += i;
                if( N <= n )
                {
                    if (i % 2 == 1)
                        WriteLine($"{j + (n - N)}/{i - (n - N)}");
                    else
                        WriteLine($"{i - (n - N)}/{j + (n - N)}");
                    break;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}