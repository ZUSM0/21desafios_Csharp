using System;

namespace desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 9/21:

               Fazer um algoritmos para ler uma palavra ou uma frase qualquer e contar quantas letras 'A', possui esta frase, independente de letra minúscula ou maiúscula.

               Como deve funcionar:

               Receber 1 palavra ou frase qualquer pelo usuário;
               Mostrar no console, quantas vezes a letra 'A' aparece.

               Por exemplo:

               Na frase: Programação aplicada, a letra A aparece 5 vezes.
               Obs: Não considerar letras 'A' com acento.
             */

            Console.Write("Digite uma palava qualquer: ");
            string word = Console.ReadLine();

            int cont = 0;
            foreach (char letter in word){

                if (letter == char.Parse("a") || letter == char.Parse("A")){
                    
                    cont++;
                }
            }

            Console.WriteLine($"A quantidade de letras 'a' nessa palavra são {cont}.");
            Console.ReadKey();
        }
    }
}
