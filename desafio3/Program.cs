using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
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



        }
    }
}
