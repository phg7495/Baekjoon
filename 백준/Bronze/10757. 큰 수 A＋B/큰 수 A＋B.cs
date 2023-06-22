using System;
using static System.Console;

namespace LargePlus
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');

            char[] arrA = inputarray[0].ToCharArray();
            char[] arrB = inputarray[1].ToCharArray();

            int[] A = new int[arrA.Length];
            int[] B = new int[arrB.Length];

            for (int i = arrA.Length - 1; i >= 0; i--)
                A[i] = Convert.ToInt32(arrA[i].ToString());
            for (int i = arrB.Length - 1; i >= 0; i--)
                B[i] = Convert.ToInt32(arrB[i].ToString());

            if (A.Length >= B.Length)
            {
                for(int i = 1; i <= B.Length; i++)
                {
                    A[A.Length-i] += B[B.Length-i];
                    for (int j = 1; j <= A.Length; j++)
                    {
                        if (A[A.Length - j] >= 10 && A.Length - j != 0)
                        {
                            A[A.Length - (j + 1)] += 1;
                            A[A.Length - j] -= 10;
                        }
                    }
                }
                foreach (int i in A)
                    Write(i);
            }
            else
            {
                for (int i = 1; i <= A.Length; i++)
                {
                    B[B.Length - i] += A[A.Length - i];
                    for (int j = 1; j <= B.Length; j++)
                    {
                        if (B[B.Length - j] >= 10 && B.Length - j != 0)
                        {
                            B[B.Length - (j + 1)] += 1;
                            B[B.Length - j] -= 10;
                        }
                    }
                }
                foreach (int i in B)
                    Write(i);
            }
        }
    }
}