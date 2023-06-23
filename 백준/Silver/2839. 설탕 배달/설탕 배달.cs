using System;
using static System.Console;

namespace SugarDelivery
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string weight = ReadLine();
            int N = Convert.ToInt32(weight);
            int rm;
            int i = 0;
            int count = 0;

            while(true)
            {
                rm = N - (5 * i);
                if (N % 5 == 0)
                {
                    count = N / 5;
                    break;
                }
                else if (rm == 3 || rm == 6 || rm == 9 || rm == 12)
                {
                    count = i + rm / 3;

                    break;
                }
                else if(rm < 5)
                {
                    count = -1;
                    break;
                }
                i++;
            }
            WriteLine(count);
        }
    }
}