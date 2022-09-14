using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor raio do circulo:");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Pi");
            double valor = double.Parse(Console.ReadLine());
            
            double total;

            total = valor * (raio * raio);

            Console.WriteLine("O valor da área é de " + total.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}