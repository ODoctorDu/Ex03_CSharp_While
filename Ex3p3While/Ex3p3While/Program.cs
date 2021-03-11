using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3p3While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida. ");
            Console.WriteLine("Para cada leitura de senha incorreta informada, escrever a mensagem 'Senha Invalida'.");
            Console.WriteLine("Quando a senha for informada corretamente deve ser impressa a mensagem 'Acesso Permitido'");
            Console.WriteLine("e o algoritmo encerrado.Considere que a senha correta é o valor 2002.\n");

            Console.Write("Digite a Senha: ");
            double senha = double.Parse(Console.ReadLine());

            int i = 0;

            while (i == 0)
            {
                Console.Write("Digite a senha a ser comparada: ");
                double senha2 = double.Parse(Console.ReadLine());

                if(senha == senha2)
                {
                    Console.WriteLine("Parabéns, você advinhou a senha!");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Infelizmente sua senha está errada. ");
                }
            }
            Console.ReadKey();
        }
        
               
    }
}
