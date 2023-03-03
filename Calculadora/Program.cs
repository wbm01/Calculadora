﻿using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2;
        int opcao = 0;

        void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;

                    case 1: Console.WriteLine("A soma dos números é: "+(n1+n2));
                    Console.ReadLine();
                    break;

                    case 2: Console.WriteLine("A subtração dos números é: " +(n1 - n2));
                    Console.ReadLine();
                    break;

                    case 3: Console.WriteLine("A multiplicação dos números é: " +(n1*n2));
                    Console.ReadLine();
                    break;

                    case 4:

                    if (n2 == 0) {
                        Console.WriteLine("Não é possível dividir por zero!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("A divisão dos números é: " + (n1 / n2));
                        Console.ReadLine();
                        break;
                    }
                    

                    case 5: Console.WriteLine("Fim do programa!");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Informe o primeiro número: ");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        n2 = double.Parse(Console.ReadLine());

        while (opcao != 5)
        {
            Menu();
        }
    }
}