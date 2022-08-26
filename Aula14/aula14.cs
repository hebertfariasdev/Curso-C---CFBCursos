using System;

namespace Aula14
{
    class Program
    {
        static void Main()
        {
            float nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, media = 0;

            Console.Write("Informe a nota 1: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Informe a nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.Write("Informe a nota 4: ");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A sua média é: {0} ", media);

            if (media >= 60)
            {
                if (media >= 90)
                {
                    Console.WriteLine("\nAprovado com louvor");
                }
                else
                {
                    Console.WriteLine("\nAprovado");
                }
            }
            else
            {
                if (media >= 40)
                {
                    Console.WriteLine("\nRecuperação");
                }
                else
                {
                    Console.WriteLine("\nReprovado");
                }
            }

        }
    }
}