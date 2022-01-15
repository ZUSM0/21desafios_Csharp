using System;

namespace desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Exercício 16/21:

              Faça um programa que leia um nome de usuário e sua senha e mão aceite nome igual a senha, mostrando uma mensagem de erro e pedindo para o usuário inserir novamente as duas informações.
              Se o usuário inserir o nome diferente da senha, o programa deve ser finalizado.

              Por exemplo:

              Digite seu nome: Willian
              Digite sua senha: Willian

              Mostrar na tela: O nome do usuário e a senha não podem ser os mesmos. 

              Digite seu nome:
              Digite sua senha: 
            */
            while (true){
                Console.Write("Digite seu nome:");
                string name = Console.ReadLine();
                Console.Write("Digite sua senha:");
                string password = Console.ReadLine();

                if(name.Substring(0).ToLower() == password.Substring(0).ToLower()){
                    Console.WriteLine("\r\nA senha e o nome não podem ser iguais...\r\nPor favor tente novamente.");
                }
                else{
                    Console.WriteLine("\r\nNome e senha são válidos.");
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
