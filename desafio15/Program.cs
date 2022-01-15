using System;

namespace desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Exercício 15/21:

              Mostrar a tabuada completa de 1x1 até 10x10.

              Dica:

              Você deve utilizar laços de repetição entrelaçados para resolver este exercício.
            */

            for(int n = 1; n <= 10; n++){

                Console.WriteLine($"Tabuada do número {n}:\r\n");

                for(int u = 1; u <= 10; u++){
                    int result = n * u;

                    Console.WriteLine($"{n} x {u} = {result}");
                }
                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=");
            }

            Console.ReadKey();
        }
    }
}
