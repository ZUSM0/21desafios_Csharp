using System;

namespace desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 5/21:

               Fazer um algoritmo para ler 5 números com casas decimais e mostrar a média destes números na tela.

               Como deve funcionar:

               Receber 5 números;
               Calcular a média;
               Mostrar o resultado na tela; 
             */

            Console.Write("Digite o 1º número:");
            float one = float.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número:");
            float two = float.Parse(Console.ReadLine());
            Console.Write("Digite o 3º número:");
            float three = float.Parse(Console.ReadLine());
            Console.Write("Digite o 4º número:");
            float four = float.Parse(Console.ReadLine());
            Console.Write("Digite o 5º número:");
            float five = float.Parse(Console.ReadLine());

            float average = (one + two + three + four + five) / 5;

            Console.WriteLine($"\r\nA média dos valores digitados é {average}");
            Console.ReadKey();
        }
    }
}
