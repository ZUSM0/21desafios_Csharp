using System;

namespace desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 10/21:

               Fazer um algoritmos para ler 10 números, e mostre os números na ordem inversa do que você inseriu.

               Como deve funcionar:

               Receber 10 números;
               Mostrar no console os números na ordem inversa;

               Por exemplo:

               Ler 1,5,7,3,8...
               Mostrar no console ...8,3,7,5,1
             */
            int[] numbers = new int[10];

            for(int n = 1; n <= 10; n++){
                Console.Write($"Digite o {n}º número:");
                numbers[n - 1] = int.Parse(Console.ReadLine());
            
            }
            Array.Reverse(numbers);
            Console.WriteLine($"A sequência ao contrário dos números que você digitou foram: ");
            foreach(int n in numbers){
                Console.WriteLine(n);
            }

        }
    }
}
