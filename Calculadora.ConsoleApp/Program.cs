using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(String[] args)
        {
            string opcao = " ";
            double n1;
            double n2;
            string operadorSelecionado = " ";
            bool continuar = true;
            string[] historicoOperacao = new string[10];
            int contadorDeOperacoes = 0;

            while (continuar == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Calculadora 1.0");
                Console.ResetColor();
                Console.WriteLine("======================================");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para visualizar operações");
                Console.WriteLine("Digite s para sair");
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.Write("Comando: ");
                opcao = Console.ReadLine();
                Console.WriteLine();

                if ((opcao != "s") && (opcao != "1") && (opcao != "2")
                    && (opcao != "3") && (opcao != "4") && (opcao != "5"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Opção inválida: tente novamente ");
                    Console.ResetColor();
                    opcao = Console.ReadLine();
                    Console.WriteLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "5")
                {
                    if (contadorDeOperacoes == 0)
                    {
                        Console.WriteLine("Nenhuma operação realizada, realize uma nova operação!");
                    }
                    else
                    {
                        for (int i = 0; i < historicoOperacao.Length; i++)
                        {
                            if(historicoOperacao[i] != null)
                            {
                                if (historicoOperacao[i].Contains("+"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                }
                                else if (historicoOperacao[i].Contains("-"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                }
                                Console.WriteLine(historicoOperacao[i]);
                            }
                        }
                    }
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                    }
                if (opcao == "s")
                    break;

                Console.Write("Digite o primeiro número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine();

                double resultadoOperacao = 0;

                if (opcao == "1")
                {
                    operadorSelecionado = "+";
                    resultadoOperacao = n1 + n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Resultado da soma: " + Math.Round(resultadoOperacao, 2));
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    continuar = true;
                }
                else if (opcao == "2")
                {
                    operadorSelecionado = "-";
                    resultadoOperacao = n1 - n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Resultado da subtração: " + Math.Round(resultadoOperacao, 2));
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    continuar = true;
                }
                else if (opcao == "3")
                {
                    operadorSelecionado = "*";
                    resultadoOperacao = n1 * n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Resultado da multiplicação: " + Math.Round(resultadoOperacao, 2));
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    continuar = true;
                }
                else if (opcao == "4")
                {
                    operadorSelecionado = "/";
                    while (n2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Segundo número inválido! Divisão por zero");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("Digite um segundo número válido: ");
                        n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        continue;
                    }
                    resultadoOperacao = n1 / n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Resultado da divisão: " + Math.Round(resultadoOperacao, 2));
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    continuar = true;
                }

                historicoOperacao[contadorDeOperacoes] = n1 + " " + operadorSelecionado + " " +
                    n2 + " = " + Math.Round(resultadoOperacao, 2);

                contadorDeOperacoes++;

                //if(historicoOperacoes == " ")
                //{
                //    historicoOperacoes = n1 + " " + operadorSelecionado
                //    + n2 + " = " + Math.Round(resultadoOperacao, 2);
                //    continue;

                //}
                //else
                //{
                //    historicoOperacoes += "\n"+ n1 + " " + operadorSelecionado
                //    + n2 + " = " + Math.Round(resultadoOperacao, 2);
                //}

                Console.WriteLine("======================================");

                /////*
                ////conversao
                ////Console.Write("Escreva um número: ");
                ////string strNumero = Console.ReadLine();
                ////int Numero = System.Convert.ToInt32(strNumero);
                ////*/
                ///
            }
        }
    }
}

