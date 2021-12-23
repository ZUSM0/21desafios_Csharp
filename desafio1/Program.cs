using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            Double one = Double.Parse(Console.ReadLine());
            Console.Write("Digite outro número:");
            Double two = Double.Parse(Console.ReadLine());

            Double soma = one + two;
            Double resultado = soma * two;

            Console.WriteLine($"A soma ds números digitados deu {soma}.");
            Console.WriteLine($"Se multiplicarmos {soma} por {two}, o resultado será {resultado}");
            Console.ReadKey();
        }
    }
}
