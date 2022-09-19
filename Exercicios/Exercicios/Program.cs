using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Senha errada, digite novamente a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}