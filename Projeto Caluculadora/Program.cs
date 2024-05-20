using System;

namespace Projeto_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.WriteLine("Qual operação gostaria de fazer?");
            Console.WriteLine("1 Adição");
            Console.WriteLine("2 Subtração");
            Console.WriteLine("3 Multiplicação");
            Console.WriteLine("4 Divisão");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor da operação");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor da operação");
            int v2 = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                res = v1 + v2;
                Console.WriteLine("O valor da operação {0} + {1} = {2}", v1, v2, res);
            }
            else if (operacao == 2)
            {
                res = v1 - v2;
                Console.WriteLine("O valor da operação {0} - {1} = {2}", v1, v2, res);
            }
            else if (operacao == 3)
            {
                res = v1 * v2;
                Console.WriteLine("O valor da operação {0} x {1} = {2}", v1, v2, res);
            }
            else if (operacao == 4)
            {
                if (v2 != 0)
                {
                    res = v1 / v2;
                    Console.WriteLine("O valor da operação {0} / {1} = {2}", v1, v2, res);
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida. Tente novamente!");
            }
            Console.ReadLine();
        }
    }
}
