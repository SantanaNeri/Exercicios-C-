using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            double diferenca = (A * B - C * D);

            Console.WriteLine("A difrença entre os valores é "+diferenca.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}