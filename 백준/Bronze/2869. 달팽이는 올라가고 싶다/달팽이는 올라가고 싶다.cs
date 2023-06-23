using System;
using static System.Console;

namespace SnailClimb
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string input = ReadLine();
            string[] split = input.Split(' ');
            
            int A = int.Parse(split[0]);
            int B = int.Parse(split[1]);
            int V = int.Parse(split[2]);

            int day =(V - A)/(A - B);

            if(V == (A - B)*day + A)
                WriteLine(day + 1);
            else
                WriteLine(day + 2);
        }
    }
}