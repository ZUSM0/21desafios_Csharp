using System;

namespace desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 6/21:

               Crie um algoritmo que informe o peso ideal de uma pessoa.

               Como deve funcionar:

               Receber a altura da pessoa em metros. Por exemplo: 1,85;
               Multiplique a altura por 72,7;
               Diminua o resultado da multiplicação por 58
               Mostre o resultado na tela;

               Fórmula completa: 

               (altura * 72,7) - 58
             */

            Console.Write("Digite sua altura:");
            float height = float.Parse(Console.ReadLine());

            float ideal_weight = (height * 72.7f) - 58;
            Console.WriteLine($" seu peso ideal é {ideal_weight}.");
            Console.ReadKey();
        }
    }
}
