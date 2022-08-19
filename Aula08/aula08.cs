using System;

namespace Aula08
{
    class Program
    {
        static void Main()
        {
            int num1, num2;
            string nome;

            Console.Write("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.Write("\nInforme o 1° nuúmero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2° nuúmero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} a soma é {1} ", nome, (num1 + num2));
        }
    }
}