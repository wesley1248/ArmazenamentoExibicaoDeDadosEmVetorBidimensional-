using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeMeidasComv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedido de entrada para o usuario digitar a quantidade de linhas e colunas da matrix.
            Console.Write("Digite a quantidade de linhas ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas ");
            int colunas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declaraçao e instanciaçao da matrix.
            int[,] matrix = new int[linhas,colunas];

            //Armazenagem de dados dentro da matrix.
            for (int i =0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++) //vERIFICAR ERRO DESSA LINHA, E VERIFICAR A EXIBIÇAO DAS MENSAGENS.
                {
                    Console.WriteLine($"Digite o numero para ser armazenado na linha {i} e coluna {j} ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Registrado na posiçao: linha {i} e coluna {j}.");
                    while (i == linhas)
                    {
                        Console.WriteLine("LINHAS REGISTRDAS");
                    }
                    while (j == colunas)
                    {
                        Console.WriteLine("COLUNAS REGISTRADAS");
                    }
                    Console.WriteLine();
                }          
                Console.ReadKey();
            }
        }
    }
}
