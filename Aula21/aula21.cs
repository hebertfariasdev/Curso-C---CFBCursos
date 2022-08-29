using System;

namespace Aula21
{
    class Program
    {
        static void Main()
        {

            string senha = "123", senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhauser = Console.ReadLine();
                tentativas++;
            }while(senha != senhauser);

            Console.Clear();
            Console.WriteLine("Senha validada com sucesso!! Tentativa:{0}", tentativas);
        }
    }
}