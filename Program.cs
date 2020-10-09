using System;
using Examples.LinearAlgebraExamples;
using MathNet.Numerics;

namespace MathNET.FuncoesEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            var DirectSolvers1 = new DirectSolvers();
            Console.WriteLine("Classe: "+ DirectSolvers1.Name );
            Console.WriteLine("Descrição: "+ DirectSolvers1.Description);
            DirectSolvers1.Run();
            CalcularHipotenusa();
            CalcularFatorial();
            CalcularCoeficienteBinomial();
            Console.WriteLine("Pressione algo para encerrar...");
            Console.ReadLine();
        }

        private static void CalcularHipotenusa()
        {
            Console.WriteLine("1. Calcular a Hipotenusa, dados os catetos: c1 e c2");
            while (true)
            {
                Console.WriteLine("Informe o primeiro cateto ( 999 -> Sai )");
                string cateto1 = Console.ReadLine();
                Console.WriteLine("Informe o outro cateto (999 -> Sai )");
                string cateto2 = Console.ReadLine();
                double c1, c2;
                if (Double.TryParse(cateto1, out c1))
                {
                    if (c1 == 999)
                    {
                        break;
                    }
                    if (Double.TryParse(cateto2, out c2))
                    {
                        if (c2 == 999)
                        {
                            break;
                        }
                        Console.WriteLine($" Valor da Hipotenusa para os catetos : " +
                            $"{c1} e {c2}) = {SpecialFunctions.Hypotenuse(c1, c2).ToString("N")}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor do cateto inválido...");
                    }
                }
                else
                {
                    Console.WriteLine("Valor do cateto inválido...");
                }
            }
        }

        private static void CalcularCoeficienteBinomial()
        {
            Console.WriteLine("1. Calcular o Coeficiente Binomial entre os números n e p");
            while (true)
            {
                Console.WriteLine("Informe o número n entre 1 a 200 ( 999 -> Sai )");
                string numero1 = Console.ReadLine();
                Console.WriteLine("Informe o número p entre 1 a 200 ( 999 -> Sai )");
                string numero2 = Console.ReadLine();
                int n;
                int p;
                if (Int32.TryParse(numero1, out n))
                {
                    if (n == 999)
                    {
                        break;
                    }
                    if (Int32.TryParse(numero2, out p))
                    {
                        if (p == 999)
                        {
                            break;
                        }
                        Console.WriteLine($" C({n},{p}) = {SpecialFunctions.Binomial(n, p).ToString("N")}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Valor de p inválido...");
                    }
                }
                else
                {
                    Console.WriteLine("Valor de n inválido...");
                }
            }
        }


        private static void CalcularFatorial()
        {
            // 1. Calcula o fatorial de um número
            Console.WriteLine("1. Calcular o fatorial de um número");
            while (true)
            {
                Console.WriteLine("Informe um número de 1 a 100 ( 999 -> Sai )");
                string input = Console.ReadLine();
                int n;
                if (Int32.TryParse(input, out n))
                {
                    if (n == 999)
                    {
                        break;
                    }
                    Console.WriteLine(SpecialFunctions.Factorial(n).ToString("N"));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Valor inválido...");
                }
            }
        }
    }
}
