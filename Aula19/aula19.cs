using System;

namespace Aula19
{
    class Program
    {
        static void Main()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                num[i]=i;
                Console.WriteLine("Valor de 'i' = {0} na posição {1}", i, num[i]);
            }
        }
    }
}