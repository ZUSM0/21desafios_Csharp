using System;
using System.Collections.Generic;

namespace desafio13
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *Exercício 13/21:

              Fazer um algoritmos para ler 5 palavras e independente da forma que o usuário escreva estas palavras, mostrar a primeira letra maiúscula e as demais letras minúsculas.

              Como deve funcionar:

              Receber 5 palavras (independente de maiúscula ou minúscula);
              Mostrar no console as cinco palavras, uma abaixo da outra, apenas com a primeira letra maiúscula;

              Por exemplo:

              Ler: Maça, aBaCaXI, UVA, laranja e LiMãO

              Mostrar no console:

              Maça
              Abacaxi
              Uva
              Laranja
              Limão
             */

            string[] word = new string[5];

            for (int w = 1; w <= 5; w++){
                Console.Write($"Digite a {w} palavra:");
                word[w-1] = Console.ReadLine();
               
            }
            Console.WriteLine("\r\nAs palavras que você digitou foram:");
            foreach(string c in word){
                Console.WriteLine(c.Substring(0, 1).ToUpper() + c.Substring(1).ToLower());
            }



        }
    }
}
