using System;

namespace desafio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 14/21:

               Mostrar a tabuada de um número específico.

               Como deve funcionar:

               Receber um número qualquer, e mostrar a sua tabuada.

               Por exemplo:

               Ler: 6

               Mostrar no console:

               6 x 1 = 6
               6 x 1 = 6
               6 x 1  = 6
               6 x 2  = 12
               6 x 3  = 18
               6 x 4  = 24
               6 x 5  = 30
               6 x 6  = 36
               6 x 7  = 42
               6 x 8  = 48
               6 x 9  = 54
               6 x 10 = 60
             */

            Console.Write("Qual número você deseja ver a tabuada?");
            int number = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"tabuada do número {number}:\r\n");
            for (int n = 1; n <=10; n++){
                int result = number * n;
                Console.WriteLine($"{n} x {number} = {result}");
            }
        }
    }
}
