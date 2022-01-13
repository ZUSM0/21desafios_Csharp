using System;

namespace desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 11/21:

               Fazer um algoritmos para ler um vetor double de 10 elementos e mostre a soma de todos eles.

               Como deve funcionar:

               Receber 10 números;
               Mostrar no console a soma de todos os números;

               Por exemplo:

               Ler 1,2,3,3...
               Mostrar no console 9            
             */
            double sum = 0;
            for (int i = 1; i <= 10; i++){
                Console.Write($"Digite o {i} número:");
                double number = double.Parse(Console.ReadLine());

                sum += number;
            }

            Console.WriteLine($"A soma de todos os números digitados foi {sum}");
            
            
        }

    }
}
