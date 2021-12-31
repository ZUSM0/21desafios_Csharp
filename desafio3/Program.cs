using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 3/21:

               Fazer um algoritmo para ler um número inteiro e imprimir este número na tela apenas se o seu valor for maior do que 100, caso contrário imprima na tela 0. 

               Como deve funcionar:

               Receber um número;
               Criar a condição para verificar se o número é maior do que 100;
               Mostrar o resultado na tela;
            */

            Console.Write("Digite um número qualquer:");
            int number = int.Parse(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine($"Você digitou {number}, e ele é maior que 100.");
            }

            else if (number == 100)
            {
                Console.WriteLine($"Você digitou o digitou o número 100.");
            }

            else
            {
                Console.WriteLine($"0\r\nVocê digitou o número {number}, e ele é menor que 100.");
                
            }

            Console.ReadKey();
        }
    }
}
