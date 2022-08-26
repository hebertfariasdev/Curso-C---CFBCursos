using System;

namespace Aula16
{
    class Program
    {
        static void Main()
        {
            int preco = 5, opcao = 0;
            string[] transporte= new String[] {"Avião", "Carro", "Busão"};

            Incio:
            Console.Clear();

            Console.WriteLine("SP a RJ");
            Console.WriteLine("Escolha um transporte: [1]Avião  |  [2]Carro   |  [3]Busão");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nO transporte escolhido: {0} \nValor: R$ {1}", transporte[opcao-1], preco + (preco * 0.5));
                    break;
                case 2:
                    Console.WriteLine("\nO transporte escolhido: {0} \nValor: R$ {1}", transporte[opcao-1], preco + (preco * 0.3));
                    break;
                case 3:
                    Console.WriteLine("\nO transporte escolhido: {0} \nValor: R$ {1}", transporte[opcao-1], preco + (preco * 0.15));
                    break;
                default:
                    Console.WriteLine("Informe uma opção de transporte!!");
                    break;
            }

            Console.WriteLine("\nDeseja escolher mais algum transporte? [S/N]");
            char sn = char.Parse(Console.ReadLine());
            if(sn == 's' || sn == 'S')
            {
                goto Incio;
            }
            else{
                Console.Clear();
                Console.WriteLine("FIM");
            }


        }
    }
}