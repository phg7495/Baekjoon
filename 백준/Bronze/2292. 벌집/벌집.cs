using System;
using static System.Console;

namespace Honeycomb
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string num = ReadLine();
            int N = Convert.ToInt32(num);
            int count = 1;
            int n = 0;

            for(int i = 1; true; i++)
            {
                if (N - 1 <= 6 * n)
                {
                    WriteLine(count);
                    break;
                }
                else
                {
                    count++;
                    n += i;
                }
            }
        }
    }
}