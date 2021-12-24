using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 2/21:

               Fazer um algoritmo para converter metros em centímetros.

               Como deve funcionar:

               Receber quantos metros você quer converter;
               Para este exercício, você deverá utilizar o tipo de dados float para armazenar os valores
               Realizar o cálculo acima;
               Mostrar o resultado na tela;

               Por exemplo:

               1 metro é igual a 100 centímetros.
            */

            Console.Write("Digite um valor em metros(m):");
            float meters = float.Parse(Console.ReadLine());

            float converted = meters * 100;

            Console.WriteLine("Calculando...");
            Console.WriteLine($"{meters} metros é igual a {converted} centimetros");
            Console.ReadKey();

        }
    }
}
