using System;

namespace desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 8/21:

               Fazer um algoritmo para ler 3 palavras aleatórias e mostrar a palavra com maior quantidade de caracteres.

               Como deve funcionar:

               Receber 3 palavras aleatórios pelo usuário;
               Mostrar a palavra com maior número de caracteres;

               Exemplo: 
               Maça
               Melancia
               Banana

               A palavra que contém mais letras é Melancia.
             */
            
            string bigger = string.Empty;

            for(int n = 1; n <= 3; n++){
                Console.Write($"Digite a {n}º palavra:");
                string word = Console.ReadLine();

                
                if (bigger.Length <= word.Length){
                    bigger = word;

                }
            }

            Console.WriteLine($"\r\nA palavra que contém mais letras é {bigger}.");
            Console.ReadKey();
        }
    }
}
