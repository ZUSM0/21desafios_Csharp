using System;
using System.Collections.Generic;

namespace desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 12/21:

               Fazer um algoritmos para ler um vetor de números inteiros de "x" elementos, o "x" deve ser recebido via console pelo usuário, mostrar no console de forma separada os números pares e ímpares.

               Como deve funcionar:

               O usuário deve inserir um número informando quantos elementos deve conter o vetor;
               Receber "x" elementos;
               Mostrar no console primeiro os números impares e depois os pares;

               Por exemplo:

               Inserir no console o número de elementos do vetor inteiro, por exemplo 13.
               Inserir 13 números inteiros;
               Mostrar no console, os números impares são: ...
               E logo abaixo mostrar, os números pares são: ...
             */

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            Console.Write("Quantos números você quer ver?");

            int number = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= number; i++){
                if (i % 2 == 0)
                {
                    even.Add(i);
                }

                else if (i % 2 == 1)
                {
                    odd.Add(i);
                }
            }

            Console.Write("\n\nOs números pares são: ");
            return_numbers(even);
            Console.Write("\r\nOs números impares são: ");
            return_numbers(odd);

            Console.ReadKey();
        }

        static void return_numbers(List<int> n)
        {
            foreach (int number in n){
                Console.Write($"{number} ");
            }
        }
    }
}
