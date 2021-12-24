using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 1/21:

               Fazer um algoritmo para somar 2 números e multiplicar o resultado pelo segundo número.


               Como deve funcionar:

               Receber o 1° número;
               Receber o 2° número:
               Realizar o cálculo acima;
               Mostrar o resultado na tela;
             */

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
