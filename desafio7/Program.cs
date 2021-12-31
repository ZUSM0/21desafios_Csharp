using System;
using System.Collections.Generic;

namespace desafio7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Exercício 7/21:

               Fazer um algoritmo para ler 10 números inteiros e mostrar na tela apenas os números pares;

               Como deve funcionar:

               Receber 10 números aleatórios pelo usuário;
               Mostrar na tela apenas os números pares;
            */
            List<int> pair = new List<int>();

            for(int n = 1; n <= 10; n += 1){ 
                Console.Write($"Digite o {n}º número:");
                int number = int.Parse(Console.ReadLine());
                
                if (number % 2 == 0){
                    pair.Add(number);
                } 
            }
            Console.Clear();
            Console.WriteLine($"Os números pares que você digitou foram: ");
            foreach(int p in pair){
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
