using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor em metros(m):");
            float meters = float.Parse(Console.ReadLine());

            float converted = meters * 100;

            Console.WriteLine("Calculando...");
            Console.WriteLine($"{meters} metros é igual a {converted} centimetros");
            Console.ReadKey();

        }
    }
}
