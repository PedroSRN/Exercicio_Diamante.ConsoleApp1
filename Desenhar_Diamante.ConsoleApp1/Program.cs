using System;

namespace Desenhar_Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*Diamante passado pelo rech em sala na correção com implemantações de menu e validação do numero impar */

                #region Declaração de variáveis e captura do tamanho do diamante

                int tamanhoDiamante, opcao;

            #region menu de opções
            while (true)
            {
                Console.WriteLine("Menu de opções");
                Console.WriteLine("Digite 1 para desenhar um diamante");
                Console.WriteLine("Digite 2 para sair do programa");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

             #endregion

                //opcao de desenhar o diamante na tela
                if (opcao == 1)
                {
                    Console.WriteLine("Digite o tamanho do diamante: ");
                    tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");

                    int quantidadeInicialEspacos = (tamanhoDiamante - 1) / 2;

                    int quantidadeDeX = 1;

                    int quantidadeDeLinhasSuperior = (tamanhoDiamante - 1) / 2;

                    int quantidadeDeLinhasInferior = (tamanhoDiamante - 1) / 2;

                    #endregion

                    #region
                    if (tamanhoDiamante % 2 == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Por favor digite um número Impar");
                        Console.WriteLine(" ");
                        continue;
                    }
                    #endregion


                    #region calculo da parte de cima do diamante

                    for (int linha = 0; linha < quantidadeDeLinhasSuperior; linha++)
                    {
                        for (int i = 0; i < quantidadeInicialEspacos; i++)
                        {
                            Console.Write(" ");
                        }
                        for (int i = 0; i < quantidadeDeX; i++)
                        {
                            Console.Write("x");
                        }

                        //variaveis de  controle
                        quantidadeInicialEspacos--;
                        quantidadeDeX += 2;

                        Console.WriteLine(" ");
                    }

                    #endregion

                    #region Calculo da parte do meio do diamante

                    for (int coluna = 0; coluna < tamanhoDiamante; coluna++)
                    {
                        Console.Write("x");

                    }
                    quantidadeInicialEspacos++;
                    quantidadeDeX -= 2;

                    Console.WriteLine(" ");

                    #endregion

                    #region Calculo da parte de baixo do diamante

                    for (int linha = 0; linha < quantidadeDeLinhasInferior; linha++)
                    {
                        for (int i = 0; i < quantidadeInicialEspacos; i++)
                        {
                            Console.Write(" ");
                        }

                        for (int i = 0; i < quantidadeDeX; i++)
                        {
                            Console.Write("x");
                        }

                        //variaveis de  controle
                        quantidadeInicialEspacos++;
                        quantidadeDeX -= 2;
                        Console.WriteLine(" ");
                    }
                    #endregion

                    Console.WriteLine(" ");
                    Console.WriteLine("Pressione enter para continuar...");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                }

                //opcao sair
                if(opcao != 1)
                {

                    break;
                }
            }
        }
    }
}
