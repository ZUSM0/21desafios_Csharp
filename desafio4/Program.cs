using System;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior;

            Console.Write("Digite o primeiro número:");
            int one = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número:");
            int two = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número:");
            int three = int.Parse(Console.ReadLine());

            if (one >= two && one >= three)
            {
                maior = one;
            }
            else if(two >= one && two >= three)
            {
                maior = two;
            }

            else if(three >= one && three >= two)
            {
                maior  = three;
            }

            Console.WriteLine(value: $"O maior número é ");
        }
    }
}
