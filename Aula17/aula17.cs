using System;

namespace Aula17
{
    class Program
    {
        static void Main()
        {
            int[] num = { 11, 22, 33 };
            string[] veiculo = { "Carro", "Moto", "Busão" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(veiculo[i]);
            }
        }
    }
}