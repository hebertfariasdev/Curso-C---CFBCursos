using System;

namespace Aula18
{
    class Program
    {
        static void Main()
        {
            int[,] n = new int[3, 5];

            n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 30; n[0, 3] = 40; n[0, 4] = 50;
            n[1, 0] = 60; n[1, 1] = 70; n[1, 2] = 80; n[1, 3] = 90; n[1, 4] = 100;
            n[2, 0] = 110; n[2, 1] = 120; n[2, 2] = 130; n[2, 3] = 140; n[2, 4] = 150;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(n[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}