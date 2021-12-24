using System;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 4/21:

               Fazer um algoritmo para ler 3 números inteiro e mostrar na tela apenas o maior número entre os 3.

               Como deve funcionar:

               Receber 3 números;
               Verificar o maior número entre os 3;
               Mostrar o resultado na tela;
            */
            
            Console.Write("Digite o primeiro número:");
            int one = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número:");
            int two = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número:");
            int three = int.Parse(Console.ReadLine());

            int maior = one;
            if (one <= two && two >= three)
            {
                maior = two;
            }
            else if (one <= three && three >= two)
            {
                maior = three;
            }

            Console.WriteLine($"O maior número é {maior}");
            Console.ReadKey();
            
        }
    }
}
