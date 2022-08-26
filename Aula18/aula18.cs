using System;

namespace Aula18
{
    class Program
    {
        static void Main()
        {
            int[] num = { 11, 22, 33 };
            string[] veiculo = { "Carro", "Moto", "Busão" };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(veiculo[i]);
                }
            }
        }
    }
}