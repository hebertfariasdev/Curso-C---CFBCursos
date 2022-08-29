using System;

namespace Aula20
{
    class Program
    {
        static void Main()
        {
            int[] num = new int[10];

            int i=num.Length-1;
            while(i > 0)
            {
                num[i]=i;
                Console.WriteLine("Num: {0}", num[i]);
                i--;
            }
        }
    }
}