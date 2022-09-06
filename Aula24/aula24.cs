using System;

namespace Aula24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Número de vezes: ");
            int num = int.Parse(Console.ReadLine());

            Vezes(num);
            Soma(5,9);
        }

        static void Vezes(int v)
        {
            Console.WriteLine();
            for (int i = 0; i < v; i++)
            {
                Console.Write("Repetição {0}:  ", i + 1);
                Metodo();
            }
        }
        static void Metodo()
        {
            Console.WriteLine("Xablau");
        }

        static void Soma(int n1, int n2)
        {
            int s = n1 + n2;

            Console.WriteLine("\nSoma de {0} + {1} = {2}", n1, n2, s);
        }
    }
}