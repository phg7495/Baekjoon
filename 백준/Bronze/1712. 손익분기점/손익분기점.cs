using System;
using static System.Console;

namespace HelloWorld
{
    class BreakEvenPoint
    {
        public int CalBreakEvenPoint(int A, int B, int C)
        {
            if(B==C)
                return -1;

            int i = A/(C-B);    // 손익분기점
            int revenue;

            if(i<0)
                return -1;

            while(true)
            {
                revenue = (C - B) * i - A;
                if (revenue <= 0)
                    i++;
                else
                    return i;
            }    

            
        }
    }
    class MainApp
    {
        
        static void Main(string[] args)
        {
            string A = ReadLine();
            string[] B = A.Split(' ');
            int[] bep = new int[3];
            
            for (int i = 0; i < bep.Length; i++)
            {
                bep[i] = Convert.ToInt32(B[i]);
            }

            BreakEvenPoint breakevenpoint = new BreakEvenPoint();
            WriteLine(breakevenpoint.CalBreakEvenPoint(bep[0], bep[1], bep[2]));
        }
    }
}